namespace Supermarket
{
    partial class UcItemProduct
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.P_price = new Supermarket.CustomLabel();
            this.P_name = new Supermarket.CustomLabel();
            this.IDs = new Supermarket.CustomLabel();
            this.P_image = new System.Windows.Forms.PictureBox();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_image)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.P_price);
            this.customPanel1.Controls.Add(this.P_name);
            this.customPanel1.Controls.Add(this.IDs);
            this.customPanel1.Controls.Add(this.P_image);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 51F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.GradientTopColor = System.Drawing.Color.SkyBlue;
            this.customPanel1.Location = new System.Drawing.Point(-13, -11);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(224, 271);
            this.customPanel1.TabIndex = 4;
            this.customPanel1.Click += new System.EventHandler(this.UcItemProduct_Click);
            // 
            // P_price
            // 
            this.P_price.BorderRadius = 1;
            this.P_price.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.P_price.Color2 = System.Drawing.Color.SkyBlue;
            this.P_price.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_price.ForeColor = System.Drawing.Color.Black;
            this.P_price.GradientAngle = 359F;
            this.P_price.Location = new System.Drawing.Point(33, 220);
            this.P_price.Name = "P_price";
            this.P_price.Size = new System.Drawing.Size(167, 23);
            this.P_price.TabIndex = 4;
            this.P_price.Text = "GIÁ";
            // 
            // P_name
            // 
            this.P_name.BorderRadius = 1;
            this.P_name.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.P_name.Color2 = System.Drawing.Color.SkyBlue;
            this.P_name.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_name.ForeColor = System.Drawing.Color.Black;
            this.P_name.GradientAngle = 95F;
            this.P_name.Location = new System.Drawing.Point(33, 180);
            this.P_name.Name = "P_name";
            this.P_name.Size = new System.Drawing.Size(106, 23);
            this.P_name.TabIndex = 3;
            this.P_name.Text = "Tên Sản phẩm";
            // 
            // IDs
            // 
            this.IDs.BorderRadius = 1;
            this.IDs.Color1 = System.Drawing.Color.MediumSlateBlue;
            this.IDs.Color2 = System.Drawing.Color.SkyBlue;
            this.IDs.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDs.ForeColor = System.Drawing.Color.Black;
            this.IDs.GradientAngle = 337F;
            this.IDs.Location = new System.Drawing.Point(138, 180);
            this.IDs.Name = "IDs";
            this.IDs.Size = new System.Drawing.Size(62, 23);
            this.IDs.TabIndex = 0;
            this.IDs.Text = "ID";
            this.IDs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IDs.Visible = false;
            this.IDs.Click += new System.EventHandler(this.IDs_Click);
            // 
            // P_image
            // 
            this.P_image.BackColor = System.Drawing.Color.Transparent;
            this.P_image.Location = new System.Drawing.Point(33, 24);
            this.P_image.Name = "P_image";
            this.P_image.Size = new System.Drawing.Size(170, 141);
            this.P_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_image.TabIndex = 0;
            this.P_image.TabStop = false;
            // 
            // UcItemProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.customPanel1);
            this.Name = "UcItemProduct";
            this.Size = new System.Drawing.Size(211, 250);
            this.Load += new System.EventHandler(this.UcItemProduct_Load);
            this.Click += new System.EventHandler(this.UcItemProduct_Click);
            this.MouseEnter += new System.EventHandler(this.UcItemProduct_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UcItemProduct_MouseLeave);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.P_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox P_image;
        private CustomPanel.CustomPanel customPanel1;
        private CustomLabel IDs;
        private CustomLabel P_name;
        private CustomLabel P_price;
    }
}
