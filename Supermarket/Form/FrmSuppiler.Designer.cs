namespace Supermarket
{
    partial class FrmSuppiler
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
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.customLabel2 = new Supermarket.CustomLabel();
            this.customPanel4 = new CustomPanel.CustomPanel();
            this.customLabel1 = new Supermarket.CustomLabel();
            this.customPanel5 = new CustomPanel.CustomPanel();
            this.customLabel3 = new Supermarket.CustomLabel();
            this.customPanel6 = new CustomPanel.CustomPanel();
            this.customLabel4 = new Supermarket.CustomLabel();
            this.BtnSave = new Supermarket.CustomButton();
            this.BtnExit = new Supermarket.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_id = new System.Windows.Forms.PictureBox();
            this.customPanel2.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.customPanel5.SuspendLayout();
            this.customPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_id)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nhà cung cấp";
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(15, 39);
            this.phone.MaxLength = 10;
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(332, 40);
            this.phone.TabIndex = 3;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(15, 39);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(332, 40);
            this.address.TabIndex = 3;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(12, 39);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(332, 40);
            this.name.TabIndex = 3;
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(12, 39);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(332, 40);
            this.id.TabIndex = 3;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 1;
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 301F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel3.Location = new System.Drawing.Point(0, -1);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1067, 35);
            this.customPanel3.TabIndex = 86;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 1;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 261F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel1.Location = new System.Drawing.Point(1, 311);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1067, 35);
            this.customPanel1.TabIndex = 87;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.customLabel2);
            this.customPanel2.Controls.Add(this.id);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 162F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel2.Location = new System.Drawing.Point(128, 81);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(359, 94);
            this.customPanel2.TabIndex = 88;
            // 
            // customLabel2
            // 
            this.customLabel2.BorderRadius = 1;
            this.customLabel2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customLabel2.Color2 = System.Drawing.Color.Thistle;
            this.customLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel2.ForeColor = System.Drawing.Color.White;
            this.customLabel2.GradientAngle = 36F;
            this.customLabel2.Location = new System.Drawing.Point(0, 0);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(359, 38);
            this.customLabel2.TabIndex = 4;
            this.customLabel2.Text = "Mã nhà cung cấp";
            this.customLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel2.UseCompatibleTextRendering = true;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderRadius = 30;
            this.customPanel4.Controls.Add(this.customLabel1);
            this.customPanel4.Controls.Add(this.name);
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 108F;
            this.customPanel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel4.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel4.Location = new System.Drawing.Point(128, 193);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(359, 94);
            this.customPanel4.TabIndex = 89;
            // 
            // customLabel1
            // 
            this.customLabel1.BorderRadius = 1;
            this.customLabel1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customLabel1.Color2 = System.Drawing.Color.Thistle;
            this.customLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.GradientAngle = 343F;
            this.customLabel1.Location = new System.Drawing.Point(0, 0);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(359, 38);
            this.customLabel1.TabIndex = 4;
            this.customLabel1.Text = "Mã nhà cung cấp";
            this.customLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel1.UseCompatibleTextRendering = true;
            // 
            // customPanel5
            // 
            this.customPanel5.BackColor = System.Drawing.Color.White;
            this.customPanel5.BorderRadius = 30;
            this.customPanel5.Controls.Add(this.customLabel3);
            this.customPanel5.Controls.Add(this.phone);
            this.customPanel5.ForeColor = System.Drawing.Color.Black;
            this.customPanel5.GradientAngle = 186F;
            this.customPanel5.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel5.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel5.Location = new System.Drawing.Point(544, 80);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(359, 94);
            this.customPanel5.TabIndex = 90;
            // 
            // customLabel3
            // 
            this.customLabel3.BorderRadius = 1;
            this.customLabel3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customLabel3.Color2 = System.Drawing.Color.Thistle;
            this.customLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel3.ForeColor = System.Drawing.Color.White;
            this.customLabel3.GradientAngle = 65F;
            this.customLabel3.Location = new System.Drawing.Point(0, 0);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(359, 38);
            this.customLabel3.TabIndex = 4;
            this.customLabel3.Text = "Số điện thoại";
            this.customLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel3.UseCompatibleTextRendering = true;
            // 
            // customPanel6
            // 
            this.customPanel6.BackColor = System.Drawing.Color.White;
            this.customPanel6.BorderRadius = 30;
            this.customPanel6.Controls.Add(this.customLabel4);
            this.customPanel6.Controls.Add(this.address);
            this.customPanel6.ForeColor = System.Drawing.Color.Black;
            this.customPanel6.GradientAngle = 21F;
            this.customPanel6.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel6.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel6.Location = new System.Drawing.Point(544, 193);
            this.customPanel6.Name = "customPanel6";
            this.customPanel6.Size = new System.Drawing.Size(359, 94);
            this.customPanel6.TabIndex = 91;
            // 
            // customLabel4
            // 
            this.customLabel4.BorderRadius = 1;
            this.customLabel4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customLabel4.Color2 = System.Drawing.Color.Thistle;
            this.customLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel4.ForeColor = System.Drawing.Color.White;
            this.customLabel4.GradientAngle = 257F;
            this.customLabel4.Location = new System.Drawing.Point(0, 0);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(359, 38);
            this.customLabel4.TabIndex = 4;
            this.customLabel4.Text = "Địa chỉ";
            this.customLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel4.UseCompatibleTextRendering = true;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnSave.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.BtnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSave.BorderRadius = 15;
            this.BtnSave.BorderSize = 0;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(919, 121);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(136, 40);
            this.BtnSave.TabIndex = 92;
            this.BtnSave.Text = "Lưu";
            this.BtnSave.TextColor = System.Drawing.Color.White;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnExit.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.BtnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnExit.BorderRadius = 15;
            this.BtnExit.BorderSize = 0;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(919, 193);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(136, 40);
            this.BtnExit.TabIndex = 93;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.TextColor = System.Drawing.Color.White;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.inventory__1_;
            this.pictureBox1.Location = new System.Drawing.Point(13, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // search_id
            // 
            this.search_id.Image = global::Supermarket.Properties.Resources.search1;
            this.search_id.Location = new System.Drawing.Point(493, 120);
            this.search_id.Name = "search_id";
            this.search_id.Size = new System.Drawing.Size(45, 45);
            this.search_id.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_id.TabIndex = 4;
            this.search_id.TabStop = false;
            this.search_id.Click += new System.EventHandler(this.search_id_Click);
            // 
            // FrmSuppiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.customPanel6);
            this.Controls.Add(this.customPanel5);
            this.Controls.Add(this.customPanel4);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.search_id);
            this.Controls.Add(this.customPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSuppiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSuppiler";
            this.Load += new System.EventHandler(this.FrmSuppiler_Load);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.customPanel5.ResumeLayout(false);
            this.customPanel5.PerformLayout();
            this.customPanel6.ResumeLayout(false);
            this.customPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.PictureBox search_id;
        private CustomPanel.CustomPanel customPanel3;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel2;
        private CustomLabel customLabel2;
        private CustomPanel.CustomPanel customPanel4;
        private CustomLabel customLabel1;
        private CustomPanel.CustomPanel customPanel5;
        private CustomLabel customLabel3;
        private CustomPanel.CustomPanel customPanel6;
        private CustomLabel customLabel4;
        private CustomButton BtnSave;
        private CustomButton BtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}