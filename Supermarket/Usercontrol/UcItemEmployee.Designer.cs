namespace Supermarket
{
    partial class UcItemEmployee
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
            this.E_position = new Supermarket.CustomLabel();
            this.E_phone = new Supermarket.CustomLabel();
            this.Ids = new Supermarket.CustomLabel();
            this.customLabel3 = new Supermarket.CustomLabel();
            this.customLabel2 = new Supermarket.CustomLabel();
            this.E_name = new Supermarket.CustomLabel();
            this.P_image = new System.Windows.Forms.PictureBox();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_image)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.E_position);
            this.customPanel1.Controls.Add(this.E_phone);
            this.customPanel1.Controls.Add(this.Ids);
            this.customPanel1.Controls.Add(this.customLabel3);
            this.customPanel1.Controls.Add(this.customLabel2);
            this.customPanel1.Controls.Add(this.E_name);
            this.customPanel1.Controls.Add(this.P_image);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 17F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.Plum;
            this.customPanel1.Location = new System.Drawing.Point(-8, -5);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(581, 132);
            this.customPanel1.TabIndex = 10;
            this.customPanel1.Click += new System.EventHandler(this.UcItemEmployee_Click);
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // E_position
            // 
            this.E_position.AutoSize = true;
            this.E_position.BorderRadius = 1;
            this.E_position.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.E_position.Color2 = System.Drawing.Color.Plum;
            this.E_position.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_position.GradientAngle = 210F;
            this.E_position.Location = new System.Drawing.Point(313, 90);
            this.E_position.Name = "E_position";
            this.E_position.Size = new System.Drawing.Size(74, 23);
            this.E_position.TabIndex = 12;
            this.E_position.Text = "Chức vụ";
            // 
            // E_phone
            // 
            this.E_phone.AutoSize = true;
            this.E_phone.BorderRadius = 1;
            this.E_phone.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.E_phone.Color2 = System.Drawing.Color.Plum;
            this.E_phone.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.E_phone.GradientAngle = 34F;
            this.E_phone.Location = new System.Drawing.Point(313, 56);
            this.E_phone.Name = "E_phone";
            this.E_phone.Size = new System.Drawing.Size(40, 23);
            this.E_phone.TabIndex = 12;
            this.E_phone.Text = "SĐT";
            // 
            // Ids
            // 
            this.Ids.AutoSize = true;
            this.Ids.BorderRadius = 1;
            this.Ids.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Ids.Color2 = System.Drawing.Color.Plum;
            this.Ids.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Ids.GradientAngle = 174F;
            this.Ids.Location = new System.Drawing.Point(314, 22);
            this.Ids.Name = "Ids";
            this.Ids.Size = new System.Drawing.Size(27, 23);
            this.Ids.TabIndex = 12;
            this.Ids.Text = "ID";
            this.Ids.Visible = false;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.BorderRadius = 1;
            this.customLabel3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customLabel3.Color2 = System.Drawing.Color.Plum;
            this.customLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel3.GradientAngle = 16F;
            this.customLabel3.Location = new System.Drawing.Point(146, 91);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(83, 23);
            this.customLabel3.TabIndex = 12;
            this.customLabel3.Text = "Chức vụ :";
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.BorderRadius = 1;
            this.customLabel2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customLabel2.Color2 = System.Drawing.Color.Plum;
            this.customLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel2.GradientAngle = 103F;
            this.customLabel2.Location = new System.Drawing.Point(146, 56);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(122, 23);
            this.customLabel2.TabIndex = 12;
            this.customLabel2.Text = "Số Điện thoại :";
            this.customLabel2.Click += new System.EventHandler(this.customLabel2_Click);
            // 
            // E_name
            // 
            this.E_name.AutoSize = true;
            this.E_name.BorderRadius = 1;
            this.E_name.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.E_name.Color2 = System.Drawing.Color.Plum;
            this.E_name.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.E_name.GradientAngle = 187F;
            this.E_name.Location = new System.Drawing.Point(146, 21);
            this.E_name.Name = "E_name";
            this.E_name.Size = new System.Drawing.Size(120, 23);
            this.E_name.TabIndex = 11;
            this.E_name.Text = "Tên Nhân viên";
            this.E_name.Click += new System.EventHandler(this.E_name_Click);
            // 
            // P_image
            // 
            this.P_image.BackColor = System.Drawing.Color.Transparent;
            this.P_image.Location = new System.Drawing.Point(26, 20);
            this.P_image.Name = "P_image";
            this.P_image.Size = new System.Drawing.Size(104, 96);
            this.P_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_image.TabIndex = 1;
            this.P_image.TabStop = false;
            this.P_image.Click += new System.EventHandler(this.P_image_Click);
            // 
            // UcItemEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.customPanel1);
            this.Name = "UcItemEmployee";
            this.Size = new System.Drawing.Size(555, 128);
            this.Load += new System.EventHandler(this.UcItemEmployee_Load);
            this.Click += new System.EventHandler(this.UcItemEmployee_Click);
            this.MouseEnter += new System.EventHandler(this.UcItemEmployee_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UcItemEmployee_MouseLeave);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox P_image;
        private CustomPanel.CustomPanel customPanel1;
        private CustomLabel E_position;
        private CustomLabel E_phone;
        private CustomLabel Ids;
        private CustomLabel customLabel3;
        private CustomLabel customLabel2;
        private CustomLabel E_name;
    }
}
