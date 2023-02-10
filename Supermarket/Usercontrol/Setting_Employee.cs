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

namespace Supermarket
{
    public partial class Setting_Employee : UserControl
    {
        string employee_id = Login.id;
        string imageLocation = "";
        SQLConnection SQLConnection = new SQLConnection();
        md5 md5 = new md5();
        public Setting_Employee()
        {
            InitializeComponent();
        }
        
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
        private void Setting_Employee_Load(object sender, EventArgs e)
        {  
            showdata();
        }
        public void showdata()
        {
            try
            {
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();

                String str = "Select * From EMPLOYEE Where EM_ID = '" + employee_id + "'";

                SqlCommand cmd = new SqlCommand(str, SQLConnection.con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id.Text = employee_id;
                    name.Text = dr.GetValue(1).ToString();
                    username.Text = dr.GetValue(2).ToString();
                    //pass.Text = dr.GetValue(3).ToString();
                    phone.Text = dr.GetValue(4).ToString();
                    email.Text = dr.GetValue(5).ToString();
                    position.Text = dr.GetValue(6).ToString();
                    imageLocation = dr.GetValue(7).ToString();
                }
                SQLConnection.CloseConnection();
                if(position.Text == "QTV")
                {
                    position.Text = "Quản lý";
                }
                else
                {
                    position.Text = "Thu ngân";
                }
                pictureBox1.ImageLocation = imageLocation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        //private void update_pass(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (pass.Text == "")
        //        {
        //            MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            SQLConnection = new SQLConnection();
        //            SQLConnection.OpenConnection();
        //            String str = "Update EMPLOYEE Set EM_PASSWORD = '" + md5.MD5Hash(pass.Text)  + "' Where EM_ID = '" + id.Text + "'";
        //            SqlCommand cmd = new SqlCommand(str, SQLConnection.con);

        //            try
        //            {
        //                cmd.ExecuteNonQuery();
        //                MessageBox.Show("Đã thay đổi thông tin tài khoản thành công");
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void BtnAddI_Click(object sender, EventArgs e)
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

       

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (position.Text == "" || id.Text == "" || name.Text == "" || phone.Text == "" || email.Text == "")
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection = new SQLConnection();
                    SQLConnection.OpenConnection();
                    String str = "Update EMPLOYEE Set EM_PHONE = '" + phone.Text + "',EM_EMAIL = '" + email.Text + "', EM_IMAGE = '" + imageLocation + "' Where EM_ID = '" + id.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, SQLConnection.con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã thay đổi thông tin cá nhân thành công");
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

        private void customPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                if (pass.Text == "")
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection = new SQLConnection();
                    SQLConnection.OpenConnection();
                    String str = "Update EMPLOYEE Set EM_PASSWORD = '" + md5.MD5Hash(pass.Text) + "' Where EM_ID = '" + id.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, SQLConnection.con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã thay đổi thông tin tài khoản thành công");
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

        private void customPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
