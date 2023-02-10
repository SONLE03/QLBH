using Supermarket.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Seller : Form
    {
        public Reload reload;
        string imageLocation = "";
        SQLConnection SQLConnection = new SQLConnection();
        md5 md5 = new md5();
        //public static string MD5Hash(string text)
        //{
        //    MD5 md5 = MD5.Create();
        //    byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
        //    StringBuilder hashSb = new StringBuilder();
        //    foreach (byte b in hash)
        //    {
        //        hashSb.Append(b.ToString("X2"));
        //    }
        //    return hashSb.ToString();
        //}
        public Seller()
        {
            InitializeComponent();
        }
        public Seller(Reload _reload)
        {
            InitializeComponent();
            this.reload = _reload;
        }
        private void Seller_Load(object sender, EventArgs e)
        {
            SQLConnection.OpenConnection();
            auto_id();
        }
        private void auto_id()
        {
            CheckKey checkKey = new CheckKey();
            Random rd = new Random();
            int id;
            string check;
            do
            {
                id = rd.Next(100000000, 1000000000);
                check = "Select * from employee where EM_ID = '" + id.ToString() + "'";
            }
            while (checkKey.Check(check));
            this.id.Text = "NV" + id.ToString();
            //SqlCommand sqlCommand = new SqlCommand("AUTOEMID", SQLConnection.con);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //object obj = sqlCommand.ExecuteScalar();
            //this.id.Text = obj.ToString();
        }
        //private bool CheckKey(string sql)
        //{
        //    SQLConnection = new SQLConnection();
        //    SQLConnection.OpenConnection();
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, SQLConnection.con);
        //    DataTable table = new DataTable();
        //    sqlDataAdapter.Fill(table);
        //    if (table.Rows.Count > 0)
        //        return true;
        //    else return false;
        //}
        

        

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void add_I_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            name.Clear();
            username.Clear();
            phone.Clear();
            pass.Clear();
            email.Clear();
            pictureBox1.Image = null;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                string check_em = "select * from employee where em_id = '" + id.Text + "'";
                string sql_UserName = "SELECT EM_USERNAME FROM EMPLOYEE WHERE EM_USERNAME= '" + username.Text + "'";
                CheckKey check = new CheckKey();
                if (pictureBox1.Image == null || position.Text == "" || id.Text == "" || name.Text == "" || username.Text == "" || pass.Text == "" || phone.Text == "" || email.Text == "")
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (check.Check(sql_UserName))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!this.email.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("Email không đúng đỉnh dạng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (phone.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không đúng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string e_position;
                    if (position.Text == "Nhân Viên")
                    {
                        e_position = "NV";
                    }
                    else
                    {
                        e_position = "QTV";
                    }
                    // string query = "INSERT INTO EMPLOYEE(EM_ID, EM_NAME, EM_USERNAME, EM_PASSWORD, EM_PHONE, EM_EMAIL) VALUES(@EM_ID, @EM_NAME, @EM_USERNAME, @EM_PASSWORD, @EM_PHONE, @EM_EMAIL)";
                    SqlCommand sqlCommand = new SqlCommand("InsertEM", SQLConnection.con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@EM_ID", id.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_Name", name.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_USERNAME", username.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_PASSWORD", md5.MD5Hash(pass.Text));
                    sqlCommand.Parameters.AddWithValue("@EM_PHONE", phone.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_EMAIL", email.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_POSITION", e_position);
                    sqlCommand.Parameters.AddWithValue("@EM_IMAGE", imageLocation);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã đăng ký tài khoản thành công");
                    auto_id();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConnection.CloseConnection();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.reload();
            Close();
        }
    }
}
