using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class UcItemProduct : UserControl
    {
        public UcItemProduct()
        {
            InitializeComponent();
        }
        private string id;
        private string imageLocation;
        private string name;
        private string price;
        public string ID { get { return id; } set { id = value; IDs.Text = value; } }
        public string ImageLocation { get { return imageLocation; } set { imageLocation = value; P_image.ImageLocation = value; } }
        public string Name { get { return name; } set { name = value; P_name.Text = value; } }
        public string Price { get { return price; } set { price = value; P_price.Text = value; } }
        
        private void UcItemProduct_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void UcItemProduct_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UcItemProduct_Click(object sender, EventArgs e)
        {
            FrmProductDetail frmProductDetail = new FrmProductDetail();
            frmProductDetail.p_ID(id);
            frmProductDetail.ShowDialog();
        }

        private void UcItemProduct_Load(object sender, EventArgs e)
        {

        }

        private void IDs_Click(object sender, EventArgs e)
        {

        }
    }
}
