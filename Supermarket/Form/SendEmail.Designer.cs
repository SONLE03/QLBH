namespace Supermarket
{
    partial class SendEmail
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
            this.Email = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.BtnSave = new Supermarket.CustomButton();
            this.BtnExit = new Supermarket.CustomButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(126, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lấy mã xác nhận";
            // 
            // Email
            // 
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(18, 86);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(308, 38);
            this.Email.TabIndex = 10;
            this.Email.Text = "Địa chỉ mail";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // UserName
            // 
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(18, 25);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(308, 38);
            this.UserName.TabIndex = 8;
            this.UserName.Text = "Tên đăng nhập";
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 1;
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 350F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(430, 38);
            this.customPanel3.TabIndex = 86;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 1;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 330F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel1.Location = new System.Drawing.Point(0, 322);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(430, 38);
            this.customPanel1.TabIndex = 87;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.UserName);
            this.customPanel2.Controls.Add(this.Email);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 128F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel2.Location = new System.Drawing.Point(39, 103);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(341, 145);
            this.customPanel2.TabIndex = 88;
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
            this.BtnSave.Location = new System.Drawing.Point(53, 267);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(136, 40);
            this.BtnSave.TabIndex = 89;
            this.BtnSave.Text = "Lấy mã";
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
            this.BtnExit.Location = new System.Drawing.Point(229, 267);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(136, 40);
            this.BtnExit.TabIndex = 90;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.TextColor = System.Drawing.Color.White;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.email;
            this.pictureBox2.Location = new System.Drawing.Point(66, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 360);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendEmail";
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox UserName;
        private CustomPanel.CustomPanel customPanel3;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel2;
        private CustomButton BtnSave;
        private CustomButton BtnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}