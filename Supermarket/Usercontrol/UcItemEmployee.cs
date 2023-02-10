using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Supermarket
{
    public partial class UcItemEmployee : UserControl
    {
        public UcItemEmployee()
        {
            InitializeComponent();
        }
        private string id;
        private string imageLocation;
        private string name;
        private string phone;
        private string position;
        public string ID { get { return id; } set { id = value; Ids.Text = value; } }
        public string ImageLocation { get { return imageLocation; } set { imageLocation = value; P_image.ImageLocation = value; } }
        public string Name { get { return name; } set { name = value; E_name.Text = value; } }
        public string Phone { get { return phone; } set { phone = value; E_phone.Text = value; } }
        public string Position { get { return position; } set { position = value; E_position.Text = value; } }

        private void UcItemEmployee_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void UcItemEmployee_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UcItemEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployeeDetail frmEmployeeDetail = new FrmEmployeeDetail();
            frmEmployeeDetail.e_ID(id);
            frmEmployeeDetail.ShowDialog();
        }

        private void UcItemEmployee_Load(object sender, EventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void E_name_Click(object sender, EventArgs e)
        {

        }

        private void P_image_Click(object sender, EventArgs e)
        {

        }

        private void customLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
