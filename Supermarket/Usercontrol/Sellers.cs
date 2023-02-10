using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Sellers : UserControl
    {
        int index = 0;
        SQLConnection SQLConnection = new SQLConnection();
        public Sellers()
        {
            InitializeComponent();
        }

        private int Count(string sql)
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, SQLConnection.con);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            return table.Rows.Count;
        }
        private void Sellers_Load(object sender, EventArgs e)
        {
            showdata("");
        }
        public void showdata(string text)
        {
            try
            {
                id_name.Text = text;
                flowLayoutPanel.Controls.Clear();
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                String str = "Select EM_ID, EM_NAME, EM_PHONE, EM_POSITION, EM_IMAGE FROM EMPLOYEE WHERE EM_ID != '" + Login.id + "' AND EM_NAME LIKE'" + id_name.Text + "%' order by EM_NAME ";
                SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
                sqlCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(dt);
                UcItemEmployee[] ucItemEmployees = new UcItemEmployee[Count(str)];
                foreach (DataRow dr in dt.Rows)
                {
                    ucItemEmployees[index] = new UcItemEmployee();
                    ucItemEmployees[index].ID = dr["EM_ID"].ToString();
                    ucItemEmployees[index].ImageLocation = dr["EM_IMAGE"].ToString();
                    ucItemEmployees[index].Name = dr["EM_NAME"].ToString();
                    ucItemEmployees[index].Phone = dr["EM_PHONE"].ToString();
                    string position = dr["EM_POSITION"].ToString();
                    if (position == "QTV")
                    {
                        ucItemEmployees[index].Position = "Quản lý";
                    }
                    else
                    {
                        ucItemEmployees[index].Position = "Thu ngân";
                    }
                    flowLayoutPanel.Controls.Add(ucItemEmployees[index]);
                    ++index;
                }
                SQLConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                index = 0;
            }
        }
        private void _reload()
        {
            showdata("");
        }
        private void change_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller(_reload);
            seller.ShowDialog();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata("");
        }

        private void id_name_TextChanged(object sender, EventArgs e)
        {
            showdata(id_name.Text);
        }
        ToolTip toolTips = new ToolTip();
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Tìm kiếm tại đây", pictureBox1);
        }

       
        private void reload_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Làm mới", reload);
        }

        private void change_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Thêm nhân viên", change);
        }
    }
}
