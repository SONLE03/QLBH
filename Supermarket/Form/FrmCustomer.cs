using Supermarket.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class FrmCustomer : Form
    {
        public Reload reload;
        SQLConnection SQLConnection = new SQLConnection();
        public FrmCustomer()
        {
            InitializeComponent();
        }
        public FrmCustomer(Reload _reload)
        {
            InitializeComponent();
            this.reload = _reload;
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
                check = "Select * from customer where CUS_ID = '" + id.ToString() + "'";
            }
            while (checkKey.Check(check));
            this.id.Text = "KH" + id.ToString();
            //SQLConnection = new SQLConnection();
            //SQLConnection.OpenConnection();
            //SqlCommand sqlCommand = new SqlCommand("AUTOCUSID", SQLConnection.con);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //object obj = sqlCommand.ExecuteScalar();
            //this.id.Text = obj.ToString();
            //SQLConnection.CloseConnection();
        }
        private void clear()
        {
            id.Clear();
            name.Clear();
            phone.Clear();
            address.Clear();
        }


        private void search_id_Click(object sender, EventArgs e)
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            try
            {
                String str = "Select CUS_ID, CUS_NAME, CUS_PHONE, CUS_ADDRESS From CUSTOMER Where CUS_ID = '" + id.Text + "'";

                SqlCommand cmd = new SqlCommand(str, SQLConnection.con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id.Text = dr.GetValue(0).ToString();
                    name.Text = dr.GetValue(1).ToString();
                    phone.Text = dr.GetValue(2).ToString();
                    address.Text = dr.GetValue(3).ToString();
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        

       
        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            auto_id();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                String check_cus = "Select * from customer where cus_id = '" + id.Text + "'";
                CheckKey check = new CheckKey();
                if (phone.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không đúng", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (id.Text == "" || name.Text == "" || phone.Text == "" || address.Text == "")
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (check.Check(check_cus))
                {
                    String str = "Update CUSTOMER Set CUS_NAME = N'" + name.Text + "',CUS_ADDRESS = N'" + address.Text + "',CUS_PHONE = '" + phone.Text + "' Where CUS_ID = '" + id.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, SQLConnection.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thay đổi thông tin thành công");
                    clear();
                    auto_id();
                }
                else
                {

                    // string query = "INSERT INTO RAW_MATERIAL(RAW_ID, RAW_NAME, RAW_PROVIDER, RAW_QUANTITY, RAW_UNIT , RAW_PRICE, RAW_TOTAL) VALUES(@RAW_ID, @RAW_NAME, @RAW_PROVIDER, @RAW_QUANTITY, @RAW_UNIT , @RAW_PRICE, @RAW_TOTAL)";
                    SqlCommand sqlCommand = new SqlCommand("InsertCus", SQLConnection.con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@CUS_ID", id.Text);
                    sqlCommand.Parameters.AddWithValue("@CUS_NAME", name.Text);
                    sqlCommand.Parameters.AddWithValue("@CUS_PHONE", phone.Text);
                    sqlCommand.Parameters.AddWithValue("@CUS_ADDRESS", address.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm khách hàng thành công");
                    clear();
                    auto_id();
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.reload();
            Close();
        }
    }
}
