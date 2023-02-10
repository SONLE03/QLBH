namespace Supermarket
{
    partial class FrmRawInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rINAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rITOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAWINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawInfo = new Supermarket.RawInfo();
            this.rAWINFOTableAdapter = new Supermarket.RawInfoTableAdapters.RAWINFOTableAdapter();
            this.customPanel7 = new CustomPanel.CustomPanel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.customLabel4 = new Supermarket.CustomLabel();
            this.BtnExit = new Supermarket.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAWINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawInfo)).BeginInit();
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
            this.rIIDDataGridViewTextBoxColumn,
            this.rINAMEDataGridViewTextBoxColumn,
            this.rIQUANTITYDataGridViewTextBoxColumn,
            this.rIPRICEDataGridViewTextBoxColumn,
            this.rITOTALDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.rAWINFOBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.GridColor = System.Drawing.Color.Snow;
            this.dataGridView.Location = new System.Drawing.Point(18, 47);
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
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(960, 400);
            this.dataGridView.TabIndex = 0;
            // 
            // rIIDDataGridViewTextBoxColumn
            // 
            this.rIIDDataGridViewTextBoxColumn.DataPropertyName = "RI_ID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rIIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.rIIDDataGridViewTextBoxColumn.HeaderText = "STT";
            this.rIIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rIIDDataGridViewTextBoxColumn.Name = "rIIDDataGridViewTextBoxColumn";
            this.rIIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rIIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rINAMEDataGridViewTextBoxColumn
            // 
            this.rINAMEDataGridViewTextBoxColumn.DataPropertyName = "RI_NAME";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rINAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.rINAMEDataGridViewTextBoxColumn.HeaderText = "Tên nguyên liệu";
            this.rINAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rINAMEDataGridViewTextBoxColumn.Name = "rINAMEDataGridViewTextBoxColumn";
            this.rINAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rINAMEDataGridViewTextBoxColumn.Width = 250;
            // 
            // rIQUANTITYDataGridViewTextBoxColumn
            // 
            this.rIQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "RI_QUANTITY";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rIQUANTITYDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.rIQUANTITYDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.rIQUANTITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rIQUANTITYDataGridViewTextBoxColumn.Name = "rIQUANTITYDataGridViewTextBoxColumn";
            this.rIQUANTITYDataGridViewTextBoxColumn.ReadOnly = true;
            this.rIQUANTITYDataGridViewTextBoxColumn.Width = 125;
            // 
            // rIPRICEDataGridViewTextBoxColumn
            // 
            this.rIPRICEDataGridViewTextBoxColumn.DataPropertyName = "RI_PRICE";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rIPRICEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.rIPRICEDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.rIPRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rIPRICEDataGridViewTextBoxColumn.Name = "rIPRICEDataGridViewTextBoxColumn";
            this.rIPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rIPRICEDataGridViewTextBoxColumn.Width = 200;
            // 
            // rITOTALDataGridViewTextBoxColumn
            // 
            this.rITOTALDataGridViewTextBoxColumn.DataPropertyName = "RI_TOTAL";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rITOTALDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.rITOTALDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.rITOTALDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rITOTALDataGridViewTextBoxColumn.Name = "rITOTALDataGridViewTextBoxColumn";
            this.rITOTALDataGridViewTextBoxColumn.ReadOnly = true;
            this.rITOTALDataGridViewTextBoxColumn.Width = 206;
            // 
            // rAWINFOBindingSource
            // 
            this.rAWINFOBindingSource.DataMember = "RAWINFO";
            this.rAWINFOBindingSource.DataSource = this.rawInfo;
            // 
            // rawInfo
            // 
            this.rawInfo.DataSetName = "RawInfo";
            this.rawInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rAWINFOTableAdapter
            // 
            this.rAWINFOTableAdapter.ClearBeforeFill = true;
            // 
            // customPanel7
            // 
            this.customPanel7.BackColor = System.Drawing.Color.White;
            this.customPanel7.BorderRadius = 1;
            this.customPanel7.ForeColor = System.Drawing.Color.Black;
            this.customPanel7.GradientAngle = 59F;
            this.customPanel7.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel7.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel7.Location = new System.Drawing.Point(0, 0);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.Size = new System.Drawing.Size(1018, 45);
            this.customPanel7.TabIndex = 69;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 1;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 316F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel1.Location = new System.Drawing.Point(0, 572);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1018, 45);
            this.customPanel1.TabIndex = 70;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.customLabel4);
            this.customPanel2.Controls.Add(this.dataGridView);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 93F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.DeepPink;
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel2.Location = new System.Drawing.Point(12, 56);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(993, 461);
            this.customPanel2.TabIndex = 71;
            // 
            // customLabel4
            // 
            this.customLabel4.BorderRadius = 1;
            this.customLabel4.Color1 = System.Drawing.Color.DeepPink;
            this.customLabel4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.customLabel4.ForeColor = System.Drawing.Color.White;
            this.customLabel4.GradientAngle = 201F;
            this.customLabel4.Location = new System.Drawing.Point(0, 0);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(993, 44);
            this.customLabel4.TabIndex = 0;
            this.customLabel4.Text = "Chi tiết phiếu hàng";
            this.customLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customLabel4.UseCompatibleTextRendering = true;
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
            this.BtnExit.Location = new System.Drawing.Point(429, 523);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(132, 43);
            this.BtnExit.TabIndex = 74;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.TextColor = System.Drawing.Color.White;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmRawInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 617);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRawInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRawInfo";
            this.Load += new System.EventHandler(this.FrmRawInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAWINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawInfo)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private RawInfo rawInfo;
        private System.Windows.Forms.BindingSource rAWINFOBindingSource;
        private RawInfoTableAdapters.RAWINFOTableAdapter rAWINFOTableAdapter;
        private CustomPanel.CustomPanel customPanel7;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel2;
        private CustomLabel customLabel4;
        private CustomButton BtnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rINAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rITOTALDataGridViewTextBoxColumn;
    }
}