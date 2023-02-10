using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.Usercontrol
{
    public partial class UcHome : UserControl
    {
        public UcHome()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            time.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
        public void Load()
        {
            timer.Enabled = true;
            timer.Start();
            date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            time.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
