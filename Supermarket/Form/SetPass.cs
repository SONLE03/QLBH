using Supermarket.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Supermarket
{
    public partial class SetPass : Form
    {
        SQLConnection conn = new SQLConnection();
        md5 md5 = new md5();
        public SetPass()
        {
            InitializeComponent();
        }
        private void Code_Click(object sender, EventArgs e)
        {
            Code.Clear();
        }

        private void N_Pass_Click(object sender, EventArgs e)
        {
            N_Pass.Clear(); 
        }

        private void CN_Pass_Click(object sender, EventArgs e)
        {
            CN_Pass.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Code.Text) == SendEmail.code)
                {
                    if (N_Pass.Text == CN_Pass.Text)
                    {
                        string query = "UPDATE EMPLOYEE SET EM_PASSWORD ='" + md5.MD5Hash(N_Pass.Text) + "' WHERE EM_USERNAME = '" + SendEmail.username + "'and EM_EMAIL='" + SendEmail.email + "'";
                        try
                        {
                            conn.OpenConnection();
                            SqlCommand sqlCommand = new SqlCommand(query, conn.con);
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Đã thay đổi mật khẩu");
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conn.CloseConnection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu xác nhận không chính xác", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mã xác nhận không chính xác", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
