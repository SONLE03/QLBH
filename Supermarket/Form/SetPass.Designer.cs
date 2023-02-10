namespace Supermarket
{
    partial class SetPass
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
            this.CN_Pass = new System.Windows.Forms.TextBox();
            this.N_Pass = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // CN_Pass
            // 
            this.CN_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CN_Pass.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CN_Pass.Location = new System.Drawing.Point(14, 143);
            this.CN_Pass.Multiline = true;
            this.CN_Pass.Name = "CN_Pass";
            this.CN_Pass.Size = new System.Drawing.Size(312, 38);
            this.CN_Pass.TabIndex = 14;
            this.CN_Pass.Text = "Xác nhận mật khẩu mới";
            this.CN_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CN_Pass.Click += new System.EventHandler(this.CN_Pass_Click);
            // 
            // N_Pass
            // 
            this.N_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.N_Pass.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_Pass.Location = new System.Drawing.Point(14, 83);
            this.N_Pass.Multiline = true;
            this.N_Pass.Name = "N_Pass";
            this.N_Pass.Size = new System.Drawing.Size(312, 38);
            this.N_Pass.TabIndex = 12;
            this.N_Pass.Text = "Mật khẩu mới";
            this.N_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.N_Pass.Click += new System.EventHandler(this.N_Pass_Click);
            // 
            // Code
            // 
            this.Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Code.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.Location = new System.Drawing.Point(14, 21);
            this.Code.Multiline = true;
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(312, 38);
            this.Code.TabIndex = 16;
            this.Code.Text = "Mã xác nhận";
            this.Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Code.Click += new System.EventHandler(this.Code_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(143, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cập nhật mật khẩu";
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 1;
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 173F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(451, 38);
            this.customPanel3.TabIndex = 85;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 1;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 86F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel1.Location = new System.Drawing.Point(-1, 364);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(451, 38);
            this.customPanel1.TabIndex = 86;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.Code);
            this.customPanel2.Controls.Add(this.N_Pass);
            this.customPanel2.Controls.Add(this.CN_Pass);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 325F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel2.Location = new System.Drawing.Point(53, 88);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(341, 198);
            this.customPanel2.TabIndex = 87;
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
            this.BtnSave.Location = new System.Drawing.Point(67, 306);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(136, 40);
            this.BtnSave.TabIndex = 88;
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
            this.BtnExit.Location = new System.Drawing.Point(243, 305);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(136, 40);
            this.BtnExit.TabIndex = 89;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.TextColor = System.Drawing.Color.White;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.rotate;
            this.pictureBox2.Location = new System.Drawing.Point(93, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 90;
            this.pictureBox2.TabStop = false;
            // 
            // SetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetPass";
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CN_Pass;
        private System.Windows.Forms.TextBox N_Pass;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Label label1;
        private CustomPanel.CustomPanel customPanel3;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel2;
        private CustomButton BtnSave;
        private CustomButton BtnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}