using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Image = System.Drawing.Image;
using Supermarket.Class;

namespace Supermarket
{
    public partial class FrmProduct : Form
    {
        public Reload reload;
        static string imageLocation = "";
        SQLConnection conn = new SQLConnection();
        CheckKey CheckKey = new CheckKey();
        public FrmProduct()
        {
            InitializeComponent();
        }
        public FrmProduct(Reload _reload)
        {
            InitializeComponent();
            this.reload = _reload;
        }
        private void GetCategory()
        {
            conn = new SQLConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select CAT_NAME FROM CATEGORY";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                type.Items.Add(dr["CAT_NAME"].ToString());
            }

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
                check = "Select * from product where PRO_ID = '" + id.ToString() + "'";
            }
            while (checkKey.Check(check));
            this.id.Text = "SP" + id.ToString();
            //conn = new SQLConnection();
            //conn.OpenConnection();
            //SqlCommand sqlCommand = new SqlCommand("AUTOPROID", conn.con);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //object obj = sqlCommand.ExecuteScalar();
            //this.id.Text = obj.ToString();
            //conn.CloseConnection();
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            GetCategory();
            auto_id();
        }
       
        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void clear()
        {
            id.Clear();
            name.Clear();
            price.Clear();
            quantity.Clear();
            description.Clear();
            pictureBox1.Image = null;
            type.Text = "";
        }
        private string getCategory_ID(string type)
        {
            string Cat_ID = "";
            conn = new SQLConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select CAT_ID FROM CATEGORY WHERE CAT_NAME = '" + type + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Cat_ID = dr["CAT_ID"].ToString();
            }
            conn.CloseConnection();
            return Cat_ID;
        }
        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConnection();

                String str = "Select *  FROM PRODUCT JOIN CATEGORY ON PRODUCT.CAT_ID = CATEGORY.CAT_ID Where PRO_ID = '" + id.Text + "'";

                SqlCommand cmd = new SqlCommand(str, conn.con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id.Text = dr.GetValue(0).ToString();
                    name.Text = dr.GetValue(1).ToString();
                    quantity.Text = dr.GetValue(2).ToString();
                    price.Text = dr.GetValue(3).ToString();
                    description.Text = dr.GetValue(4).ToString();
                    type.Text = dr.GetValue(8).ToString();
                    imageLocation = dr.GetValue(6).ToString();
                   
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pictureBox1.ImageLocation = imageLocation;
                conn.CloseConnection();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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



        private void add_I_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnection conn = new SQLConnection();
                conn.OpenConnection();
                String check_pro = "Select * from product where pro_id = '" + id.Text + "'";
                if (id.Text == "" || name.Text == "" || quantity.Text == "" || price.Text == "" || description.Text == "" || type.Text == "")
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CheckKey.Check(check_pro))
                {
                    String str = "Update PRODUCT Set PRO_NAME = N'" + name.Text + "',PRO_DESCRIPTION = N'" + description.Text + "',PRO_QUANTITY = '" + quantity.Text + "',PRO_PRICE = '" + price.Text + "',CAT_ID = '" + getCategory_ID(type.Text) + "', PRO_IMAGE = '" + imageLocation + "' Where PRO_ID = '" + id.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, conn.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thay đổi thông tin thành công");
                    clear();
                    auto_id();
                }
                else
                {
                    Image image = pictureBox1.Image;
                    string cat_id = getCategory_ID(type.Text);
                    // string query = "INSERT INTO RAW_MATERIAL(RAW_ID, RAW_NAME, RAW_PROVIDER, RAW_QUANTITY, RAW_UNIT , RAW_PRICE, RAW_TOTAL) VALUES(@RAW_ID, @RAW_NAME, @RAW_PROVIDER, @RAW_QUANTITY, @RAW_UNIT , @RAW_PRICE, @RAW_TOTAL)";
                    SqlCommand sqlCommand = new SqlCommand("InsertPro", conn.con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@PRO_ID", id.Text);
                    sqlCommand.Parameters.AddWithValue("@PRO_NAME", name.Text);
                    sqlCommand.Parameters.AddWithValue("@PRO_QUANTITY", quantity.Text);
                    sqlCommand.Parameters.AddWithValue("@PRO_PRICE", price.Text);
                    sqlCommand.Parameters.AddWithValue("@PRO_DESCRIPTION", description.Text);
                    sqlCommand.Parameters.AddWithValue("@CAT_ID", cat_id);
                    sqlCommand.Parameters.AddWithValue("@PRO_IMAGE", imageLocation);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm sản phẩm thành công");
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
                conn.CloseConnection();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String check_billinfo = "Select * from billinfo, product where billinfo.PRO_ID = product.PRO_ID and product.PRO_ID = '" + id.Text + "'";
                if (id.Text == "" || name.Text == "" || quantity.Text == "" || price.Text == "" || description.Text == "" || type.Text == "")
                {
                    MessageBox.Show("Thông tin không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CheckKey.Check(check_billinfo))
                {
                    MessageBox.Show("Sản phẩm đã tồn tại trong hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conn = new SQLConnection();
                    conn.OpenConnection();
                    String str = "Delete From PRODUCT Where PRO_ID = '" + id.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, conn.con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa thông tin thành công");
                        clear();
                        auto_id();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conn.CloseConnection();
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
