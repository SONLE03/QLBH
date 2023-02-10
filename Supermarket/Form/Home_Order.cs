using CustomPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Home_Order : Form
    {
        public Home_Order()
        {
            InitializeComponent();
        }
        private void Home_Order_Load(object sender, EventArgs e)
        {
            ucHome1.Load();
            ucHome1.BringToFront();
        }
        private void order_Click(object sender, EventArgs e)
        {
            control_panel.Top = order.Top;
            control_panel.Height = order.Height;
            order1.showdata();
            order1.BringToFront();
            customPanel7.GradientBottomColor = Color.LavenderBlush;
            customPanel7.GradientTopColor = Color.SkyBlue;
        }

        private void product_Click(object sender, EventArgs e)
        {
            control_panel.Top = product.Top;
            control_panel.Height = product.Height;
            products1.showdata("");
            products1.BringToFront();
            customPanel7.GradientBottomColor = Color.LavenderBlush;
            customPanel7.GradientTopColor = Color.SkyBlue;
        }

        private void product_type_Click(object sender, EventArgs e)
        {
            control_panel.Top = product_type.Top;
            control_panel.Height = product_type.Height;
            categories1.showdata();
            categories1.BringToFront();
            customPanel7.GradientBottomColor = Color.LavenderBlush;
            customPanel7.GradientTopColor = Color.SkyBlue;
        }

        private void bill_Click(object sender, EventArgs e)
        {
            control_panel.Top = bill.Top;
            control_panel.Height = bill.Height;
            bill1.showdata();

            bill1.BringToFront();
            customPanel7.GradientBottomColor = Color.LavenderBlush;
            customPanel7.GradientTopColor = Color.SkyBlue;
        }

        private void customer_Click(object sender, EventArgs e)
        {
            control_panel.Top = customer.Top;
            control_panel.Height = customer.Height;
            customers1.showdata();
            customers1.BringToFront();
            customPanel7.GradientBottomColor = Color.LavenderBlush;
            customPanel7.GradientTopColor = Color.SkyBlue;
        }

        private void setting_Click(object sender, EventArgs e)
        {
            control_panel.Top = setting.Top;
            control_panel.Height = setting.Height;
            setting_Employee1.showdata();
            setting_Employee1.BringToFront();
            customPanel7.GradientBottomColor = Color.LavenderBlush;
            customPanel7.GradientTopColor = Color.SkyBlue;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Pic_Home_Click(object sender, EventArgs e)
        {
            ucHome1.Load();
            ucHome1.BringToFront();
            customPanel7.GradientBottomColor = Color.Violet;
            customPanel7.GradientTopColor = Color.SkyBlue;
        }
    }
}
