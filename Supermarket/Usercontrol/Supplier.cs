using Supermarket.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Supermarket
{
    public partial class Supplier : UserControl
    {
        SQLConnection SQLConnection = new SQLConnection();
        public Supplier()
        {
            InitializeComponent();
        }
        public void showdata()
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            String str = "SELECT * FROM SUPPLIER";
            SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
            sqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            SQLConnection.CloseConnection();
        }

        private void change_Click(object sender, EventArgs e)
        {
            FrmSuppiler frmSuppiler = new FrmSuppiler(_reload);
            frmSuppiler.ShowDialog();
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

        private void Supplier_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void id_name_TextChanged(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("S_Name like '%" + id_name.Text + "%' OR S_ID like '%" + id_name.Text + "%'");
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
            String check_raw = "select * from raw_material, SUPPLIER where raw_material.RAW_PROVIDER = SUPPLIER.S_ID and supplier.S_ID = '" + id_name.Text + "'";
            CheckKey check = new CheckKey();
            
            try
            {
                if (id_name.Text == "")
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (check.Check(check_raw))
                {
                    MessageBox.Show("Nhà cung cấp đã có phiếu hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection = new SQLConnection();
                    SQLConnection.OpenConnection();
                    string str = "Delete from SUPPLIER where S_ID ='" + id_name.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa thông tin thành công");
                        showdata();
                        id_name.Clear();

                    }
                    catch
                    {

                    }
                    SQLConnection.CloseConnection();
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
            toolTips.Show("Xóa nhà cung cấp", delete);
        }

        private void reload_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Làm mới", reload);
        }

        private void change_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Thêm nhà cung cấp", change);
        }
    }
}
