using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Supermarket.FrmRawInfo;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace Supermarket
{
    public partial class FrmBillInfo : Form
    {
        SQLConnection SQLConnection = new SQLConnection();
        public string b_id = "";
        public delegate void B_ID(string id);
        public B_ID b_ID;
        public FrmBillInfo()
        {
            InitializeComponent();
            b_ID = new B_ID(GetID);
        }
        private void GetID(string id)
        {
            b_id = id;
        }
        private void showdata()
        {
            try
            {
                SQLConnection = new SQLConnection();
                SQLConnection.OpenConnection();
                String str = "SELECT PRODUCT.PRO_ID, PRODUCT.PRO_NAME, BILLINFO.QUANTITY, BILLINFO.PRICE, BILLINFO.TOTAL FROM BILLINFO JOIN PRODUCT ON BILLINFO.PRO_ID = PRODUCT.PRO_ID WHERE B_ID ='" + b_id + "'";
                SqlCommand sqlCommand = new SqlCommand(str, SQLConnection.con);
                sqlCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(dt);
                dataGridView.DataSource = dt;
                SQLConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmBillInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billInfo.BILLINFO' table. You can move, or remove it, as needed.
            //this.bILLINFOTableAdapter.Fill(this.billInfo.BILLINFO);
            showdata();
        }

        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
