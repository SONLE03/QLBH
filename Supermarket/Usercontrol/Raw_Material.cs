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
    public partial class Raw_Material : UserControl
    {
        SQLConnection SQLConnection = new SQLConnection();
        public Raw_Material()
        {
            InitializeComponent();
        }
        private void _reload()
        {
            showdata();
        }
        private void Raw_Material_Load(object sender, EventArgs e)
        {
            showdata();
        }
        public void showdata()
        {
            id_name.Text = "";
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            String str = "SELECT RAW_ID, RAW_DATE, SUPPLIER.S_NAME, RAW_QUANTITY, RAW_TOTAL FROM RAW_MATERIAL JOIN SUPPLIER ON RAW_MATERIAL.RAW_PROVIDER = SUPPLIER.S_ID";
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
            FrmRaw raw = new FrmRaw(_reload);
            raw.ShowDialog();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            id_name.Clear();
            showdata();
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
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            try
            {
                String check_raw = "Select * from raw_material where raw_id = '" + id_name.Text + "'";
                CheckKey checkKey = new CheckKey();
                if (id_name.Text == "" || !checkKey.Check(check_raw))
                {
                    MessageBox.Show("Thông tin không đúng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String strR = "Delete From RAW_MATERIAL Where RAW_ID = '" + id_name.Text + "'";
                    SqlCommand cmdR = new SqlCommand(strR, SQLConnection.con);
                    String strRI = "Delete From RAWINFO Where RAW_ID = '" + id_name.Text + "'";
                    SqlCommand cmdRI = new SqlCommand(strR, SQLConnection.con);
                    try
                    {
                        cmdR.ExecuteNonQuery();
                        cmdRI.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa thông tin thành công");
                        showdata();

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
            finally
            {
                SQLConnection.CloseConnection();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView.Rows[e.RowIndex];
                string id = Convert.ToString(row.Cells[0].Value);
                FrmRawInfo frmRawInfo = new FrmRawInfo();
                frmRawInfo.r_ID(id);
                frmRawInfo.ShowDialog();
            }catch
            {
            }

        }

        private void id_name_TextChanged(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("S_NAME" +
                    " like '%" + id_name.Text + "%' OR RAW_ID like '%" + id_name.Text + "%'");
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
        ToolTip toolTips = new ToolTip();
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Tìm kiếm tại đây", pictureBox3);
        }

        private void delete_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Xóa phiếu hàng", delete);
        }

        private void reload_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Làm mới", reload);
        }

        private void change_MouseHover(object sender, EventArgs e)
        {
            toolTips.Show("Thêm phiếu hàng", change);
        }
    }
}
