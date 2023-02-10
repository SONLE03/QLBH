namespace Supermarket
{
    partial class FrmProduct
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
            this.type = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.pictureBox1 = new Supermarket.CustomPictureBox();
            this.add_I = new Supermarket.CustomButton();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.customLabel1 = new Supermarket.CustomLabel();
            this.customPanel4 = new CustomPanel.CustomPanel();
            this.customLabel2 = new Supermarket.CustomLabel();
            this.customPanel5 = new CustomPanel.CustomPanel();
            this.customLabel3 = new Supermarket.CustomLabel();
            this.customPanel6 = new CustomPanel.CustomPanel();
            this.customLabel4 = new Supermarket.CustomLabel();
            this.customPanel7 = new CustomPanel.CustomPanel();
            this.customLabel5 = new Supermarket.CustomLabel();
            this.customPanel8 = new CustomPanel.CustomPanel();
            this.customLabel6 = new Supermarket.CustomLabel();
            this.BtnSave = new Supermarket.CustomButton();
            this.BtnDelete = new Supermarket.CustomButton();
            this.BtnExit = new Supermarket.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel2.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.customPanel5.SuspendLayout();
            this.customPanel6.SuspendLayout();
            this.customPanel7.SuspendLayout();
            this.customPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(20, 37);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(346, 38);
            this.type.TabIndex = 31;
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(20, 36);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(346, 37);
            this.description.TabIndex = 3;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(20, 37);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(346, 37);
            this.price.TabIndex = 3;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(19, 43);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(383, 37);
            this.quantity.TabIndex = 3;
            this.quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_KeyPress);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(19, 37);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(383, 37);
            this.name.TabIndex = 3;
            // 
            // search
            // 
            this.search.Image = global::Supermarket.Properties.Resources.search1;
            this.search.Location = new System.Drawing.Point(669, 106);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(45, 45);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search.TabIndex = 4;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(19, 38);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(383, 37);
            this.id.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sản phẩm";
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 1;
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 44F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel3.Location = new System.Drawing.Point(-1, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1326, 39);
            this.customPanel3.TabIndex = 56;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 1;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 19F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel1.Location = new System.Drawing.Point(-1, 428);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1326, 39);
            this.customPanel1.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.pictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBox1.BorderSize = 2;
            this.pictureBox1.GradientAngle = 50F;
            this.pictureBox1.Location = new System.Drawing.Point(19, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // add_I
            // 
            this.add_I.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.add_I.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.add_I.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add_I.BorderRadius = 20;
            this.add_I.BorderSize = 0;
            this.add_I.FlatAppearance.BorderSize = 0;
            this.add_I.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_I.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_I.ForeColor = System.Drawing.Color.White;
            this.add_I.Location = new System.Drawing.Point(35, 300);
            this.add_I.Name = "add_I";
            this.add_I.Size = new System.Drawing.Size(148, 40);
            this.add_I.TabIndex = 59;
            this.add_I.Text = "Thêm ảnh";
            this.add_I.TextColor = System.Drawing.Color.White;
            this.add_I.UseVisualStyleBackColor = false;
            this.add_I.Click += new System.EventHandler(this.add_I_Click);
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.customLabel1);
            this.customPanel2.Controls.Add(this.id);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 332F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel2.Location = new System.Drawing.Point(243, 68);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(420, 91);
            this.customPanel2.TabIndex = 60;
            // 
            // customLabel1
            // 
            this.customLabel1.BorderRadius = 1;
            this.customLabel1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customLabel1.Color2 = System.Drawing.Color.Thistle;
            this.customLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customLabel1.GradientAngle = 147F;
            this.customLabel1.Location = new System.Drawing.Point(0, 1);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(420, 32);
            this.customLabel1.TabIndex = 0;
            this.customLabel1.Text = "Mã sản phẩm";
            this.customLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel1.UseCompatibleTextRendering = true;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderRadius = 30;
            this.customPanel4.Controls.Add(this.customLabel2);
            this.customPanel4.Controls.Add(this.name);
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 306F;
            this.customPanel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel4.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel4.Location = new System.Drawing.Point(242, 184);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(420, 90);
            this.customPanel4.TabIndex = 61;
            // 
            // customLabel2
            // 
            this.customLabel2.BorderRadius = 1;
            this.customLabel2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customLabel2.Color2 = System.Drawing.Color.Thistle;
            this.customLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customLabel2.GradientAngle = 121F;
            this.customLabel2.Location = new System.Drawing.Point(0, 2);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(420, 32);
            this.customLabel2.TabIndex = 0;
            this.customLabel2.Text = "Tên sản phẩm";
            this.customLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel2.UseCompatibleTextRendering = true;
            // 
            // customPanel5
            // 
            this.customPanel5.BackColor = System.Drawing.Color.White;
            this.customPanel5.BorderRadius = 30;
            this.customPanel5.Controls.Add(this.quantity);
            this.customPanel5.Controls.Add(this.customLabel3);
            this.customPanel5.ForeColor = System.Drawing.Color.Black;
            this.customPanel5.GradientAngle = 223F;
            this.customPanel5.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel5.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel5.Location = new System.Drawing.Point(243, 300);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(420, 97);
            this.customPanel5.TabIndex = 62;
            // 
            // customLabel3
            // 
            this.customLabel3.BorderRadius = 1;
            this.customLabel3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customLabel3.Color2 = System.Drawing.Color.Thistle;
            this.customLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customLabel3.GradientAngle = 33F;
            this.customLabel3.Location = new System.Drawing.Point(0, 1);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(420, 32);
            this.customLabel3.TabIndex = 0;
            this.customLabel3.Text = "Số lượng";
            this.customLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel3.UseCompatibleTextRendering = true;
            // 
            // customPanel6
            // 
            this.customPanel6.BackColor = System.Drawing.Color.White;
            this.customPanel6.BorderRadius = 30;
            this.customPanel6.Controls.Add(this.customLabel4);
            this.customPanel6.Controls.Add(this.price);
            this.customPanel6.ForeColor = System.Drawing.Color.Black;
            this.customPanel6.GradientAngle = 28F;
            this.customPanel6.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel6.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel6.Location = new System.Drawing.Point(740, 69);
            this.customPanel6.Name = "customPanel6";
            this.customPanel6.Size = new System.Drawing.Size(391, 91);
            this.customPanel6.TabIndex = 63;
            // 
            // customLabel4
            // 
            this.customLabel4.BorderRadius = 1;
            this.customLabel4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customLabel4.Color2 = System.Drawing.Color.Thistle;
            this.customLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customLabel4.GradientAngle = 66F;
            this.customLabel4.Location = new System.Drawing.Point(0, 1);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(420, 32);
            this.customLabel4.TabIndex = 0;
            this.customLabel4.Text = "Giá sản phẩm";
            this.customLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel4.UseCompatibleTextRendering = true;
            // 
            // customPanel7
            // 
            this.customPanel7.BackColor = System.Drawing.Color.White;
            this.customPanel7.BorderRadius = 30;
            this.customPanel7.Controls.Add(this.customLabel5);
            this.customPanel7.Controls.Add(this.description);
            this.customPanel7.ForeColor = System.Drawing.Color.Black;
            this.customPanel7.GradientAngle = 339F;
            this.customPanel7.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel7.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel7.Location = new System.Drawing.Point(740, 183);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.Size = new System.Drawing.Size(391, 91);
            this.customPanel7.TabIndex = 64;
            // 
            // customLabel5
            // 
            this.customLabel5.BorderRadius = 1;
            this.customLabel5.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customLabel5.Color2 = System.Drawing.Color.Thistle;
            this.customLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customLabel5.GradientAngle = 155F;
            this.customLabel5.Location = new System.Drawing.Point(0, 1);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(391, 32);
            this.customLabel5.TabIndex = 0;
            this.customLabel5.Text = "Mô tả";
            this.customLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel5.UseCompatibleTextRendering = true;
            // 
            // customPanel8
            // 
            this.customPanel8.BackColor = System.Drawing.Color.White;
            this.customPanel8.BorderRadius = 30;
            this.customPanel8.Controls.Add(this.customLabel6);
            this.customPanel8.Controls.Add(this.type);
            this.customPanel8.ForeColor = System.Drawing.Color.Black;
            this.customPanel8.GradientAngle = 52F;
            this.customPanel8.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel8.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel8.Location = new System.Drawing.Point(740, 306);
            this.customPanel8.Name = "customPanel8";
            this.customPanel8.Size = new System.Drawing.Size(391, 91);
            this.customPanel8.TabIndex = 65;
            // 
            // customLabel6
            // 
            this.customLabel6.BorderRadius = 1;
            this.customLabel6.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customLabel6.Color2 = System.Drawing.Color.Thistle;
            this.customLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customLabel6.GradientAngle = 229F;
            this.customLabel6.Location = new System.Drawing.Point(0, 1);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(420, 32);
            this.customLabel6.TabIndex = 0;
            this.customLabel6.Text = "Loại sản phẩm";
            this.customLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel6.UseCompatibleTextRendering = true;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSave.BorderRadius = 20;
            this.BtnSave.BorderSize = 0;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(1151, 148);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(162, 40);
            this.BtnSave.TabIndex = 66;
            this.BtnSave.Text = "Thêm sản phẩm";
            this.BtnSave.TextColor = System.Drawing.Color.White;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnDelete.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnDelete.BorderRadius = 20;
            this.BtnDelete.BorderSize = 0;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(1151, 219);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(162, 40);
            this.BtnDelete.TabIndex = 67;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.TextColor = System.Drawing.Color.White;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnExit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnExit.BorderRadius = 20;
            this.BtnExit.BorderSize = 0;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(1151, 293);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(162, 40);
            this.BtnExit.TabIndex = 68;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.TextColor = System.Drawing.Color.White;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1325, 467);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.customPanel8);
            this.Controls.Add(this.customPanel7);
            this.Controls.Add(this.customPanel6);
            this.Controls.Add(this.customPanel5);
            this.Controls.Add(this.customPanel4);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.add_I);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.customPanel5.ResumeLayout(false);
            this.customPanel5.PerformLayout();
            this.customPanel6.ResumeLayout(false);
            this.customPanel6.PerformLayout();
            this.customPanel7.ResumeLayout(false);
            this.customPanel7.PerformLayout();
            this.customPanel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private CustomPanel.CustomPanel customPanel3;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPictureBox pictureBox1;
        private CustomButton add_I;
        private CustomPanel.CustomPanel customPanel2;
        private CustomLabel customLabel1;
        private CustomPanel.CustomPanel customPanel4;
        private CustomLabel customLabel2;
        private CustomPanel.CustomPanel customPanel5;
        private CustomLabel customLabel3;
        private CustomPanel.CustomPanel customPanel6;
        private CustomLabel customLabel4;
        private CustomPanel.CustomPanel customPanel7;
        private CustomLabel customLabel5;
        private CustomPanel.CustomPanel customPanel8;
        private CustomLabel customLabel6;
        private CustomButton BtnSave;
        private CustomButton BtnDelete;
        private CustomButton BtnExit;
    }
}