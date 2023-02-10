namespace Supermarket
{
    partial class FrmBillInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bILLINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billInfo = new Supermarket.BillInfo();
            this.bILLINFOTableAdapter = new Supermarket.BillInfoTableAdapters.BILLINFOTableAdapter();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.customLabel4 = new Supermarket.CustomLabel();
            this.customPanel7 = new CustomPanel.CustomPanel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.BtnExit = new Supermarket.CustomButton();
            this.pROIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billInfo)).BeginInit();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 35;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pROIDDataGridViewTextBoxColumn,
            this.Column1,
            this.qUANTITYDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bILLINFOBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Location = new System.Drawing.Point(17, 44);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(959, 389);
            this.dataGridView.TabIndex = 0;
            // 
            // bILLINFOBindingSource
            // 
            this.bILLINFOBindingSource.DataMember = "BILLINFO";
            this.bILLINFOBindingSource.DataSource = this.billInfo;
            // 
            // billInfo
            // 
            this.billInfo.DataSetName = "BillInfo";
            this.billInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bILLINFOTableAdapter
            // 
            this.bILLINFOTableAdapter.ClearBeforeFill = true;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.dataGridView);
            this.customPanel2.Controls.Add(this.customLabel4);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 157F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel2.Location = new System.Drawing.Point(12, 55);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(993, 450);
            this.customPanel2.TabIndex = 72;
            // 
            // customLabel4
            // 
            this.customLabel4.BorderRadius = 1;
            this.customLabel4.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.customLabel4.ForeColor = System.Drawing.Color.White;
            this.customLabel4.GradientAngle = 16F;
            this.customLabel4.Location = new System.Drawing.Point(0, 0);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(993, 44);
            this.customLabel4.TabIndex = 0;
            this.customLabel4.Text = "Chi tiết hóa đơn";
            this.customLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel4.UseCompatibleTextRendering = true;
            // 
            // customPanel7
            // 
            this.customPanel7.BackColor = System.Drawing.Color.White;
            this.customPanel7.BorderRadius = 1;
            this.customPanel7.ForeColor = System.Drawing.Color.Black;
            this.customPanel7.GradientAngle = 181F;
            this.customPanel7.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel7.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel7.Location = new System.Drawing.Point(0, 0);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.Size = new System.Drawing.Size(1041, 38);
            this.customPanel7.TabIndex = 73;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 1;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 117F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel1.Location = new System.Drawing.Point(0, 561);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1041, 38);
            this.customPanel1.TabIndex = 74;
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
            this.BtnExit.Location = new System.Drawing.Point(432, 512);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(132, 42);
            this.BtnExit.TabIndex = 75;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.TextColor = System.Drawing.Color.White;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pROIDDataGridViewTextBoxColumn
            // 
            this.pROIDDataGridViewTextBoxColumn.DataPropertyName = "PRO_ID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.pROIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.pROIDDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.pROIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROIDDataGridViewTextBoxColumn.Name = "pROIDDataGridViewTextBoxColumn";
            this.pROIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PRO_NAME";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // qUANTITYDataGridViewTextBoxColumn
            // 
            this.qUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.qUANTITYDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.qUANTITYDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.qUANTITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qUANTITYDataGridViewTextBoxColumn.Name = "qUANTITYDataGridViewTextBoxColumn";
            this.qUANTITYDataGridViewTextBoxColumn.ReadOnly = true;
            this.qUANTITYDataGridViewTextBoxColumn.Width = 150;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.pRICEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.pRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRICEDataGridViewTextBoxColumn.Width = 180;
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tOTALDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.tOTALDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            this.tOTALDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALDataGridViewTextBoxColumn.Width = 180;
            // 
            // FrmBillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 599);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel7);
            this.Controls.Add(this.customPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBillInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBillInfo";
            this.Load += new System.EventHandler(this.FrmBillInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billInfo)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private BillInfo billInfo;
        private System.Windows.Forms.BindingSource bILLINFOBindingSource;
        private BillInfoTableAdapters.BILLINFOTableAdapter bILLINFOTableAdapter;
        private CustomPanel.CustomPanel customPanel2;
        private CustomLabel customLabel4;
        private CustomPanel.CustomPanel customPanel7;
        private CustomPanel.CustomPanel customPanel1;
        private CustomButton BtnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
    }
}