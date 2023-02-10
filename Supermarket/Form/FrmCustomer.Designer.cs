namespace Supermarket
{
    partial class FrmCustomer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.id = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel7 = new CustomPanel.CustomPanel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.customLabel4 = new Supermarket.CustomLabel();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.customLabel1 = new Supermarket.CustomLabel();
            this.customPanel4 = new CustomPanel.CustomPanel();
            this.customLabel2 = new Supermarket.CustomLabel();
            this.customPanel5 = new CustomPanel.CustomPanel();
            this.customLabel3 = new Supermarket.CustomLabel();
            this.BtnSave = new Supermarket.CustomButton();
            this.BtnExit = new Supermarket.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_id = new System.Windows.Forms.PictureBox();
            this.customPanel2.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.customPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_id)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(17, 33);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(337, 45);
            this.id.TabIndex = 3;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(18, 34);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(337, 45);
            this.address.TabIndex = 3;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(19, 33);
            this.phone.MaxLength = 10;
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(337, 45);
            this.phone.TabIndex = 3;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(18, 33);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(337, 45);
            this.name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(71, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Khách hàng";
            // 
            // customPanel7
            // 
            this.customPanel7.BackColor = System.Drawing.Color.White;
            this.customPanel7.BorderRadius = 1;
            this.customPanel7.ForeColor = System.Drawing.Color.Black;
            this.customPanel7.GradientAngle = 267F;
            this.customPanel7.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.customPanel7.GradientTopColor = System.Drawing.Color.SkyBlue;
            this.customPanel7.Location = new System.Drawing.Point(0, 0);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.Size = new System.Drawing.Size(1108, 40);
            this.customPanel7.TabIndex = 67;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 1;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 28F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.customPanel1.GradientTopColor = System.Drawing.Color.SkyBlue;
            this.customPanel1.Location = new System.Drawing.Point(0, 325);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1108, 40);
            this.customPanel1.TabIndex = 68;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.customLabel4);
            this.customPanel2.Controls.Add(this.id);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 297F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.BlueViolet;
            this.customPanel2.Location = new System.Drawing.Point(140, 86);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(373, 91);
            this.customPanel2.TabIndex = 69;
            // 
            // customLabel4
            // 
            this.customLabel4.BorderRadius = 1;
            this.customLabel4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customLabel4.Color2 = System.Drawing.Color.BlueViolet;
            this.customLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel4.ForeColor = System.Drawing.Color.White;
            this.customLabel4.GradientAngle = 81F;
            this.customLabel4.Location = new System.Drawing.Point(0, 0);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(373, 32);
            this.customLabel4.TabIndex = 0;
            this.customLabel4.Text = "Mã khách hàng";
            this.customLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel4.UseCompatibleTextRendering = true;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 30;
            this.customPanel3.Controls.Add(this.customLabel1);
            this.customPanel3.Controls.Add(this.name);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 147F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.BlueViolet;
            this.customPanel3.Location = new System.Drawing.Point(140, 197);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(373, 91);
            this.customPanel3.TabIndex = 70;
            // 
            // customLabel1
            // 
            this.customLabel1.BorderRadius = 1;
            this.customLabel1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customLabel1.Color2 = System.Drawing.Color.BlueViolet;
            this.customLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.GradientAngle = 292F;
            this.customLabel1.Location = new System.Drawing.Point(0, 0);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(373, 32);
            this.customLabel1.TabIndex = 0;
            this.customLabel1.Text = "Tên khách hàng";
            this.customLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel1.UseCompatibleTextRendering = true;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderRadius = 30;
            this.customPanel4.Controls.Add(this.customLabel2);
            this.customPanel4.Controls.Add(this.phone);
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 283F;
            this.customPanel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel4.GradientTopColor = System.Drawing.Color.BlueViolet;
            this.customPanel4.Location = new System.Drawing.Point(570, 86);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(372, 91);
            this.customPanel4.TabIndex = 71;
            // 
            // customLabel2
            // 
            this.customLabel2.BorderRadius = 1;
            this.customLabel2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customLabel2.Color2 = System.Drawing.Color.BlueViolet;
            this.customLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel2.ForeColor = System.Drawing.Color.White;
            this.customLabel2.GradientAngle = 69F;
            this.customLabel2.Location = new System.Drawing.Point(0, 0);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(372, 32);
            this.customLabel2.TabIndex = 0;
            this.customLabel2.Text = "Số điện thoại";
            this.customLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel2.UseCompatibleTextRendering = true;
            // 
            // customPanel5
            // 
            this.customPanel5.BackColor = System.Drawing.Color.White;
            this.customPanel5.BorderRadius = 30;
            this.customPanel5.Controls.Add(this.customLabel3);
            this.customPanel5.Controls.Add(this.address);
            this.customPanel5.ForeColor = System.Drawing.Color.Black;
            this.customPanel5.GradientAngle = 222F;
            this.customPanel5.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel5.GradientTopColor = System.Drawing.Color.BlueViolet;
            this.customPanel5.Location = new System.Drawing.Point(570, 197);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(372, 91);
            this.customPanel5.TabIndex = 70;
            // 
            // customLabel3
            // 
            this.customLabel3.BorderRadius = 1;
            this.customLabel3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customLabel3.Color2 = System.Drawing.Color.BlueViolet;
            this.customLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel3.ForeColor = System.Drawing.Color.White;
            this.customLabel3.GradientAngle = 355F;
            this.customLabel3.Location = new System.Drawing.Point(0, 0);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(372, 32);
            this.customLabel3.TabIndex = 0;
            this.customLabel3.Text = "Địa chỉ";
            this.customLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel3.UseCompatibleTextRendering = true;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSave.BorderRadius = 15;
            this.BtnSave.BorderSize = 0;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(979, 137);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(115, 40);
            this.BtnSave.TabIndex = 89;
            this.BtnSave.Text = "Lưu";
            this.BtnSave.TextColor = System.Drawing.Color.White;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnExit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnExit.BorderRadius = 15;
            this.BtnExit.BorderSize = 0;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(979, 209);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(115, 40);
            this.BtnExit.TabIndex = 90;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.TextColor = System.Drawing.Color.White;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.target_audience;
            this.pictureBox1.Location = new System.Drawing.Point(26, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // search_id
            // 
            this.search_id.Image = global::Supermarket.Properties.Resources.search1;
            this.search_id.Location = new System.Drawing.Point(519, 119);
            this.search_id.Name = "search_id";
            this.search_id.Size = new System.Drawing.Size(45, 45);
            this.search_id.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_id.TabIndex = 4;
            this.search_id.TabStop = false;
            this.search_id.Click += new System.EventHandler(this.search_id_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 365);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.customPanel5);
            this.Controls.Add(this.customPanel4);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.customPanel5.ResumeLayout(false);
            this.customPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox search_id;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private CustomPanel.CustomPanel customPanel7;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel2;
        private CustomLabel customLabel4;
        private CustomPanel.CustomPanel customPanel3;
        private CustomLabel customLabel1;
        private CustomPanel.CustomPanel customPanel4;
        private CustomLabel customLabel2;
        private CustomPanel.CustomPanel customPanel5;
        private CustomLabel customLabel3;
        private CustomButton BtnSave;
        private CustomButton BtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}