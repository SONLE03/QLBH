using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Supermarket
{
    public delegate void Reload();
    public partial class Products : UserControl
    {
        int index = 0;
        SQLConnection SQLConnection = new SQLConnection();
        public Products()
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
        private void _reload()
        {
            showdata("");
        }
        public void showdata(string text)
        {
            try
            {
                flowLayoutPanel.Controls.Clear();
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                String str = "Select PRO_ID, PRO_NAME, PRO_PRICE, PRO_IMAGE FROM PRODUCT WHERE PRO_NAME LIKE'" + id_name.Text + "%' order by PRO_NAME ";
                SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
                sqlCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(dt);
                UcItemProduct[] ucItemProducts = new UcItemProduct[Count(str)];
                foreach (DataRow dr in dt.Rows)
                {
                    ucItemProducts[index] = new UcItemProduct();
                    ucItemProducts[index].ID = dr["PRO_ID"].ToString();
                    ucItemProducts[index].ImageLocation = dr["PRO_IMAGE"].ToString();
                    ucItemProducts[index].Name = dr["PRO_NAME"].ToString();
                    ucItemProducts[index].Price = dr["PRO_PRICE"].ToString();
                    flowLayoutPanel.Controls.Add(ucItemProducts[index]);
                    ++index;
                }
                SQLConnection.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                index = 0;
            }
        }
        private void Products_Load(object sender, EventArgs e)
        {
            showdata("");
        }

        private void reload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata("");
        }

        private void change_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct(_reload);
            frmProduct.ShowDialog();
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
            toolTips.Show("Thêm hoặc sửa sản phẩm", change);
        }
    }
}
