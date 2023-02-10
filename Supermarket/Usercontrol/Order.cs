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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Supermarket
{
    public partial class Order : UserControl
    {
        DateTime dateTime = DateTime.Now;
        int grandTotal = 0;
        int total_amount = 0;
        SQLConnection conn;
        public Order()
        {

            InitializeComponent();
        }

        private string Split(string s, int index)
        {
            String[] split = s.Split('|');
            return split[index];
        }

        private void getEmployee()
        {
            Employee.Text = Login.id + "|" + Login.name;
        }
        private void getCustomer()
        {
            Customer.Items.Clear();
            conn = new SQLConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM CUSTOMER";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Customer.Items.Add(dr["CUS_ID"].ToString() + "|" + dr["CUS_NAME"].ToString());
            }
            conn.CloseConnection();
        }

        private void getProduct()
        {
            Product.Items.Clear();
            conn = new SQLConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM PRODUCT";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Product.Items.Add(dr["PRO_ID"].ToString() + "|" + dr["PRO_NAME"].ToString());
            }
            conn.CloseConnection();
        }
        private bool CheckQuantity()
        {
            int quantity = 10 ^ 9;
            int value = Convert.ToInt32(Quantity.Text); ;
            int i;
            conn = new SQLConnection();
            conn.OpenConnection();
            String str = "Select PRO_Quantity FROM PRODUCT WHERE PRO_ID = '" + Split(Product.Text, 0) + "'";
            SqlCommand cmd = new SqlCommand(str, conn.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                quantity = Convert.ToInt32(dr.GetValue(0).ToString());
            }
            for (i = 0; i < dataGridView_addOrder.Rows.Count; i++)
            {
                var id = dataGridView_addOrder.Rows[i].Cells[0].Value;
                if (id.ToString() == Split(Product.Text, 0))
                {
                    value = Convert.ToInt32(dataGridView_addOrder.Rows[i].Cells[3].Value) + Convert.ToInt32(Quantity.Text);
                    break;
                }
            }
            conn.CloseConnection();
            return (quantity >= value);
        }
        private void getPrice()
        {
            conn = new SQLConnection();
            conn.OpenConnection();
            String str = "Select PRO_Price FROM PRODUCT WHERE PRO_ID = '" + Split(Product.Text, 0) + "'";
            SqlCommand cmd = new SqlCommand(str, conn.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                price.Text = dr.GetValue(0).ToString();
            }
            conn.CloseConnection();
        }
        private void getDateTime()
        {
            DateTime dateTime = DateTime.Now;
            date.Text = dateTime.ToString("dd/MM/yyyy");
        }
        //private bool CheckKey(string sql)
        //{
        //    conn = new SQLConnection();
        //    conn.OpenConnection();
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn.con);
        //    DataTable table = new DataTable();
        //    sqlDataAdapter.Fill(table);
        //    if (table.Rows.Count > 0)
        //        return true;
        //    else return false;
        //} 

        private void auto_id()
        {
            CheckKey checkKey = new CheckKey();
            Random rd = new Random();
            int id;
            string check;
            do
            {
                id = rd.Next(100000000, 1000000000);
                check = "Select * from bill where B_ID = '" + id.ToString() + "'";
            }
            while (checkKey.Check(check));
            this.id.Text = "HD" + id.ToString();
            //conn = new SQLConnection();
            //conn.OpenConnection();
            //SqlCommand sqlCommand = new SqlCommand("AUTOBILLID", conn.con);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //object obj = sqlCommand.ExecuteScalar();
            //this.id.Text = obj.ToString();
            //conn.CloseConnection();
        }
        public void showdata()
        {
            getCustomer();
            getDateTime();
            getEmployee();
            getProduct();
        }
        public void Order_Load(object sender, EventArgs e)
        {
            getCustomer();
            getDateTime();
            getEmployee();
            getProduct();
            auto_id();
        }

        private void Product_SelectedValueChanged(object sender, EventArgs e)
        {
            getPrice();
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckQuantity())
                {
                    MessageBox.Show("Số lượng cần mua lớn hơn số lượng hiện có", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool check = true;
                    int total = Convert.ToInt32(price.Text) * Convert.ToInt32(Quantity.Text);
                    int amount = Convert.ToInt32(Quantity.Text);
                    total_amount += amount;
                    grandTotal += total;
                    for (int i = 0; i < dataGridView_addOrder.Rows.Count; i++)
                    {
                        var value = dataGridView_addOrder.Rows[i].Cells[0].Value;
                        if (value.ToString() == Split(Product.Text, 0))
                        {
                            dataGridView_addOrder.Rows[i].Cells[4].Value = Convert.ToInt32(dataGridView_addOrder.Rows[i].Cells[4].Value) + total;
                            dataGridView_addOrder.Rows[i].Cells[3].Value = Convert.ToInt32(dataGridView_addOrder.Rows[i].Cells[3].Value) + Convert.ToInt32(Quantity.Text);
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView_addOrder);
                        row.Cells[0].Value = Split(Product.Text, 0);
                        row.Cells[1].Value = Split(Product.Text, 1);
                        row.Cells[2].Value = price.Text;
                        row.Cells[3].Value = Quantity.Text;
                        row.Cells[4].Value = total;
                        dataGridView_addOrder.Rows.Add(row);
                    }
                    gTotal.Text = grandTotal + " VND";
                }  
            }
            catch
            {
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                int _Price;
                int _Amount;
                foreach (DataGridViewRow dataGridViewRow in dataGridView_addOrder.Rows)
                {
                    if (dataGridViewRow.Cells[0].Value.ToString() == Split(Product.Text, 0))
                    {
                        _Amount = Convert.ToInt32(dataGridViewRow.Cells[3].Value);
                        _Price = Convert.ToInt32(dataGridViewRow.Cells[4].Value);
                        dataGridView_addOrder.Rows.Remove(dataGridViewRow);
                        grandTotal -= _Price;
                        total_amount -= _Amount;
                        gTotal.Text = grandTotal + " VND";
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm trong hóa đơn", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
        }

        private void clear()
        {
            Customer.Text = "";
            price.Text = "";
            Quantity.Clear();
            Product.Text = "";
        }
        private void addProductToBillInfo()
        {
            conn = new SQLConnection();
            conn.OpenConnection();
            foreach (DataGridViewRow dataGridViewRow in dataGridView_addOrder.Rows)
            {
                string add = "INSERT INTO BILLINFO(B_ID, PRO_ID, QUANTITY, PRICE, TOTAL) VALUES(@B_ID, @PRO_ID, @QUANTITY, @PRICE, @TOTAL)";
                SqlCommand sqlCommand = new SqlCommand(add, conn.con);
                sqlCommand.Parameters.AddWithValue("@B_ID", id.Text);
                sqlCommand.Parameters.AddWithValue("@PRO_ID", dataGridViewRow.Cells[0].Value.ToString());
                sqlCommand.Parameters.AddWithValue("@QUANTITY", dataGridViewRow.Cells[3].Value.ToString());
                sqlCommand.Parameters.AddWithValue("@PRICE", dataGridViewRow.Cells[2].Value.ToString());
                sqlCommand.Parameters.AddWithValue("@TOTAL", dataGridViewRow.Cells[4].Value.ToString());
                sqlCommand.ExecuteNonQuery();
                string update_quantity = "UPDATE PRODUCT SET PRO_QUANTITY = PRO_QUANTITY-" + Convert.ToInt32(dataGridViewRow.Cells[3].Value) + " WHERE Pro_id ='" + dataGridViewRow.Cells[0].Value.ToString() + "'";
                SqlCommand quantity = new SqlCommand(update_quantity, conn.con);
                quantity.ExecuteNonQuery();
            }
            conn.CloseConnection();
        }
        private void print_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SQLConnection();
                conn.OpenConnection();
                if (dataGridView_addOrder.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có sản phẩm nào trong hóa đơn", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn muốn thanh toán ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string query = "set dateformat dmy INSERT INTO BILL(B_ID, B_DATE, CUS_ID, EM_ID, B_PRICE, TOTALAMOUNT) VALUES(@B_ID, @B_DATE, @CUS_ID, @EM_ID, @B_PRICE, @TOTALAMOUNT)";
                        SqlCommand sqlCommand = new SqlCommand(query, conn.con);
                        sqlCommand.Parameters.AddWithValue("@B_ID", id.Text);
                        sqlCommand.Parameters.AddWithValue("@B_DATE", date.Text);
                        sqlCommand.Parameters.AddWithValue("@CUS_ID", Split(Customer.Text, 0));
                        sqlCommand.Parameters.AddWithValue("@EM_ID", Split(Employee.Text, 0));
                        sqlCommand.Parameters.AddWithValue("@B_PRICE", grandTotal);
                        sqlCommand.Parameters.AddWithValue("@TOTALAMOUNT", total_amount);
                        sqlCommand.ExecuteNonQuery();
                        addProductToBillInfo();
                        DialogResult _result = MessageBox.Show("Bạn muốn in hóa đơn ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (_result == DialogResult.Yes)
                        {
                            BprintPreviewDialog.Document = BprintDocument;
                            BprintPreviewDialog.ShowDialog();
                        }
                        else
                        {

                            MessageBox.Show("Bạn đã thanh toán thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        clear();
                        auto_id();
                        dataGridView_addOrder.Rows.Clear();
                    }
                }
                conn.CloseConnection();
            }
            catch
            {
            }
        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void BprintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            try
            {
                conn = new SQLConnection();
                conn.OpenConnection();
                string CUS_ADDRESS = "", CUS_PHONE = "";
                string sql = "SELECT CUS_PHONE, CUS_ADDRESS FROM CUSTOMER WHERE CUS_ID = '" + Split(Customer.Text, 0) + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, conn.con);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.Read())
                {
                    CUS_PHONE = dr.GetValue(0).ToString();
                    CUS_ADDRESS = dr.GetValue(1).ToString();
                }
                e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(320, 80));
                e.Graphics.DrawString("Mã khách hàng: " + Split(Customer.Text, 0), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 150));
                e.Graphics.DrawString("Tên khách hàng: " + Split(Customer.Text, 1), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 180));
                // Thực hiện truy vấn tìm số điện thoại và địa chỉ
                e.Graphics.DrawString("Số điện thoại: " + CUS_PHONE.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 210));
                e.Graphics.DrawString("Địa chỉ: " + CUS_ADDRESS.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 240));
                e.Graphics.DrawString("Mã hóa đơn: " + id.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 150));
                e.Graphics.DrawString("Mã nhân viên: " + Split(Employee.Text, 0), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 180));
                e.Graphics.DrawString("Tên nhân viên: " + Split(Employee.Text, 1), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 210));
                e.Graphics.DrawString("Ngày hóa đơn: " + date.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 240));
                e.Graphics.DrawString("Mã sản phẩm", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 310));
                e.Graphics.DrawString("Tên sản phẩm", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(230, 310));
                e.Graphics.DrawString("Đơn giá", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, 310));
                e.Graphics.DrawString("Số lượng", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 310));
                e.Graphics.DrawString("Thành tiền", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 310));
                int x = 360;
                for (int i = 0; i < dataGridView_addOrder.Rows.Count; i++)
                {
                    e.Graphics.DrawString(dataGridView_addOrder.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, x));
                    e.Graphics.DrawString(dataGridView_addOrder.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(230, x));
                    e.Graphics.DrawString(dataGridView_addOrder.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, x));
                    e.Graphics.DrawString(dataGridView_addOrder.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, x));
                    e.Graphics.DrawString(dataGridView_addOrder.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, x));
                    x += 40;
                }
                e.Graphics.DrawString("Thành tiền:   " + gTotal.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(520, x + 50));
                conn.CloseConnection();
            }
            catch
            {
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
