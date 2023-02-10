using Supermarket.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Supermarket.Usercontrol
{
    public partial class Bill : UserControl
    {
        ToolTip toolTips = new ToolTip();
        SQLConnection SQLConnection = new SQLConnection();
        public Bill()
        {
            InitializeComponent();
        }
        private void Bill_Load(object sender, EventArgs e)
        {
            showdata();
        }
        public void showdata()
        {
            id_name.Text = "";
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            String str = "SELECT B_ID, B_DATE, CUSTOMER.CUS_NAME, EMPLOYEE.EM_NAME, B_PRICE FROM BILL JOIN CUSTOMER ON BILL.CUS_ID = CUSTOMER.CUS_ID JOIN EMPLOYEE ON BILL.EM_ID = EMPLOYEE.EM_ID";
            SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
            sqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            SQLConnection.CloseConnection();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView.Rows[e.RowIndex];
                string id = Convert.ToString(row.Cells[0].Value);
                FrmBillInfo frm = new FrmBillInfo();
                frm.b_ID(id);
                frm.ShowDialog();
            }
            catch
            {
            }
        }

        private void id_name_TextChanged(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
            String.Format("B_ID like '%" + id_name.Text + "%' OR CUS_NAME like '%" + id_name.Text + "%' OR EM_NAME like '%" + id_name.Text + "%'");
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
                String checkbill = "Select * from bill where b_id = '" + id_name.Text + "'";
                CheckKey checkKey = new CheckKey();
                if (id_name.Text == "" || !checkKey.Check(checkbill))
                {
                    MessageBox.Show("Thông tin không đúng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection = new SQLConnection();
                    SQLConnection.OpenConnection();
                    String billinfo = "Delete From BILLINFO Where B_ID = '" + id_name.Text + "'";
                    String bill = "Delete From BILL Where B_ID = '" + id_name.Text + "'";
                    SqlCommand cmdb_info = new SqlCommand(billinfo, SQLConnection.con);
                    SqlCommand cmdbill = new SqlCommand(bill, SQLConnection.con);
                    cmdb_info.ExecuteNonQuery();
                    cmdbill.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa thông tin thành công");
                    showdata();
                    
                    SQLConnection.CloseConnection();
                }
            }
            catch 
            {
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Tìm kiếm tại đây", pictureBox1);
        }

        private void delete_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Xóa hóa đơn", delete);
        }

        private void reload_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Làm mới", reload);
        }
    }
}
