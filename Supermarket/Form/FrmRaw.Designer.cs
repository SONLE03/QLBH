namespace Supermarket
{
    partial class FrmRaw
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaw));
            this.price = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.provider = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.RprintDocument = new System.Drawing.Printing.PrintDocument();
            this.customPanel7 = new CustomPanel.CustomPanel();
            this.customPanel6 = new CustomPanel.CustomPanel();
            this.BtnDel = new Supermarket.CustomButton();
            this.BtnSave = new Supermarket.CustomButton();
            this.BtnExit = new Supermarket.CustomButton();
            this.BtnAdd = new Supermarket.CustomButton();
            this.customPanel5 = new CustomPanel.CustomPanel();
            this.customLabel6 = new Supermarket.CustomLabel();
            this.customPanel4 = new CustomPanel.CustomPanel();
            this.customLabel5 = new Supermarket.CustomLabel();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.customLabel3 = new Supermarket.CustomLabel();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.customLabel2 = new Supermarket.CustomLabel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.customLabel4 = new Supermarket.CustomLabel();
            this.customLabel1 = new Supermarket.CustomLabel();
            this.customPanel8 = new CustomPanel.CustomPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.customPanel6.SuspendLayout();
            this.customPanel5.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(19, 38);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(367, 39);
            this.price.TabIndex = 4;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // quantity
            // 
            this.quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(15, 35);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(359, 39);
            this.quantity.TabIndex = 3;
            this.quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_KeyPress);
            // 
            // provider
            // 
            this.provider.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provider.FormattingEnabled = true;
            this.provider.Location = new System.Drawing.Point(19, 39);
            this.provider.Name = "provider";
            this.provider.Size = new System.Drawing.Size(367, 39);
            this.provider.TabIndex = 46;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(15, 38);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(359, 39);
            this.name.TabIndex = 3;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.id);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(15, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 39);
            this.panel1.TabIndex = 46;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(3, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(103, 31);
            this.id.TabIndex = 47;
            this.id.Text = "PH00001";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView.Location = new System.Drawing.Point(27, 445);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 150;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1083, 279);
            this.dataGridView.TabIndex = 47;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Tên nguyên liệu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 290;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 240;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 233;
            // 
            // RprintPreviewDialog
            // 
            this.RprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.RprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.RprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.RprintPreviewDialog.Enabled = true;
            this.RprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("RprintPreviewDialog.Icon")));
            this.RprintPreviewDialog.Name = "RprintPreviewDialog";
            this.RprintPreviewDialog.Visible = false;
            // 
            // RprintDocument
            // 
            this.RprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.RprintDocument_PrintPage);
            // 
            // customPanel7
            // 
            this.customPanel7.BackColor = System.Drawing.Color.White;
            this.customPanel7.BorderRadius = 1;
            this.customPanel7.ForeColor = System.Drawing.Color.Black;
            this.customPanel7.GradientAngle = 174F;
            this.customPanel7.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel7.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel7.Location = new System.Drawing.Point(0, -1);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.Size = new System.Drawing.Size(1149, 45);
            this.customPanel7.TabIndex = 68;
            // 
            // customPanel6
            // 
            this.customPanel6.BackColor = System.Drawing.Color.White;
            this.customPanel6.BorderRadius = 30;
            this.customPanel6.Controls.Add(this.BtnDel);
            this.customPanel6.Controls.Add(this.BtnSave);
            this.customPanel6.Controls.Add(this.BtnExit);
            this.customPanel6.Controls.Add(this.BtnAdd);
            this.customPanel6.Controls.Add(this.customPanel5);
            this.customPanel6.Controls.Add(this.customPanel4);
            this.customPanel6.Controls.Add(this.customPanel3);
            this.customPanel6.Controls.Add(this.customPanel2);
            this.customPanel6.Controls.Add(this.customPanel1);
            this.customPanel6.Controls.Add(this.customLabel1);
            this.customPanel6.ForeColor = System.Drawing.Color.Black;
            this.customPanel6.GradientAngle = 161F;
            this.customPanel6.GradientBottomColor = System.Drawing.Color.SandyBrown;
            this.customPanel6.GradientTopColor = System.Drawing.Color.Wheat;
            this.customPanel6.Location = new System.Drawing.Point(25, 52);
            this.customPanel6.Name = "customPanel6";
            this.customPanel6.Size = new System.Drawing.Size(1083, 380);
            this.customPanel6.TabIndex = 69;
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.DeepPink;
            this.BtnDel.BackgroundColor = System.Drawing.Color.DeepPink;
            this.BtnDel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnDel.BorderRadius = 15;
            this.BtnDel.BorderSize = 0;
            this.BtnDel.FlatAppearance.BorderSize = 0;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.ForeColor = System.Drawing.Color.White;
            this.BtnDel.Location = new System.Drawing.Point(932, 221);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(132, 46);
            this.BtnDel.TabIndex = 75;
            this.BtnDel.Text = "Xóa";
            this.BtnDel.TextColor = System.Drawing.Color.White;
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.DeepPink;
            this.BtnSave.BackgroundColor = System.Drawing.Color.DeepPink;
            this.BtnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSave.BorderRadius = 15;
            this.BtnSave.BorderSize = 0;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(932, 143);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(132, 46);
            this.BtnSave.TabIndex = 74;
            this.BtnSave.Text = "Lưu";
            this.BtnSave.TextColor = System.Drawing.Color.White;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.DeepPink;
            this.BtnExit.BackgroundColor = System.Drawing.Color.DeepPink;
            this.BtnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnExit.BorderRadius = 15;
            this.BtnExit.BorderSize = 0;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(932, 299);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(132, 46);
            this.BtnExit.TabIndex = 73;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.TextColor = System.Drawing.Color.White;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.DeepPink;
            this.BtnAdd.BackgroundColor = System.Drawing.Color.DeepPink;
            this.BtnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAdd.BorderRadius = 15;
            this.BtnAdd.BorderSize = 0;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(932, 65);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(132, 46);
            this.BtnAdd.TabIndex = 72;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.TextColor = System.Drawing.Color.White;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // customPanel5
            // 
            this.customPanel5.BackColor = System.Drawing.Color.White;
            this.customPanel5.BorderRadius = 30;
            this.customPanel5.Controls.Add(this.customLabel6);
            this.customPanel5.Controls.Add(this.quantity);
            this.customPanel5.ForeColor = System.Drawing.Color.Black;
            this.customPanel5.GradientAngle = 202F;
            this.customPanel5.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel5.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel5.Location = new System.Drawing.Point(21, 271);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(391, 88);
            this.customPanel5.TabIndex = 71;
            // 
            // customLabel6
            // 
            this.customLabel6.BorderRadius = 1;
            this.customLabel6.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel6.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel6.ForeColor = System.Drawing.Color.White;
            this.customLabel6.GradientAngle = 19F;
            this.customLabel6.Location = new System.Drawing.Point(0, 0);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(391, 32);
            this.customLabel6.TabIndex = 0;
            this.customLabel6.Text = "Số lượng";
            this.customLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel6.UseCompatibleTextRendering = true;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderRadius = 30;
            this.customPanel4.Controls.Add(this.price);
            this.customPanel4.Controls.Add(this.customLabel5);
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 215F;
            this.customPanel4.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel4.Location = new System.Drawing.Point(480, 166);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(404, 91);
            this.customPanel4.TabIndex = 70;
            // 
            // customLabel5
            // 
            this.customLabel5.BorderRadius = 1;
            this.customLabel5.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel5.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel5.ForeColor = System.Drawing.Color.White;
            this.customLabel5.GradientAngle = 155F;
            this.customLabel5.Location = new System.Drawing.Point(0, 0);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(404, 32);
            this.customLabel5.TabIndex = 0;
            this.customLabel5.Text = "Đơn giá";
            this.customLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel5.UseCompatibleTextRendering = true;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 30;
            this.customPanel3.Controls.Add(this.customLabel3);
            this.customPanel3.Controls.Add(this.provider);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 339F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel3.Location = new System.Drawing.Point(480, 64);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(404, 91);
            this.customPanel3.TabIndex = 69;
            // 
            // customLabel3
            // 
            this.customLabel3.BorderRadius = 1;
            this.customLabel3.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel3.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel3.ForeColor = System.Drawing.Color.White;
            this.customLabel3.GradientAngle = 149F;
            this.customLabel3.Location = new System.Drawing.Point(0, 0);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(404, 32);
            this.customLabel3.TabIndex = 0;
            this.customLabel3.Text = "Tên nhà cung cấp";
            this.customLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel3.UseCompatibleTextRendering = true;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.customLabel2);
            this.customPanel2.Controls.Add(this.name);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 146F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel2.Location = new System.Drawing.Point(22, 166);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(391, 91);
            this.customPanel2.TabIndex = 68;
            // 
            // customLabel2
            // 
            this.customLabel2.BorderRadius = 1;
            this.customLabel2.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel2.ForeColor = System.Drawing.Color.White;
            this.customLabel2.GradientAngle = 324F;
            this.customLabel2.Location = new System.Drawing.Point(0, 0);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(391, 32);
            this.customLabel2.TabIndex = 0;
            this.customLabel2.Text = "Tên nguyên liệu";
            this.customLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel2.UseCompatibleTextRendering = true;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.panel1);
            this.customPanel1.Controls.Add(this.customLabel4);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 213F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel1.Location = new System.Drawing.Point(23, 64);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(391, 91);
            this.customPanel1.TabIndex = 67;
            // 
            // customLabel4
            // 
            this.customLabel4.BorderRadius = 1;
            this.customLabel4.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.customLabel4.ForeColor = System.Drawing.Color.White;
            this.customLabel4.GradientAngle = 360F;
            this.customLabel4.Location = new System.Drawing.Point(0, 0);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(391, 32);
            this.customLabel4.TabIndex = 0;
            this.customLabel4.Text = "Mã phiếu hàng";
            this.customLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel4.UseCompatibleTextRendering = true;
            // 
            // customLabel1
            // 
            this.customLabel1.BorderRadius = 20;
            this.customLabel1.Color1 = System.Drawing.Color.Lavender;
            this.customLabel1.Color2 = System.Drawing.Color.Azure;
            this.customLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.customLabel1.ForeColor = System.Drawing.Color.DeepPink;
            this.customLabel1.GradientAngle = 155F;
            this.customLabel1.Location = new System.Drawing.Point(-5, 0);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(1090, 45);
            this.customLabel1.TabIndex = 67;
            this.customLabel1.Text = "Phiếu hàng";
            this.customLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customPanel8
            // 
            this.customPanel8.BackColor = System.Drawing.Color.White;
            this.customPanel8.BorderRadius = 1;
            this.customPanel8.ForeColor = System.Drawing.Color.Black;
            this.customPanel8.GradientAngle = 114F;
            this.customPanel8.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel8.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel8.Location = new System.Drawing.Point(0, 738);
            this.customPanel8.Name = "customPanel8";
            this.customPanel8.Size = new System.Drawing.Size(1149, 45);
            this.customPanel8.TabIndex = 70;
            // 
            // FrmRaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 783);
            this.Controls.Add(this.customPanel8);
            this.Controls.Add(this.customPanel6);
            this.Controls.Add(this.customPanel7);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRaw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raw";
            this.Load += new System.EventHandler(this.Raw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.customPanel6.ResumeLayout(false);
            this.customPanel5.ResumeLayout(false);
            this.customPanel5.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.ComboBox provider;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PrintPreviewDialog RprintPreviewDialog;
        private System.Drawing.Printing.PrintDocument RprintDocument;
        private CustomPanel.CustomPanel customPanel7;
        private CustomButton BtnAdd;
        private CustomPanel.CustomPanel customPanel5;
        private CustomLabel customLabel6;
        private CustomPanel.CustomPanel customPanel4;
        private CustomLabel customLabel5;
        private CustomPanel.CustomPanel customPanel3;
        private CustomLabel customLabel3;
        private CustomPanel.CustomPanel customPanel2;
        private CustomLabel customLabel2;
        private CustomPanel.CustomPanel customPanel1;
        private CustomLabel customLabel4;
        private CustomLabel customLabel1;
        private CustomButton BtnDel;
        private CustomButton BtnSave;
        private CustomButton BtnExit;
        private CustomPanel.CustomPanel customPanel8;
        private CustomPanel.CustomPanel customPanel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}