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
    public partial class FrmRawInfo : Form
    {
        SQLConnection SQLConnection = new SQLConnection();
        public string r_id = "";
        public delegate void R_ID(string id);
        public R_ID r_ID;
        public FrmRawInfo()
        {
            InitializeComponent();
            r_ID = new R_ID(GetID);
        }
        private void GetID(string id)
        {
            r_id = id;
        }
        private void showdata()
        {
            try
            {
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                String str = "SELECT RI_ID , RI_NAME, RI_QUANTITY, RI_PRICE, RI_TOTAL FROM RAWINFO WHERE RAW_ID ='" + r_id + "'";
                SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
                sqlCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(dt);
                dataGridView.DataSource = dt;
                SQLConnection.CloseConnection();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void FrmRawInfo_Load(object sender, EventArgs e)
        {
            showdata();
        }

        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
