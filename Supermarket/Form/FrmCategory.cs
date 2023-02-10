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
    public partial class FrmCategory : Form
    {
        public Reload reload;
        SQLConnection SQLConnection = new SQLConnection();
        public FrmCategory()
        {
            InitializeComponent();
        }
        public FrmCategory(Reload _reload)
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
                check = "Select * from category where CAT_ID = '" + id.ToString() + "'";
            }
            while (checkKey.Check(check));
            this.id.Text = "LS" + id.ToString();
            //SQLConnection = new SQLConnection();
            //SQLConnection.OpenConnection();
            //SqlCommand sqlCommand = new SqlCommand("AUTOCATEID", SQLConnection.con);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //object obj = sqlCommand.ExecuteScalar();
            //this.id.Text = obj.ToString();
            //SQLConnection.CloseConnection();
        }
        private void clear()
        {
            id.Clear();
            name.Clear();
            description.Clear();
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

        
        private void search_id_Click(object sender, EventArgs e)
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            try
            {
                String str = "Select CAT_ID, CAT_NAME, CAT_DESCRIPTION From CATEGORY Where CAT_ID = '" + id.Text + "'";

                SqlCommand cmd = new SqlCommand(str, SQLConnection.con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id.Text = dr.GetValue(0).ToString();
                    name.Text = dr.GetValue(1).ToString();
                    description.Text = dr.GetValue(2).ToString();
                }
                else
                {
                    MessageBox.Show("Loại sản phẩm không tồn tại", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message); 
                } 
            finally
            {
                SQLConnection.CloseConnection();
            }           
        }

       

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            auto_id();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                String check_cate = "Select * from category where cat_id = '" + id.Text + "'";
                CheckKey checkKey = new CheckKey();
                if (id.Text == "" || name.Text == "")
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checkKey.Check(check_cate))
                {
                    String str = "Update CATEGORY Set CAT_NAME = N'" + name.Text + "',CAT_DESCRIPTION = N'" + description.Text + "' Where CAT_ID = '" + id.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, SQLConnection.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thông tin thành công");
                    clear();
                    auto_id();
                }
                else
                {
                    // string query = "INSERT INTO RAW_MATERIAL(RAW_ID, RAW_NAME, RAW_PROVIDER, RAW_QUANTITY, RAW_UNIT , RAW_PRICE, RAW_TOTAL) VALUES(@RAW_ID, @RAW_NAME, @RAW_PROVIDER, @RAW_QUANTITY, @RAW_UNIT , @RAW_PRICE, @RAW_TOTAL)";
                    SqlCommand sqlCommand = new SqlCommand("InsertCate", SQLConnection.con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@CAT_ID", id.Text);
                    sqlCommand.Parameters.AddWithValue("@CAT_NAME", name.Text);
                    sqlCommand.Parameters.AddWithValue("@CAT_DESCRIPTION", description.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
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
