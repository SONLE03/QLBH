using CustomPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Home : Form
    {
        private CustomButton CurrentBtn;
        public Home()
        {
            InitializeComponent();
            dashboard.Select();
        }

        private void BtUI(object button)
        {
            var btn = (CustomButton)button;
            btn.BackColor = Color.MediumSlateBlue;
            btn.ForeColor = Color.White;

            if (CurrentBtn != null && CurrentBtn != btn)
            {
                CurrentBtn.BackColor = Color.Transparent;
                CurrentBtn.ForeColor = Color.White;
            }
            CurrentBtn = btn;

            
        }

        //BtUI(Sender)
        private void dashboard_Click(object sender, EventArgs e)
        {
            control_panel.Top = pictureBox2.Top;
            control_panel.Height = pictureBox2.Height;
            dashboard2.reload();
            dashboard2.BringToFront();
            customPanel3.GradientTopColor = Color.LavenderBlush;
            customPanel3.GradientBottomColor = Color.SkyBlue;
            BtUI(sender);
            
        }

        private void product_Click(object sender, EventArgs e)
        {
            control_panel.Top = pictureBox3.Top;
            control_panel.Height = pictureBox3.Height;
            products1.showdata("");
            products1.BringToFront();
            customPanel3.GradientTopColor = Color.LavenderBlush;
            customPanel3.GradientBottomColor = Color.SkyBlue;

        }

        private void product_type_Click(object sender, EventArgs e)
        {
            control_panel.Top = pictureBox4.Top;
            control_panel.Height = pictureBox4.Height;
            categories1.showdata();
            categories1.BringToFront();
            customPanel3.GradientTopColor = Color.LavenderBlush;
            customPanel3.GradientBottomColor = Color.SkyBlue;

        }

        private void employee_Click(object sender, EventArgs e)
        {
            control_panel.Top = pictureBox5.Top;
            control_panel.Height = pictureBox5.Height;
            sellers1.showdata("");
            sellers1.BringToFront();
            customPanel3.GradientTopColor = Color.LavenderBlush;
            customPanel3.GradientBottomColor = Color.SkyBlue;

        }

        private void bill_Click(object sender, EventArgs e)
        {
            control_panel.Top = pictureBox6.Top;
            control_panel.Height = pictureBox6.Height;
            bill1.showdata();
            bill1.BringToFront();
            customPanel3.GradientTopColor = Color.LavenderBlush;
            customPanel3.GradientBottomColor = Color.SkyBlue;
        }

        private void raw_Click(object sender, EventArgs e)
        {
            control_panel.Top = pictureBox9.Top;
            control_panel.Height = pictureBox9.Height;
            raw_Material2.showdata();
            raw_Material2.BringToFront();
            customPanel3.GradientTopColor = Color.LavenderBlush;
            customPanel3.GradientBottomColor = Color.SkyBlue;

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void raw_Material1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            dashboard2.BringToFront();
            ucHome1.Load();
            ucHome1.BringToFront();
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            control_panel.Top = pictureBox10.Top;
            control_panel.Height = pictureBox10.Height;
            supplier1.showdata();
            supplier1.BringToFront();
            customPanel3.GradientTopColor = Color.LavenderBlush;
            customPanel3.GradientBottomColor = Color.SkyBlue;

        }

        private void customer_Click(object sender, EventArgs e)
        {
            control_panel.Top = pictureBox7.Top;
            control_panel.Height = pictureBox7.Height;
            customers1.showdata();
            customers1.BringToFront();
            customPanel3.GradientTopColor = Color.LavenderBlush;
            customPanel3.GradientBottomColor = Color.SkyBlue;

        }

        private void setting_Click(object sender, EventArgs e)
        {
            control_panel.Top = pictureBox11.Top;
            control_panel.Height = pictureBox11.Height;
            setting_Employee1.showdata();
            setting_Employee1.BringToFront();
            customPanel3.GradientTopColor = Color.LavenderBlush;
            customPanel3.GradientBottomColor = Color.SkyBlue;

        }

        private void Pic_Home_Click(object sender, EventArgs e)
        {
            ucHome1.Load();
            ucHome1.BringToFront();
            customPanel3.GradientBottomColor = Color.SkyBlue;
            customPanel3.GradientTopColor = Color.Violet;
        }

        private void customPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
