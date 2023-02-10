namespace Supermarket.Usercontrol
{
    partial class Bill
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b = new Supermarket.B();
            this.bILLTableAdapter = new Supermarket.BTableAdapters.BILLTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.delete = new System.Windows.Forms.PictureBox();
            this.reload = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_name = new System.Windows.Forms.TextBox();
            this.customPanel7 = new CustomPanel.CustomPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel3 = new CustomPanel.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.customPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bILLBindingSource
            // 
            this.bILLBindingSource.DataMember = "BILL";
            this.bILLBindingSource.DataSource = this.b;
            // 
            // b
            // 
            this.b.DataSetName = "B";
            this.b.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bILLTableAdapter
            // 
            this.bILLTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.customPanel3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.customPanel2);
            this.panel3.Controls.Add(this.customPanel1);
            this.panel3.Controls.Add(this.customPanel7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 800);
            this.panel3.TabIndex = 55;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.receipt;
            this.pictureBox2.Location = new System.Drawing.Point(30, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 1;
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 158F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel2.Location = new System.Drawing.Point(0, 755);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1200, 45);
            this.customPanel2.TabIndex = 77;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.delete);
            this.customPanel1.Controls.Add(this.reload);
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.Controls.Add(this.id_name);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 43F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel1.Location = new System.Drawing.Point(25, 116);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1150, 76);
            this.customPanel1.TabIndex = 76;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.Image = global::Supermarket.Properties.Resources.delete__2_;
            this.delete.Location = new System.Drawing.Point(913, 12);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(64, 53);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 48;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            this.delete.MouseHover += new System.EventHandler(this.delete_MouseHover);
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.Transparent;
            this.reload.Image = global::Supermarket.Properties.Resources.refresh__1_;
            this.reload.Location = new System.Drawing.Point(1031, 12);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(57, 53);
            this.reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reload.TabIndex = 11;
            this.reload.TabStop = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            this.reload.MouseHover += new System.EventHandler(this.reload_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.search__4_;
            this.pictureBox1.Location = new System.Drawing.Point(27, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // id_name
            // 
            this.id_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_name.Location = new System.Drawing.Point(99, 25);
            this.id_name.Multiline = true;
            this.id_name.Name = "id_name";
            this.id_name.Size = new System.Drawing.Size(415, 30);
            this.id_name.TabIndex = 3;
            this.id_name.TextChanged += new System.EventHandler(this.id_name_TextChanged);
            // 
            // customPanel7
            // 
            this.customPanel7.BackColor = System.Drawing.Color.White;
            this.customPanel7.BorderRadius = 1;
            this.customPanel7.ForeColor = System.Drawing.Color.Black;
            this.customPanel7.GradientAngle = 42F;
            this.customPanel7.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel7.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel7.Location = new System.Drawing.Point(0, 1);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.Size = new System.Drawing.Size(1200, 45);
            this.customPanel7.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(85, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hóa đơn bán hàng";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(137)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.bDATEDataGridViewTextBoxColumn,
            this.bPRICEDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridView.DataSource = this.bILLBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(137)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(13, 14);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1117, 480);
            this.dataGridView.TabIndex = 56;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "B_ID";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.bIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.bIDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.bIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIDDataGridViewTextBoxColumn.Width = 220;
            // 
            // bDATEDataGridViewTextBoxColumn
            // 
            this.bDATEDataGridViewTextBoxColumn.DataPropertyName = "B_DATE";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.bDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.bDATEDataGridViewTextBoxColumn.HeaderText = "Ngày hóa đơn";
            this.bDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDATEDataGridViewTextBoxColumn.Name = "bDATEDataGridViewTextBoxColumn";
            this.bDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bDATEDataGridViewTextBoxColumn.Width = 190;
            // 
            // bPRICEDataGridViewTextBoxColumn
            // 
            this.bPRICEDataGridViewTextBoxColumn.DataPropertyName = "B_PRICE";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.bPRICEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.bPRICEDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.bPRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bPRICEDataGridViewTextBoxColumn.Name = "bPRICEDataGridViewTextBoxColumn";
            this.bPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bPRICEDataGridViewTextBoxColumn.Width = 210;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CUS_NAME";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EM_NAME";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column2.HeaderText = "Nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 30;
            this.customPanel3.Controls.Add(this.dataGridView);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 353F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel3.Location = new System.Drawing.Point(30, 220);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1145, 509);
            this.customPanel3.TabIndex = 79;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.panel3);
            this.Name = "Bill";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.customPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bILLBindingSource;
        private B b;
        private BTableAdapters.BILLTableAdapter bILLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox reload;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox id_name;
        private System.Windows.Forms.Label label3;
        private CustomPanel.CustomPanel customPanel2;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private CustomPanel.CustomPanel customPanel3;
    }
}
