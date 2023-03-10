using Supermarket.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Supermarket
{
    public partial class SignUp : Form
    {
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
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            SQLConnection.OpenConnection();
            auto_id();
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
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void clear()
        {
            name.Clear();
            usn.Clear();
            phone.Clear();
            pass.Clear();
            mail.Clear();
            pictureBox1.Image = null;
        }

        

        private void add_I_Click(object sender, EventArgs e)
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

        private void BtnSaveE_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_UserName = "SELECT * FROM EMPLOYEE WHERE EM_USERNAME= '" + usn.Text + "'";
                CheckKey check = new CheckKey();
                if (pictureBox1.Image == null || id.Text == "" || name.Text == "" || usn.Text == "" || pass.Text == "" || phone.Text == "" || mail.Text == "")
                {
                    MessageBox.Show("Thông tin đăng ký không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (check.Check(sql_UserName))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!this.mail.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("Email không đúng đỉnh dạng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (phone.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không đúng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Image image = pictureBox1.Image;
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
                    sqlCommand.Parameters.AddWithValue("@EM_USERNAME", usn.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_PASSWORD", md5.MD5Hash(pass.Text));
                    sqlCommand.Parameters.AddWithValue("@EM_PHONE", phone.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_EMAIL", mail.Text);
                    sqlCommand.Parameters.AddWithValue("@EM_POSITION", e_position);
                    sqlCommand.Parameters.AddWithValue("@EM_IMAGE", imageLocation);
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Đã đăng ký tài khoản thành công");
                        auto_id();
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExitE_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
