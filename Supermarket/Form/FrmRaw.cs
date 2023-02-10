using Supermarket.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class FrmRaw : Form
    {
        public Reload reload;
        SQLConnection conn = new SQLConnection();
        int Quantity = 0;
        int grandTotal = 0;
        public FrmRaw()
        {
            InitializeComponent();
        }
        public FrmRaw(Reload _reload)
        {
            InitializeComponent();
            this.reload = _reload;
        }
        private void GetSupplier()
        {
            conn = new SQLConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select S_ID, S_NAME FROM SUPPLIER";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                provider.Items.Add(dr["S_ID"].ToString() + "|" + dr["S_NAME"].ToString());
            }
            conn.CloseConnection();
        }
        private void auto_id()
        {
            CheckKey checkKey = new CheckKey();
            Random rd = new Random();
            int id;
            string check;
            do
            {
                id = rd.Next(100000000, 1000000000);
                check = "Select * from RAW_MATERIAL where RAW_ID = '" + id.ToString() + "'";
            }
            while (checkKey.Check(check));
            this.id.Text = "PH" + id.ToString();
            //conn = new SQLConnection();
            //conn.OpenConnection();
            //SqlCommand sqlCommand = new SqlCommand("AUTORAWID", conn.con);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //object obj = sqlCommand.ExecuteScalar();
            //this.id.Text = obj.ToString();
            //conn.CloseConnection();
        }

        private void clear()
        {
            name.Clear();
            quantity.Clear();
            price.Clear();
            grandTotal = 0;
            Quantity = 0;
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Raw_Load(object sender, EventArgs e)
        {
            auto_id();
            GetSupplier();
        }

 
        private void addRawInfo()
        {
            try
            {
                conn = new SQLConnection();
                conn.OpenConnection();
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    string sql = "INSERT INTO RAWINFO(RI_ID,RAW_ID,RI_NAME,RI_QUANTITY,RI_PRICE,RI_TOTAL)VALUES (";
                    sql += "N'" + (i + 1) + "','" + id.Text + "',N'" + dataGridView.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView.Rows[i].Cells[3].Value.ToString() + "')";
                    SqlCommand sqlCommandRI = new SqlCommand(sql, conn.con);
                    sqlCommandRI.ExecuteNonQuery();
                }
                conn.CloseConnection();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void RprintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawString("HÓA ĐƠN NHẬP HÀNG HÀNG", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(300, 80));
                e.Graphics.DrawString("Mã phiếu hàng: " + id.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 150));
                e.Graphics.DrawString("Nhà cung cấp: " + Split(provider.Text,1), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 180));
                e.Graphics.DrawString("Ngày hóa đơn: " + DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 210));
                e.Graphics.DrawString("STT", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 310));
                e.Graphics.DrawString("Tên nguyên liệu", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(180, 310));
                e.Graphics.DrawString("Đơn giá", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, 310));
                e.Graphics.DrawString("Số lượng", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 310));
                e.Graphics.DrawString("Thành tiền", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 310));
                int x = 360;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    e.Graphics.DrawString((i + 1).ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, x));
                    e.Graphics.DrawString(dataGridView.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(180, x));
                    e.Graphics.DrawString(dataGridView.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, x));
                    e.Graphics.DrawString(dataGridView.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, x));
                    e.Graphics.DrawString(dataGridView.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, x));
                    x += 40;
                }
                e.Graphics.DrawString("Thành tiền:   " + grandTotal, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(520, x + 50));
            }
            catch
            {
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (id.Text == "" || name.Text == "" || provider.Text == "" || quantity.Text == "" || price.Text == "")
                {
                    MessageBox.Show("Chưa nhập đầy đủ thông tin", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool check = true;
                    int total = Convert.ToInt32(price.Text) * Convert.ToInt32(quantity.Text);
                    grandTotal += total;
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        var value = dataGridView.Rows[i].Cells[0].Value;
                        if (value.ToString() == name.Text)
                        {
                            dataGridView.Rows[i].Cells[1].Value = Convert.ToInt32(dataGridView.Rows[i].Cells[1].Value) + Convert.ToInt32(quantity.Text);
                            dataGridView.Rows[i].Cells[3].Value = Convert.ToInt32(dataGridView.Rows[i].Cells[3].Value) + total;
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        Quantity += 1;
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView);
                        row.Cells[0].Value = name.Text;
                        row.Cells[1].Value = quantity.Text;
                        row.Cells[2].Value = price.Text;
                        row.Cells[3].Value = total;
                        dataGridView.Rows.Add(row);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string Split(string s, int index)
        {
            String[] split = s.Split('|');
            return split[index];
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            try
            {
                conn = new SQLConnection();
                conn.OpenConnection();
                if (dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có sản phẩm nào trong phiếu nhập", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand("InsertRaw", conn.con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@RAW_ID", id.Text);
                    sqlCommand.Parameters.AddWithValue("@RAW_DATE", dateTime);
                    sqlCommand.Parameters.AddWithValue("@RAW_PROVIDER", Split(provider.Text,0));
                    sqlCommand.Parameters.AddWithValue("@RAW_QUANTITY", Quantity);
                    sqlCommand.Parameters.AddWithValue("@RAW_TOTAL", grandTotal);
                    sqlCommand.ExecuteNonQuery();
                    addRawInfo();
                    DialogResult _result = MessageBox.Show("Bạn muốn in hóa đơn ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_result == DialogResult.Yes)
                    {
                        RprintPreviewDialog.Document = RprintDocument;
                        RprintPreviewDialog.ShowDialog();
                    }
                    else
                    {

                        MessageBox.Show("Bạn đã thanh toán thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    clear();
                    auto_id();
                    dataGridView.Rows.Clear();

                }
                conn.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                int _Price;
                foreach (DataGridViewRow dataGridViewRow in dataGridView.Rows)
                {
                    if (dataGridViewRow.Cells[0].Value.ToString() == name.Text)
                    {
                        _Price = Convert.ToInt32(dataGridViewRow.Cells[2].Value);
                        dataGridView.Rows.Remove(dataGridViewRow);
                        grandTotal -= _Price;
                        Quantity -= 1;
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm trong phiếu hàng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.reload();
            Close();
        }
    }
}
