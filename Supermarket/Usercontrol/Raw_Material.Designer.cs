namespace Supermarket
{
    partial class Raw_Material
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rAWMATERIALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rM = new Supermarket.RM();
            this.rAW_MATERIALTableAdapter = new Supermarket.RMTableAdapters.RAW_MATERIALTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customPanel4 = new CustomPanel.CustomPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rAWIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAWDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAWQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAWTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.change = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.reload = new System.Windows.Forms.PictureBox();
            this.id_name = new System.Windows.Forms.TextBox();
            this.customPanel3 = new CustomPanel.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)(this.rAWMATERIALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rM)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).BeginInit();
            this.SuspendLayout();
            // 
            // rAWMATERIALBindingSource
            // 
            this.rAWMATERIALBindingSource.DataMember = "RAW_MATERIAL";
            this.rAWMATERIALBindingSource.DataSource = this.rM;
            // 
            // rM
            // 
            this.rM.DataSetName = "RM";
            this.rM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rAW_MATERIALTableAdapter
            // 
            this.rAW_MATERIALTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.customPanel4);
            this.panel2.Controls.Add(this.customPanel2);
            this.panel2.Controls.Add(this.customPanel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.customPanel3);
            this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 800);
            this.panel2.TabIndex = 57;
            this.panel2.Click += new System.EventHandler(this.change_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.credit;
            this.pictureBox1.Location = new System.Drawing.Point(32, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(100, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phiếu hàng";
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderRadius = 30;
            this.customPanel4.Controls.Add(this.dataGridView);
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 137F;
            this.customPanel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel4.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel4.Location = new System.Drawing.Point(25, 242);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(1150, 479);
            this.customPanel4.TabIndex = 61;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(132)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rAWIDDataGridViewTextBoxColumn,
            this.rAWDATEDataGridViewTextBoxColumn,
            this.rAWQUANTITYDataGridViewTextBoxColumn,
            this.rAWTOTALDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView.DataSource = this.rAWMATERIALBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(134)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Location = new System.Drawing.Point(12, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1126, 453);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // rAWIDDataGridViewTextBoxColumn
            // 
            this.rAWIDDataGridViewTextBoxColumn.DataPropertyName = "RAW_ID";
            this.rAWIDDataGridViewTextBoxColumn.HeaderText = "Mã phiếu hàng";
            this.rAWIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rAWIDDataGridViewTextBoxColumn.Name = "rAWIDDataGridViewTextBoxColumn";
            this.rAWIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAWIDDataGridViewTextBoxColumn.Width = 240;
            // 
            // rAWDATEDataGridViewTextBoxColumn
            // 
            this.rAWDATEDataGridViewTextBoxColumn.DataPropertyName = "RAW_DATE";
            this.rAWDATEDataGridViewTextBoxColumn.HeaderText = "Ngày lập phiếu";
            this.rAWDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rAWDATEDataGridViewTextBoxColumn.Name = "rAWDATEDataGridViewTextBoxColumn";
            this.rAWDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAWDATEDataGridViewTextBoxColumn.Width = 215;
            // 
            // rAWQUANTITYDataGridViewTextBoxColumn
            // 
            this.rAWQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "RAW_QUANTITY";
            this.rAWQUANTITYDataGridViewTextBoxColumn.HeaderText = "Số lượng ";
            this.rAWQUANTITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rAWQUANTITYDataGridViewTextBoxColumn.Name = "rAWQUANTITYDataGridViewTextBoxColumn";
            this.rAWQUANTITYDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAWQUANTITYDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAWTOTALDataGridViewTextBoxColumn
            // 
            this.rAWTOTALDataGridViewTextBoxColumn.DataPropertyName = "RAW_TOTAL";
            this.rAWTOTALDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.rAWTOTALDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rAWTOTALDataGridViewTextBoxColumn.Name = "rAWTOTALDataGridViewTextBoxColumn";
            this.rAWTOTALDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAWTOTALDataGridViewTextBoxColumn.Width = 250;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "S_Name";
            this.Column1.HeaderText = "Nhà cung cấp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 270;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 1;
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 308F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel2.Location = new System.Drawing.Point(1, 761);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1199, 39);
            this.customPanel2.TabIndex = 60;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.change);
            this.customPanel1.Controls.Add(this.pictureBox3);
            this.customPanel1.Controls.Add(this.delete);
            this.customPanel1.Controls.Add(this.reload);
            this.customPanel1.Controls.Add(this.id_name);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 89F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel1.Location = new System.Drawing.Point(25, 119);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1150, 88);
            this.customPanel1.TabIndex = 60;
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.Transparent;
            this.change.Image = global::Supermarket.Properties.Resources.bill1;
            this.change.Location = new System.Drawing.Point(788, 13);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(65, 62);
            this.change.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.change.TabIndex = 75;
            this.change.TabStop = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            this.change.MouseHover += new System.EventHandler(this.change_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Supermarket.Properties.Resources.search__4_;
            this.pictureBox3.Location = new System.Drawing.Point(21, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.Image = global::Supermarket.Properties.Resources.delete__2_;
            this.delete.Location = new System.Drawing.Point(910, 13);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(65, 62);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 48;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            this.delete.MouseHover += new System.EventHandler(this.delete_MouseHover);
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.Transparent;
            this.reload.Image = global::Supermarket.Properties.Resources.refresh1;
            this.reload.Location = new System.Drawing.Point(1033, 13);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(65, 62);
            this.reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reload.TabIndex = 11;
            this.reload.TabStop = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            this.reload.MouseHover += new System.EventHandler(this.reload_MouseHover);
            // 
            // id_name
            // 
            this.id_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_name.Location = new System.Drawing.Point(100, 29);
            this.id_name.Multiline = true;
            this.id_name.Name = "id_name";
            this.id_name.Size = new System.Drawing.Size(415, 30);
            this.id_name.TabIndex = 3;
            this.id_name.TextChanged += new System.EventHandler(this.id_name_TextChanged);
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 1;
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 53F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel3.Location = new System.Drawing.Point(1, -1);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1199, 39);
            this.customPanel3.TabIndex = 59;
            // 
            // Raw_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.panel2);
            this.Name = "Raw_Material";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Raw_Material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rAWMATERIALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource rAWMATERIALBindingSource;
        private RM rM;
        private RMTableAdapters.RAW_MATERIALTableAdapter rAW_MATERIALTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox reload;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox id_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomPanel.CustomPanel customPanel4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAWIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAWDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAWQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAWTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private CustomPanel.CustomPanel customPanel2;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel3;
        private System.Windows.Forms.PictureBox change;
    }
}
