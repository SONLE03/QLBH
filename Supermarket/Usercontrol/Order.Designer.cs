namespace Supermarket
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BprintDocument = new System.Drawing.Printing.PrintDocument();
            this.BprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.gTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel5 = new CustomPanel.CustomPanel();
            this.dataGridView_addOrder = new System.Windows.Forms.DataGridView();
            this.Masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customPanel4 = new CustomPanel.CustomPanel();
            this.print = new Supermarket.CustomButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.price = new System.Windows.Forms.Label();
            this.delete = new Supermarket.CustomButton();
            this.AddOrder = new Supermarket.CustomButton();
            this.Product = new System.Windows.Forms.ComboBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Employee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.panel1.SuspendLayout();
            this.customPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_addOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.customPanel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BprintDocument
            // 
            this.BprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.BprintDocument_PrintPage);
            // 
            // BprintPreviewDialog
            // 
            this.BprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.BprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.BprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.BprintPreviewDialog.Enabled = true;
            this.BprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("BprintPreviewDialog.Icon")));
            this.BprintPreviewDialog.Name = "BprintPreviewDialog";
            this.BprintPreviewDialog.Visible = false;
            // 
            // gTotal
            // 
            this.gTotal.AutoSize = true;
            this.gTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTotal.ForeColor = System.Drawing.Color.White;
            this.gTotal.Location = new System.Drawing.Point(945, 759);
            this.gTotal.Name = "gTotal";
            this.gTotal.Size = new System.Drawing.Size(0, 28);
            this.gTotal.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(809, 759);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 28);
            this.label8.TabIndex = 58;
            this.label8.Text = "Thành tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.BlueViolet;
            this.label9.Location = new System.Drawing.Point(528, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 38);
            this.label9.TabIndex = 59;
            this.label9.Text = "HÓA ĐƠN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.customPanel5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.customPanel4);
            this.panel1.Controls.Add(this.customPanel2);
            this.panel1.Controls.Add(this.customPanel1);
            this.panel1.Controls.Add(this.customPanel3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.gTotal);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 800);
            this.panel1.TabIndex = 0;
            // 
            // customPanel5
            // 
            this.customPanel5.BackColor = System.Drawing.Color.White;
            this.customPanel5.BorderRadius = 30;
            this.customPanel5.Controls.Add(this.dataGridView_addOrder);
            this.customPanel5.ForeColor = System.Drawing.Color.Black;
            this.customPanel5.GradientAngle = 153F;
            this.customPanel5.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel5.GradientTopColor = System.Drawing.Color.Plum;
            this.customPanel5.Location = new System.Drawing.Point(60, 441);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(1080, 308);
            this.customPanel5.TabIndex = 91;
            // 
            // dataGridView_addOrder
            // 
            this.dataGridView_addOrder.AllowUserToAddRows = false;
            this.dataGridView_addOrder.AllowUserToDeleteRows = false;
            this.dataGridView_addOrder.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView_addOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_addOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(137)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(132)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_addOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_addOrder.ColumnHeadersHeight = 35;
            this.dataGridView_addOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masp,
            this.Tensp,
            this.Dongia,
            this.Soluong,
            this.Thanhtien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(129)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(134)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_addOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_addOrder.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_addOrder.Location = new System.Drawing.Point(10, 8);
            this.dataGridView_addOrder.Name = "dataGridView_addOrder";
            this.dataGridView_addOrder.ReadOnly = true;
            this.dataGridView_addOrder.RowHeadersVisible = false;
            this.dataGridView_addOrder.RowHeadersWidth = 51;
            this.dataGridView_addOrder.RowTemplate.Height = 24;
            this.dataGridView_addOrder.Size = new System.Drawing.Size(1061, 294);
            this.dataGridView_addOrder.TabIndex = 56;
            // 
            // Masp
            // 
            this.Masp.HeaderText = "Mã sản phẩm";
            this.Masp.MinimumWidth = 6;
            this.Masp.Name = "Masp";
            this.Masp.ReadOnly = true;
            this.Masp.Width = 150;
            // 
            // Tensp
            // 
            this.Tensp.HeaderText = "Tên sản phẩm";
            this.Tensp.MinimumWidth = 6;
            this.Tensp.Name = "Tensp";
            this.Tensp.ReadOnly = true;
            this.Tensp.Width = 250;
            // 
            // Dongia
            // 
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.MinimumWidth = 6;
            this.Dongia.Name = "Dongia";
            this.Dongia.ReadOnly = true;
            this.Dongia.Width = 150;
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            this.Soluong.Width = 125;
            // 
            // Thanhtien
            // 
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.MinimumWidth = 6;
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            this.Thanhtien.Width = 150;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.bill1;
            this.pictureBox2.Location = new System.Drawing.Point(469, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 90;
            this.pictureBox2.TabStop = false;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderRadius = 30;
            this.customPanel4.Controls.Add(this.print);
            this.customPanel4.Controls.Add(this.label7);
            this.customPanel4.Controls.Add(this.panel6);
            this.customPanel4.Controls.Add(this.delete);
            this.customPanel4.Controls.Add(this.AddOrder);
            this.customPanel4.Controls.Add(this.Product);
            this.customPanel4.Controls.Add(this.Quantity);
            this.customPanel4.Controls.Add(this.label5);
            this.customPanel4.Controls.Add(this.label6);
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 57F;
            this.customPanel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel4.GradientTopColor = System.Drawing.Color.Plum;
            this.customPanel4.Location = new System.Drawing.Point(631, 91);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(516, 335);
            this.customPanel4.TabIndex = 89;
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.White;
            this.print.BackgroundColor = System.Drawing.Color.White;
            this.print.BorderColor = System.Drawing.Color.BlueViolet;
            this.print.BorderRadius = 20;
            this.print.BorderSize = 2;
            this.print.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.print.FlatAppearance.BorderSize = 2;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.Color.DarkViolet;
            this.print.Location = new System.Drawing.Point(310, 254);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(167, 49);
            this.print.TabIndex = 48;
            this.print.Text = "Thanh toán";
            this.print.TextColor = System.Drawing.Color.DarkViolet;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 28);
            this.label7.TabIndex = 46;
            this.label7.Text = "Số lượng";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.price);
            this.panel6.Location = new System.Drawing.Point(43, 117);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(434, 31);
            this.panel6.TabIndex = 45;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.Location = new System.Drawing.Point(3, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 25);
            this.price.TabIndex = 23;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.BackgroundColor = System.Drawing.Color.White;
            this.delete.BorderColor = System.Drawing.Color.BlueViolet;
            this.delete.BorderRadius = 20;
            this.delete.BorderSize = 2;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            this.delete.FlatAppearance.BorderSize = 2;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.DarkViolet;
            this.delete.Location = new System.Drawing.Point(178, 254);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(121, 49);
            this.delete.TabIndex = 47;
            this.delete.Text = "Xóa";
            this.delete.TextColor = System.Drawing.Color.DarkViolet;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // AddOrder
            // 
            this.AddOrder.BackColor = System.Drawing.Color.White;
            this.AddOrder.BackgroundColor = System.Drawing.Color.White;
            this.AddOrder.BorderColor = System.Drawing.Color.BlueViolet;
            this.AddOrder.BorderRadius = 20;
            this.AddOrder.BorderSize = 2;
            this.AddOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.AddOrder.FlatAppearance.BorderSize = 2;
            this.AddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrder.ForeColor = System.Drawing.Color.DarkViolet;
            this.AddOrder.Location = new System.Drawing.Point(46, 254);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(121, 49);
            this.AddOrder.TabIndex = 46;
            this.AddOrder.Text = "Thêm";
            this.AddOrder.TextColor = System.Drawing.Color.DarkViolet;
            this.AddOrder.UseVisualStyleBackColor = false;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.FormattingEnabled = true;
            this.Product.Location = new System.Drawing.Point(43, 43);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(434, 33);
            this.Product.TabIndex = 31;
            this.Product.SelectedValueChanged += new System.EventHandler(this.Product_SelectedValueChanged);
            // 
            // Quantity
            // 
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quantity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(43, 192);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(434, 31);
            this.Quantity.TabIndex = 32;
            this.Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 37;
            this.label5.Text = "Mã sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 38;
            this.label6.Text = "Đơn giá";
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.panel4);
            this.customPanel2.Controls.Add(this.panel2);
            this.customPanel2.Controls.Add(this.label4);
            this.customPanel2.Controls.Add(this.panel3);
            this.customPanel2.Controls.Add(this.Customer);
            this.customPanel2.Controls.Add(this.label3);
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.Controls.Add(this.label2);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 153F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.Plum;
            this.customPanel2.Location = new System.Drawing.Point(54, 91);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(519, 335);
            this.customPanel2.TabIndex = 88;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.id);
            this.panel4.Location = new System.Drawing.Point(38, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 31);
            this.panel4.TabIndex = 46;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.Location = new System.Drawing.Point(3, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 25);
            this.id.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Employee);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(39, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 33);
            this.panel2.TabIndex = 43;
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.ForeColor = System.Drawing.Color.Black;
            this.Employee.Location = new System.Drawing.Point(3, 1);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(0, 25);
            this.Employee.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mã hóa đơn";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.date);
            this.panel3.Location = new System.Drawing.Point(39, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 31);
            this.panel3.TabIndex = 44;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.Location = new System.Drawing.Point(3, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 25);
            this.date.TabIndex = 23;
            // 
            // Customer
            // 
            this.Customer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.FormattingEnabled = true;
            this.Customer.Location = new System.Drawing.Point(38, 115);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(437, 33);
            this.Customer.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "Thời gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 28);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã nhân viên - Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 28);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mã khách hàng - Tên khách hàng";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 1;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 150F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.Plum;
            this.customPanel1.Location = new System.Drawing.Point(-1, 762);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1201, 38);
            this.customPanel1.TabIndex = 87;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 1;
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 210F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.Plum;
            this.customPanel3.Location = new System.Drawing.Point(-1, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1201, 38);
            this.customPanel3.TabIndex = 86;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_addOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument BprintDocument;
        private System.Windows.Forms.PrintPreviewDialog BprintPreviewDialog;
        private CustomButton print;
        private CustomButton delete;
        private CustomButton AddOrder;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.ComboBox Product;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label gTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_addOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.ComboBox Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel3;
        private CustomPanel.CustomPanel customPanel2;
        private CustomPanel.CustomPanel customPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomPanel.CustomPanel customPanel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
    }
}
