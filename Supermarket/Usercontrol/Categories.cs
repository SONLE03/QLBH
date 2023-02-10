using Supermarket.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Supermarket
{
    public partial class Categories : UserControl
    {
        SQLConnection SQLConnection = new SQLConnection();
        public Categories()
        {
            InitializeComponent();
        }
        public void showdata()
        {
            id_name.Text = "";
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            String str = "SELECT * FROM CATEGORY";
            SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
            sqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            SQLConnection.CloseConnection();
        }
        
        private void Categories_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void change_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory(_reload);
            frmCategory.ShowDialog();
        }
        private void _reload()
        {
            showdata();
        }
        private void reload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata();
        }

        private void id_name_TextChanged(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
            String.Format("CAT_ID like '%" + id_name.Text + "%' OR CAT_NAME like '%" + id_name.Text + "%'");
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_name.Text = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[0].Value);
            }
            catch
            {

            }
            
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

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                String checkcat = "Select * from category where cat_id = '" + id_name.Text + "'";
                String checkpro = "Select * from category, product where category.cat_id = product.cat_id and category.cat_id = '" + id_name.Text + "'";
                CheckKey checkKey = new CheckKey();
                if (id_name.Text == "" || !checkKey.Check(checkcat))
                {
                    MessageBox.Show("Thông tin không đúng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checkKey.Check(checkpro))
                {
                    MessageBox.Show("Loại sản phẩm có tồn tại sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String cat = "Delete From CATEGORY Where CAT_ID = '" + id_name.Text + "'";
                    SqlCommand cmd = new SqlCommand(cat, SQLConnection.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa thông tin thành công");
                    showdata();
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
        ToolTip toolTips = new ToolTip();
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Tìm kiếm tại đây", pictureBox3);
        }

        private void delete_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Xóa loại sản phẩm", delete);
        }

        private void reload_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Làm mới", reload);
        }

        private void change_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Thêm hoặc sửa loại sản phẩm", change);
        }

        private void customPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
