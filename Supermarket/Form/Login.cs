using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Supermarket.Class;

namespace Supermarket
{
    public partial class Login : Form
    {
        public static string name { get; set; }
        public static string id { get; set; }
        md5 md5 = new md5();

        SQLConnection SQLConnection = new SQLConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable data = new DataTable();
        public Login()
        {
            InitializeComponent();
        }


        private void tendangnhap_Click(object sender, EventArgs e)
        {
            username.SelectAll();
        }

        private void Matkhau_Click(object sender, EventArgs e)
        {
            password.SelectAll();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            BtnAdminLog.Visible = false;
            //Admin_log.Visible = false;
            Admin.Visible = false;
            BtnStaffLog.Visible = true;
            Em_log.Visible = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                password.UseSystemPasswordChar = true;
            }
            else
            {
                password.UseSystemPasswordChar = false;
            }
        }

       

        private void ForgotPass_Click(object sender, EventArgs e)
        {
            SendEmail send = new SendEmail();
            send.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customLabel3_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdminLog_Click(object sender, EventArgs e)
        {
            string position = "QTV";
            try
            {
                if (username.Text == "Tên đăng nhập" || password.Text == "Mật khẩu")
                {
                    MessageBox.Show("Thông tin đăng nhập không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection.OpenConnection();
                    cmd = SQLConnection.con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * From EMPLOYEE Where EM_USERNAME = '" + username.Text + "' and EM_PASSWORD = '" + md5.MD5Hash(password.Text) + "' and EM_POSITION = '" + position + "'";
                    cmd.ExecuteNonQuery();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        id = sqlDataReader["EM_ID"].ToString();
                        name = sqlDataReader["EM_NAME"].ToString();
                        this.Hide();
                        Home home = new Home();
                        home.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng nhập không chính xác", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    SQLConnection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnStaffLog_Click(object sender, EventArgs e)
        {
            string position = "NV";
            try
            {
                if (username.Text == "" || password.Text == "")
                {
                    MessageBox.Show("Thông tin đăng nhập không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection.OpenConnection();
                    cmd = SQLConnection.con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * From EMPLOYEE Where EM_USERNAME = '" + username.Text + "' and EM_PASSWORD = '" + md5.MD5Hash(password.Text) + "' and EM_POSITION = '" + position + "'";
                    cmd.ExecuteNonQuery();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        id = sqlDataReader["EM_ID"].ToString();
                        name = sqlDataReader["EM_NAME"].ToString();
                        this.Hide();
                        Home_Order home_Order = new Home_Order();
                        home_Order.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng nhập không chính xác", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    SQLConnection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Em_log_Click(object sender, EventArgs e)
        {
            //Admin_log.Visible = true;
            Admin.Visible = true;
            Em_log.Visible = false;
            BtnAdminLog.Visible = true;
            BtnStaffLog.Visible = false;
        }

        
        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            //Admin_log.Visible = false;
            Admin.Visible = false;
            Em_log.Visible = true;
            BtnAdminLog.Visible = false;
            BtnStaffLog.Visible = true;
        }
    }
}
