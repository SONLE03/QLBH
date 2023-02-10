using System.Windows.Forms;

namespace Supermarket
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.Pic_Home = new Supermarket.CustomPictureBox();
            this.logout = new Supermarket.CustomButton();
            this.setting = new Supermarket.CustomButton();
            this.raw = new Supermarket.CustomButton();
            this.supplier = new Supermarket.CustomButton();
            this.customer = new Supermarket.CustomButton();
            this.bill = new Supermarket.CustomButton();
            this.employee = new Supermarket.CustomButton();
            this.category = new Supermarket.CustomButton();
            this.product = new Supermarket.CustomButton();
            this.dashboard = new Supermarket.CustomButton();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.control_panel = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucHome1 = new Supermarket.Usercontrol.UcHome();
            this.setting_Employee1 = new Supermarket.Setting_Employee();
            this.dashboard2 = new Supermarket.Dashboard();
            this.bill1 = new Supermarket.Usercontrol.Bill();
            this.supplier1 = new Supermarket.Supplier();
            this.sellers1 = new Supermarket.Sellers();
            this.raw_Material2 = new Supermarket.Raw_Material();
            this.products1 = new Supermarket.Products();
            this.categories1 = new Supermarket.Categories();
            this.customers1 = new Supermarket.Customers();
            this.raw_Material1 = new Supermarket.Raw_Material();
            this.panel1.SuspendLayout();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.customPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 800);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 1;
            this.customPanel3.Controls.Add(this.Pic_Home);
            this.customPanel3.Controls.Add(this.logout);
            this.customPanel3.Controls.Add(this.setting);
            this.customPanel3.Controls.Add(this.raw);
            this.customPanel3.Controls.Add(this.supplier);
            this.customPanel3.Controls.Add(this.customer);
            this.customPanel3.Controls.Add(this.bill);
            this.customPanel3.Controls.Add(this.employee);
            this.customPanel3.Controls.Add(this.category);
            this.customPanel3.Controls.Add(this.product);
            this.customPanel3.Controls.Add(this.dashboard);
            this.customPanel3.Controls.Add(this.pictureBox8);
            this.customPanel3.Controls.Add(this.pictureBox11);
            this.customPanel3.Controls.Add(this.pictureBox2);
            this.customPanel3.Controls.Add(this.control_panel);
            this.customPanel3.Controls.Add(this.pictureBox9);
            this.customPanel3.Controls.Add(this.pictureBox10);
            this.customPanel3.Controls.Add(this.pictureBox3);
            this.customPanel3.Controls.Add(this.pictureBox7);
            this.customPanel3.Controls.Add(this.pictureBox4);
            this.customPanel3.Controls.Add(this.pictureBox5);
            this.customPanel3.Controls.Add(this.pictureBox6);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 214F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.LavenderBlush;
            this.customPanel3.GradientTopColor = System.Drawing.Color.SkyBlue;
            this.customPanel3.Location = new System.Drawing.Point(-1, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(271, 800);
            this.customPanel3.TabIndex = 85;
            this.customPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel3_Paint);
            // 
            // Pic_Home
            // 
            this.Pic_Home.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.Pic_Home.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Pic_Home.BorderColor2 = System.Drawing.Color.HotPink;
            this.Pic_Home.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.Pic_Home.BorderSize = 2;
            this.Pic_Home.GradientAngle = 50F;
            this.Pic_Home.Image = global::Supermarket.Properties.Resources.shopping;
            this.Pic_Home.Location = new System.Drawing.Point(70, 21);
            this.Pic_Home.Name = "Pic_Home";
            this.Pic_Home.Size = new System.Drawing.Size(130, 130);
            this.Pic_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Home.TabIndex = 83;
            this.Pic_Home.TabStop = false;
            this.Pic_Home.Click += new System.EventHandler(this.Pic_Home_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.logout.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.logout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.logout.BorderRadius = 10;
            this.logout.BorderSize = 0;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(80, 727);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(170, 40);
            this.logout.TabIndex = 82;
            this.logout.Text = "Đăng xuất";
            this.logout.TextColor = System.Drawing.Color.White;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.setting.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.setting.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.setting.BorderRadius = 10;
            this.setting.BorderSize = 0;
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting.ForeColor = System.Drawing.Color.White;
            this.setting.Location = new System.Drawing.Point(80, 664);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(170, 40);
            this.setting.TabIndex = 81;
            this.setting.Text = "Cài đặt";
            this.setting.TextColor = System.Drawing.Color.White;
            this.setting.UseVisualStyleBackColor = false;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // raw
            // 
            this.raw.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.raw.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.raw.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.raw.BorderRadius = 10;
            this.raw.BorderSize = 0;
            this.raw.FlatAppearance.BorderSize = 0;
            this.raw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raw.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raw.ForeColor = System.Drawing.Color.White;
            this.raw.Location = new System.Drawing.Point(80, 602);
            this.raw.Name = "raw";
            this.raw.Size = new System.Drawing.Size(170, 40);
            this.raw.TabIndex = 80;
            this.raw.Text = "Nguyên liệu";
            this.raw.TextColor = System.Drawing.Color.White;
            this.raw.UseVisualStyleBackColor = false;
            this.raw.Click += new System.EventHandler(this.raw_Click);
            // 
            // supplier
            // 
            this.supplier.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.supplier.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.supplier.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.supplier.BorderRadius = 10;
            this.supplier.BorderSize = 0;
            this.supplier.FlatAppearance.BorderSize = 0;
            this.supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplier.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier.ForeColor = System.Drawing.Color.White;
            this.supplier.Location = new System.Drawing.Point(80, 539);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(170, 40);
            this.supplier.TabIndex = 79;
            this.supplier.Text = "Nhà cung cấp";
            this.supplier.TextColor = System.Drawing.Color.White;
            this.supplier.UseVisualStyleBackColor = false;
            this.supplier.Click += new System.EventHandler(this.supplier_Click);
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customer.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customer.BorderRadius = 10;
            this.customer.BorderSize = 0;
            this.customer.FlatAppearance.BorderSize = 0;
            this.customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.White;
            this.customer.Location = new System.Drawing.Point(80, 475);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(170, 40);
            this.customer.TabIndex = 78;
            this.customer.Text = "Khách hàng";
            this.customer.TextColor = System.Drawing.Color.White;
            this.customer.UseVisualStyleBackColor = false;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // bill
            // 
            this.bill.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bill.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bill.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bill.BorderRadius = 10;
            this.bill.BorderSize = 0;
            this.bill.FlatAppearance.BorderSize = 0;
            this.bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bill.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.ForeColor = System.Drawing.Color.White;
            this.bill.Location = new System.Drawing.Point(80, 413);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(170, 40);
            this.bill.TabIndex = 77;
            this.bill.Text = "Hóa đơn";
            this.bill.TextColor = System.Drawing.Color.White;
            this.bill.UseVisualStyleBackColor = false;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // employee
            // 
            this.employee.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.employee.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.employee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.employee.BorderRadius = 10;
            this.employee.BorderSize = 0;
            this.employee.FlatAppearance.BorderSize = 0;
            this.employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.ForeColor = System.Drawing.Color.White;
            this.employee.Location = new System.Drawing.Point(80, 351);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(170, 40);
            this.employee.TabIndex = 76;
            this.employee.Text = "Nhân viên";
            this.employee.TextColor = System.Drawing.Color.White;
            this.employee.UseVisualStyleBackColor = false;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.category.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.category.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.category.BorderRadius = 10;
            this.category.BorderSize = 0;
            this.category.FlatAppearance.BorderSize = 0;
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.White;
            this.category.Location = new System.Drawing.Point(80, 291);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(170, 40);
            this.category.TabIndex = 75;
            this.category.Text = "Loại sản phẩm";
            this.category.TextColor = System.Drawing.Color.White;
            this.category.UseVisualStyleBackColor = false;
            this.category.Click += new System.EventHandler(this.product_type_Click);
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.product.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.product.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.product.BorderRadius = 10;
            this.product.BorderSize = 0;
            this.product.FlatAppearance.BorderSize = 0;
            this.product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.ForeColor = System.Drawing.Color.White;
            this.product.Location = new System.Drawing.Point(80, 229);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(170, 40);
            this.product.TabIndex = 74;
            this.product.Text = "Sản phẩm";
            this.product.TextColor = System.Drawing.Color.White;
            this.product.UseVisualStyleBackColor = false;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.dashboard.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dashboard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dashboard.BorderRadius = 10;
            this.dashboard.BorderSize = 0;
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.Location = new System.Drawing.Point(80, 168);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(167, 40);
            this.dashboard.TabIndex = 73;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextColor = System.Drawing.Color.White;
            this.dashboard.UseVisualStyleBackColor = false;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Supermarket.Properties.Resources.logout__1_;
            this.pictureBox8.Location = new System.Drawing.Point(20, 727);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::Supermarket.Properties.Resources.setting1;
            this.pictureBox11.Location = new System.Drawing.Point(19, 663);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(50, 40);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 23;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.dashboard2;
            this.pictureBox2.Location = new System.Drawing.Point(20, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.control_panel.Location = new System.Drawing.Point(0, 168);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(15, 40);
            this.control_panel.TabIndex = 17;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::Supermarket.Properties.Resources.barrow;
            this.pictureBox9.Location = new System.Drawing.Point(20, 600);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::Supermarket.Properties.Resources.inventory__1_1;
            this.pictureBox10.Location = new System.Drawing.Point(20, 539);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 40);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Supermarket.Properties.Resources.box__1_;
            this.pictureBox3.Location = new System.Drawing.Point(20, 230);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Supermarket.Properties.Resources.conversation;
            this.pictureBox7.Location = new System.Drawing.Point(20, 473);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Supermarket.Properties.Resources.category;
            this.pictureBox4.Location = new System.Drawing.Point(20, 290);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Supermarket.Properties.Resources.process;
            this.pictureBox5.Location = new System.Drawing.Point(20, 350);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Supermarket.Properties.Resources.invoice1;
            this.pictureBox6.Location = new System.Drawing.Point(20, 411);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ucHome1);
            this.panel2.Controls.Add(this.setting_Employee1);
            this.panel2.Controls.Add(this.dashboard2);
            this.panel2.Controls.Add(this.bill1);
            this.panel2.Controls.Add(this.supplier1);
            this.panel2.Controls.Add(this.sellers1);
            this.panel2.Controls.Add(this.raw_Material2);
            this.panel2.Controls.Add(this.products1);
            this.panel2.Controls.Add(this.categories1);
            this.panel2.Controls.Add(this.customers1);
            this.panel2.Controls.Add(this.raw_Material1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(270, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 800);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ucHome1
            // 
            this.ucHome1.Location = new System.Drawing.Point(0, 0);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(1200, 800);
            this.ucHome1.TabIndex = 12;
            // 
            // setting_Employee1
            // 
            this.setting_Employee1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.setting_Employee1.Location = new System.Drawing.Point(0, 0);
            this.setting_Employee1.Name = "setting_Employee1";
            this.setting_Employee1.Size = new System.Drawing.Size(1200, 800);
            this.setting_Employee1.TabIndex = 11;
            // 
            // dashboard2
            // 
            this.dashboard2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dashboard2.Location = new System.Drawing.Point(0, 0);
            this.dashboard2.Name = "dashboard2";
            this.dashboard2.Size = new System.Drawing.Size(1200, 800);
            this.dashboard2.TabIndex = 10;
            // 
            // bill1
            // 
            this.bill1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.bill1.Location = new System.Drawing.Point(0, 0);
            this.bill1.Name = "bill1";
            this.bill1.Size = new System.Drawing.Size(1200, 800);
            this.bill1.TabIndex = 9;
            // 
            // supplier1
            // 
            this.supplier1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.supplier1.Location = new System.Drawing.Point(0, 0);
            this.supplier1.Name = "supplier1";
            this.supplier1.Size = new System.Drawing.Size(1200, 800);
            this.supplier1.TabIndex = 8;
            // 
            // sellers1
            // 
            this.sellers1.BackColor = System.Drawing.Color.White;
            this.sellers1.Location = new System.Drawing.Point(0, 0);
            this.sellers1.Name = "sellers1";
            this.sellers1.Size = new System.Drawing.Size(1200, 800);
            this.sellers1.TabIndex = 7;
            // 
            // raw_Material2
            // 
            this.raw_Material2.BackColor = System.Drawing.Color.White;
            this.raw_Material2.Location = new System.Drawing.Point(0, 0);
            this.raw_Material2.Name = "raw_Material2";
            this.raw_Material2.Size = new System.Drawing.Size(1200, 800);
            this.raw_Material2.TabIndex = 6;
            // 
            // products1
            // 
            this.products1.BackColor = System.Drawing.Color.White;
            this.products1.Location = new System.Drawing.Point(0, 0);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(1200, 800);
            this.products1.TabIndex = 5;
            // 
            // categories1
            // 
            this.categories1.BackColor = System.Drawing.Color.White;
            this.categories1.Location = new System.Drawing.Point(0, 0);
            this.categories1.Name = "categories1";
            this.categories1.Size = new System.Drawing.Size(1200, 800);
            this.categories1.TabIndex = 3;
            // 
            // customers1
            // 
            this.customers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.customers1.Location = new System.Drawing.Point(0, 0);
            this.customers1.Name = "customers1";
            this.customers1.Size = new System.Drawing.Size(1200, 800);
            this.customers1.TabIndex = 2;
            // 
            // raw_Material1
            // 
            this.raw_Material1.BackColor = System.Drawing.Color.White;
            this.raw_Material1.Location = new System.Drawing.Point(0, 0);
            this.raw_Material1.Name = "raw_Material1";
            this.raw_Material1.Size = new System.Drawing.Size(1200, 800);
            this.raw_Material1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Raw_Material raw_Material1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private Usercontrol.Bill bill1;
        private Supplier supplier1;
        private Sellers sellers1;
        private Raw_Material raw_Material2;
        private Products products1;
        private Categories categories1;
        private Customers customers1;
        private Dashboard dashboard2;
        private System.Windows.Forms.PictureBox pictureBox11;
        private Setting_Employee setting_Employee1;
        private CustomPanel.CustomPanel customPanel3;
        private CustomButton dashboard;
        private CustomButton product;
        private CustomButton category;
        private CustomButton setting;
        private CustomButton raw;
        private CustomButton supplier;
        private CustomButton customer;
        private CustomButton bill;
        private CustomButton employee;
        private CustomButton logout;
        private CustomPictureBox Pic_Home;
        private Usercontrol.UcHome ucHome1;
    }
}