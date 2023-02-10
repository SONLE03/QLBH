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

namespace Supermarket
{
    public partial class Customers : UserControl
    {
        SQLConnection SQLConnection = new SQLConnection();
        public Customers()
        {
            InitializeComponent();
        }
        private void _reload()
        {
            showdata();
        }
        public void showdata()
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            String str = "SELECT * FROM CUSTOMER";
            SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
            sqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            SQLConnection.CloseConnection();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            showdata();
        }

        
        

        private void id_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("CUS_NAME like '%" + id_name.Text + "%' OR CUS_ID like '%" + id_name.Text + "%'");
            }
            catch
            {

            }
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
        
        ToolTip toolTips = new ToolTip();
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Tìm kiếm tại đây", pictureBox3);
        }

        private void delete_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Xóa khách hàng", PTBDel);
        }

        private void reload_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Làm mới", PTBChange);
        }

        private void change_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Thêm mới khách hàng", PTBChange);
        }

        private void PTBDel_Click(object sender, EventArgs e)
        {
            try
            {
                String check_cus = "Select * from customer where cus_id= '" + id_name.Text + "'";
                String check_bill = "Select * from bill, customer where bill.cus_id = customer.cus_id and customer.cus_id = '" + id_name.Text + "'";
                CheckKey checkKey = new CheckKey();
                if (id_name.Text == "" || !checkKey.Check(check_cus))
                {
                    MessageBox.Show("Thông tin không đúng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checkKey.Check(check_bill))
                {
                    MessageBox.Show("Khách hàng đã tồn tại trong hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection = new SQLConnection();
                    SQLConnection.OpenConnection();
                    String cus = "Delete From CUSTOMER Where CUS_ID = '" + id_name.Text + "'";
                    SqlCommand cmdcus = new SqlCommand(cus, SQLConnection.con);
                    cmdcus.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa thông tin thành công");
                    id_name.Clear();
                    showdata();
                    SQLConnection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PTBReload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata();
        }

        private void PTBChange_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer(_reload);
            frmCustomer.ShowDialog();
        }
    }
}
