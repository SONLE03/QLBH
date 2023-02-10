using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Dashboard : UserControl
    {
        private DBLogic model;
        private Button CurrentBtn;
        public Dashboard()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLastWeek.Select();
            model = new DBLogic();
            LoadData();
            DisableCustomDatesAndBtUI(btnLastWeek);
        }
        private void LoadData()
        {
            var Refresh = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (Refresh == true)
            {
                // 3 first panel
                lbNumofOrder.Text = model.NumOrder.ToString();
                lbTotalRevenues.Text = model.TotalRevenue.ToString() + " VND";
                lbTotalProfits.Text = model.TotalProfit.ToString();
                // 3 label at Total Counter
                lbNumCustomer.Text = model.NumCustomer.ToString();
                lbNumSupplier.Text = model.NumSupplier.ToString();
                lbProductQuantity.Text = model.NumProduct.ToString();
                //Area chart of Revenue
                chartTotalRevenue.DataSource = model.TotalRevenues;
                chartTotalRevenue.Series[0].XValueMember = "Date";
                chartTotalRevenue.Series[0].YValueMembers = "TotalAmount";
                chartTotalRevenue.DataBind();
                //Area chart of Cost
                chartTotalCost.DataSource = model.TotalCosts;
                chartTotalCost.Series[0].XValueMember = "Date";
                chartTotalCost.Series[0].YValueMembers = "TotalAmount";
                chartTotalCost.DataBind();
                //Dounut chart of Top 5 best selling
                chartTop5.DataSource = model.TopProduct;
                chartTop5.Series[0].XValueMember = "Key";
                chartTop5.Series[0].YValueMembers = "Value";
                chartTop5.DataBind();
                //Datagridview of Stock
                dgvStock.DataSource = model.Stock;
                dgvStock.Columns[0].Width = 200;
                dgvStock.Columns[1].Width = 110;
                dgvStock.Columns[0].HeaderText = "Tên món";
                dgvStock.Columns[1].HeaderText = "Số lượng";

                chartTotalCost.Visible = false;
                Revenue.Visible = false;
                Cost.Visible = true;
                Console.WriteLine("Loaded!!!");
            }
            else Console.WriteLine("Fail to load!!!");

        }

        private void DisableCustomDatesAndBtUI(object button)
        {
            var btn = (Button)button;
            btn.BackColor = btnLastMonth.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            if (CurrentBtn != null && CurrentBtn != btn)
            {
                CurrentBtn.BackColor = this.BackColor;
                CurrentBtn.ForeColor = Color.FromArgb(124, 141, 181);
            }
            CurrentBtn = btn;

            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOk.Visible = false;
        }


        //All Events of Elements
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            Cost.Visible = true;
            DisableCustomDatesAndBtUI(sender);
        }

        private void btnLastWeek_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            Cost.Visible = true;
            DisableCustomDatesAndBtUI(sender);
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            Cost.Visible = true;
            DisableCustomDatesAndBtUI(sender);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            Cost.Visible = true;
            DisableCustomDatesAndBtUI(sender);
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            EnableCustomDatesAndBtUI(sender);
        }

        private void EnableCustomDatesAndBtUI(object button)
        {
            var btn = (Button)button;
            btn.BackColor = btnLastMonth.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            if (CurrentBtn != null && CurrentBtn != btn)
            {
                CurrentBtn.BackColor = this.BackColor;
                CurrentBtn.ForeColor = Color.FromArgb(124, 141, 181);
            }
            CurrentBtn = btn;

            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOk.Visible = true;
            lbStartDate.Cursor = Cursors.Hand;
            lbEndDate.Cursor = Cursors.Hand;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LoadData();
            Cost.Visible = true;
        }


        private void lbStartDate_Click(object sender, EventArgs e)
        {
            if (CurrentBtn == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
            else
            {
                MessageBox.Show("Chỉ được chọn ngày sau khi bấm [Tùy chỉnh] !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    

        private void lbEndDate_Click(object sender, EventArgs e)
        {
            if (CurrentBtn == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
            else
            {
                MessageBox.Show("Chỉ được chọn ngày sau khi bấm [Tùy chỉnh] !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lbStartDate.Text = dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lbEndDate.Text = dtpEndDate.Text;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbStartDate.Text = dtpStartDate.Text;
            lbEndDate.Text = dtpEndDate.Text;
        }

        private void BtnCost_Click(object sender, EventArgs e)
        {
            Revenue.Visible = true;
            chartTotalCost.Visible = true;
            Cost.Visible = false;
        }

        private void BtnRevenue_Click(object sender, EventArgs e)
        {
            chartTotalCost.Visible = false;
            Cost.Visible = true;
            Revenue.Visible = false;
        }

        public void reload()
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            lbStartDate.Text = dtpStartDate.Text;
            lbEndDate.Text = dtpEndDate.Text;
            LoadData();
        }
    }   
}
