namespace Supermarket
{
    partial class SignUp
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
            this.mail = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.usn = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.TextBox();
            this.customPanel6 = new CustomPanel.CustomPanel();
            this.customLabel4 = new Supermarket.CustomLabel();
            this.customPanel7 = new CustomPanel.CustomPanel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.customLabel1 = new Supermarket.CustomLabel();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.customLabel2 = new Supermarket.CustomLabel();
            this.customPanel4 = new CustomPanel.CustomPanel();
            this.customLabel3 = new Supermarket.CustomLabel();
            this.customPanel5 = new CustomPanel.CustomPanel();
            this.customLabel5 = new Supermarket.CustomLabel();
            this.customPanel8 = new CustomPanel.CustomPanel();
            this.customLabel6 = new Supermarket.CustomLabel();
            this.customPanel9 = new CustomPanel.CustomPanel();
            this.customLabel7 = new Supermarket.CustomLabel();
            this.add_I = new Supermarket.CustomButton();
            this.BtnSaveE = new Supermarket.CustomButton();
            this.BtnExitE = new Supermarket.CustomButton();
            this.pictureBox1 = new Supermarket.CustomPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customPanel6.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.customPanel5.SuspendLayout();
            this.customPanel8.SuspendLayout();
            this.customPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mail
            // 
            this.mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(20, 37);
            this.mail.Multiline = true;
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(350, 38);
            this.mail.TabIndex = 4;
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(22, 36);
            this.phone.MaxLength = 10;
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(350, 38);
            this.phone.TabIndex = 3;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(21, 36);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(350, 38);
            this.pass.TabIndex = 3;
            // 
            // usn
            // 
            this.usn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usn.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usn.Location = new System.Drawing.Point(20, 37);
            this.usn.Multiline = true;
            this.usn.Name = "usn";
            this.usn.Size = new System.Drawing.Size(350, 38);
            this.usn.TabIndex = 3;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(20, 36);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(350, 38);
            this.name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(77, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng ký tài khoản";
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lý"});
            this.position.Location = new System.Drawing.Point(21, 36);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(349, 38);
            this.position.TabIndex = 32;
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(20, 35);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(350, 38);
            this.id.TabIndex = 3;
            // 
            // customPanel6
            // 
            this.customPanel6.BackColor = System.Drawing.Color.White;
            this.customPanel6.BorderRadius = 30;
            this.customPanel6.Controls.Add(this.customLabel4);
            this.customPanel6.Controls.Add(this.position);
            this.customPanel6.ForeColor = System.Drawing.Color.Black;
            this.customPanel6.GradientAngle = 282F;
            this.customPanel6.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel6.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel6.Location = new System.Drawing.Point(296, 94);
            this.customPanel6.Name = "customPanel6";
            this.customPanel6.Size = new System.Drawing.Size(391, 91);
            this.customPanel6.TabIndex = 65;
            // 
            // customLabel4
            // 
            this.customLabel4.BorderRadius = 1;
            this.customLabel4.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel4.ForeColor = System.Drawing.Color.White;
            this.customLabel4.GradientAngle = 98F;
            this.customLabel4.Location = new System.Drawing.Point(0, 1);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(391, 32);
            this.customLabel4.TabIndex = 0;
            this.customLabel4.Text = "Vị trí";
            this.customLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel4.UseCompatibleTextRendering = true;
            // 
            // customPanel7
            // 
            this.customPanel7.BackColor = System.Drawing.Color.White;
            this.customPanel7.BorderRadius = 1;
            this.customPanel7.ForeColor = System.Drawing.Color.Black;
            this.customPanel7.GradientAngle = 139F;
            this.customPanel7.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel7.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel7.Location = new System.Drawing.Point(0, 0);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.Size = new System.Drawing.Size(1163, 45);
            this.customPanel7.TabIndex = 67;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 1;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 53F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel1.Location = new System.Drawing.Point(0, 525);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1163, 45);
            this.customPanel1.TabIndex = 68;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.customLabel1);
            this.customPanel2.Controls.Add(this.usn);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 237F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel2.Location = new System.Drawing.Point(297, 199);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(391, 91);
            this.customPanel2.TabIndex = 66;
            // 
            // customLabel1
            // 
            this.customLabel1.BorderRadius = 1;
            this.customLabel1.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.GradientAngle = 50F;
            this.customLabel1.Location = new System.Drawing.Point(0, 1);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(391, 32);
            this.customLabel1.TabIndex = 0;
            this.customLabel1.Text = "Tên đăng nhập";
            this.customLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel1.UseCompatibleTextRendering = true;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 30;
            this.customPanel3.Controls.Add(this.customLabel2);
            this.customPanel3.Controls.Add(this.name);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 205F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel3.Location = new System.Drawing.Point(296, 304);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(391, 91);
            this.customPanel3.TabIndex = 70;
            // 
            // customLabel2
            // 
            this.customLabel2.BorderRadius = 1;
            this.customLabel2.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel2.ForeColor = System.Drawing.Color.White;
            this.customLabel2.GradientAngle = 23F;
            this.customLabel2.Location = new System.Drawing.Point(0, 1);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(391, 32);
            this.customLabel2.TabIndex = 0;
            this.customLabel2.Text = "Họ và tên";
            this.customLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel2.UseCompatibleTextRendering = true;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderRadius = 30;
            this.customPanel4.Controls.Add(this.customLabel3);
            this.customPanel4.Controls.Add(this.id);
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 152F;
            this.customPanel4.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel4.Location = new System.Drawing.Point(718, 95);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(391, 91);
            this.customPanel4.TabIndex = 71;
            // 
            // customLabel3
            // 
            this.customLabel3.BorderRadius = 1;
            this.customLabel3.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel3.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel3.ForeColor = System.Drawing.Color.White;
            this.customLabel3.GradientAngle = 315F;
            this.customLabel3.Location = new System.Drawing.Point(0, 1);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(391, 32);
            this.customLabel3.TabIndex = 0;
            this.customLabel3.Text = "Mã nhân viên";
            this.customLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel3.UseCompatibleTextRendering = true;
            // 
            // customPanel5
            // 
            this.customPanel5.BackColor = System.Drawing.Color.White;
            this.customPanel5.BorderRadius = 30;
            this.customPanel5.Controls.Add(this.customLabel5);
            this.customPanel5.Controls.Add(this.pass);
            this.customPanel5.ForeColor = System.Drawing.Color.Black;
            this.customPanel5.GradientAngle = 165F;
            this.customPanel5.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel5.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel5.Location = new System.Drawing.Point(720, 200);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(391, 91);
            this.customPanel5.TabIndex = 66;
            // 
            // customLabel5
            // 
            this.customLabel5.BorderRadius = 1;
            this.customLabel5.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel5.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.customLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel5.ForeColor = System.Drawing.Color.White;
            this.customLabel5.GradientAngle = 342F;
            this.customLabel5.Location = new System.Drawing.Point(0, 0);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(391, 32);
            this.customLabel5.TabIndex = 0;
            this.customLabel5.Text = "Mật khẩu";
            this.customLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel5.UseCompatibleTextRendering = true;
            // 
            // customPanel8
            // 
            this.customPanel8.BackColor = System.Drawing.Color.White;
            this.customPanel8.BorderRadius = 30;
            this.customPanel8.Controls.Add(this.customLabel6);
            this.customPanel8.Controls.Add(this.phone);
            this.customPanel8.ForeColor = System.Drawing.Color.Black;
            this.customPanel8.GradientAngle = 250F;
            this.customPanel8.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel8.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel8.Location = new System.Drawing.Point(718, 304);
            this.customPanel8.Name = "customPanel8";
            this.customPanel8.Size = new System.Drawing.Size(391, 91);
            this.customPanel8.TabIndex = 66;
            // 
            // customLabel6
            // 
            this.customLabel6.BorderRadius = 1;
            this.customLabel6.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel6.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel6.ForeColor = System.Drawing.Color.White;
            this.customLabel6.GradientAngle = 66F;
            this.customLabel6.Location = new System.Drawing.Point(0, 1);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(391, 32);
            this.customLabel6.TabIndex = 0;
            this.customLabel6.Text = "Số điện thoại";
            this.customLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel6.UseCompatibleTextRendering = true;
            // 
            // customPanel9
            // 
            this.customPanel9.BackColor = System.Drawing.Color.White;
            this.customPanel9.BorderRadius = 30;
            this.customPanel9.Controls.Add(this.mail);
            this.customPanel9.Controls.Add(this.customLabel7);
            this.customPanel9.ForeColor = System.Drawing.Color.Black;
            this.customPanel9.GradientAngle = 43F;
            this.customPanel9.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel9.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel9.Location = new System.Drawing.Point(299, 413);
            this.customPanel9.Name = "customPanel9";
            this.customPanel9.Size = new System.Drawing.Size(391, 91);
            this.customPanel9.TabIndex = 72;
            // 
            // customLabel7
            // 
            this.customLabel7.BorderRadius = 1;
            this.customLabel7.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel7.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel7.ForeColor = System.Drawing.Color.White;
            this.customLabel7.GradientAngle = 220F;
            this.customLabel7.Location = new System.Drawing.Point(0, 1);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(391, 32);
            this.customLabel7.TabIndex = 0;
            this.customLabel7.Text = "Email";
            this.customLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel7.UseCompatibleTextRendering = true;
            // 
            // add_I
            // 
            this.add_I.BackColor = System.Drawing.Color.DeepPink;
            this.add_I.BackgroundColor = System.Drawing.Color.DeepPink;
            this.add_I.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_I.BorderRadius = 15;
            this.add_I.BorderSize = 0;
            this.add_I.FlatAppearance.BorderSize = 0;
            this.add_I.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_I.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_I.ForeColor = System.Drawing.Color.White;
            this.add_I.Location = new System.Drawing.Point(59, 309);
            this.add_I.Name = "add_I";
            this.add_I.Size = new System.Drawing.Size(162, 46);
            this.add_I.TabIndex = 73;
            this.add_I.Text = "Chọn ảnh";
            this.add_I.TextColor = System.Drawing.Color.White;
            this.add_I.UseVisualStyleBackColor = false;
            this.add_I.Click += new System.EventHandler(this.add_I_Click);
            // 
            // BtnSaveE
            // 
            this.BtnSaveE.BackColor = System.Drawing.Color.DeepPink;
            this.BtnSaveE.BackgroundColor = System.Drawing.Color.DeepPink;
            this.BtnSaveE.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSaveE.BorderRadius = 15;
            this.BtnSaveE.BorderSize = 0;
            this.BtnSaveE.FlatAppearance.BorderSize = 0;
            this.BtnSaveE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveE.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveE.ForeColor = System.Drawing.Color.White;
            this.BtnSaveE.Location = new System.Drawing.Point(741, 442);
            this.BtnSaveE.Name = "BtnSaveE";
            this.BtnSaveE.Size = new System.Drawing.Size(150, 46);
            this.BtnSaveE.TabIndex = 74;
            this.BtnSaveE.Text = "Lưu";
            this.BtnSaveE.TextColor = System.Drawing.Color.White;
            this.BtnSaveE.UseVisualStyleBackColor = false;
            this.BtnSaveE.Click += new System.EventHandler(this.BtnSaveE_Click);
            // 
            // BtnExitE
            // 
            this.BtnExitE.BackColor = System.Drawing.Color.DeepPink;
            this.BtnExitE.BackgroundColor = System.Drawing.Color.DeepPink;
            this.BtnExitE.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnExitE.BorderRadius = 15;
            this.BtnExitE.BorderSize = 0;
            this.BtnExitE.FlatAppearance.BorderSize = 0;
            this.BtnExitE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitE.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitE.ForeColor = System.Drawing.Color.White;
            this.BtnExitE.Location = new System.Drawing.Point(959, 442);
            this.BtnExitE.Name = "BtnExitE";
            this.BtnExitE.Size = new System.Drawing.Size(150, 46);
            this.BtnExitE.TabIndex = 75;
            this.BtnExitE.Text = "Thoát";
            this.BtnExitE.TextColor = System.Drawing.Color.White;
            this.BtnExitE.UseVisualStyleBackColor = false;
            this.BtnExitE.Click += new System.EventHandler(this.BtnExitE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBox1.BorderColor = System.Drawing.Color.OrangeRed;
            this.pictureBox1.BorderColor2 = System.Drawing.Color.Violet;
            this.pictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBox1.BorderSize = 2;
            this.pictureBox1.GradientAngle = 50F;
            this.pictureBox1.Location = new System.Drawing.Point(45, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.employee;
            this.pictureBox2.Location = new System.Drawing.Point(21, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 570);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnExitE);
            this.Controls.Add(this.BtnSaveE);
            this.Controls.Add(this.add_I);
            this.Controls.Add(this.customPanel9);
            this.Controls.Add(this.customPanel8);
            this.Controls.Add(this.customPanel5);
            this.Controls.Add(this.customPanel4);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customPanel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.customPanel6.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.customPanel5.ResumeLayout(false);
            this.customPanel5.PerformLayout();
            this.customPanel8.ResumeLayout(false);
            this.customPanel8.PerformLayout();
            this.customPanel9.ResumeLayout(false);
            this.customPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox usn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.TextBox id;
        private CustomPanel.CustomPanel customPanel6;
        private CustomLabel customLabel4;
        private CustomPanel.CustomPanel customPanel7;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPictureBox pictureBox1;
        private CustomPanel.CustomPanel customPanel2;
        private CustomLabel customLabel1;
        private CustomPanel.CustomPanel customPanel3;
        private CustomLabel customLabel2;
        private CustomPanel.CustomPanel customPanel4;
        private CustomLabel customLabel3;
        private CustomPanel.CustomPanel customPanel5;
        private CustomLabel customLabel5;
        private CustomPanel.CustomPanel customPanel8;
        private CustomLabel customLabel6;
        private CustomPanel.CustomPanel customPanel9;
        private CustomLabel customLabel7;
        private CustomButton add_I;
        private CustomButton BtnSaveE;
        private CustomButton BtnExitE;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}