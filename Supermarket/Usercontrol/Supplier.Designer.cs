namespace Supermarket
{
    partial class Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            this.sUPPLIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sup = new Supermarket.Sup();
            this.sUPPLIERTableAdapter = new Supermarket.SupTableAdapters.SUPPLIERTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.change = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.reload = new System.Windows.Forms.PictureBox();
            this.id_name = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.customPanel7 = new CustomPanel.CustomPanel();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sup)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            this.SuspendLayout();
            // 
            // sUPPLIERBindingSource
            // 
            this.sUPPLIERBindingSource.DataMember = "SUPPLIER";
            this.sUPPLIERBindingSource.DataSource = this.sup;
            // 
            // sup
            // 
            this.sup.DataSetName = "Sup";
            this.sup.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUPPLIERTableAdapter
            // 
            this.sUPPLIERTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.customPanel3);
            this.panel2.Controls.Add(this.customPanel2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.customPanel1);
            this.panel2.Controls.Add(this.customPanel7);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 800);
            this.panel2.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.inventory__2_;
            this.pictureBox1.Location = new System.Drawing.Point(28, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 30;
            this.customPanel3.Controls.Add(this.dataGridView);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 342F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.customPanel3.GradientTopColor = System.Drawing.Color.SkyBlue;
            this.customPanel3.Location = new System.Drawing.Point(25, 225);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1150, 504);
            this.customPanel3.TabIndex = 69;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(137)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(132)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sNAMEDataGridViewTextBoxColumn,
            this.sADDRESSDataGridViewTextBoxColumn,
            this.sPHONEDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.sUPPLIERBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(129)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(134)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView.Location = new System.Drawing.Point(14, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1123, 479);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "S_ID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "Mã nhà cung cấp";
            this.sIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Width = 230;
            // 
            // sNAMEDataGridViewTextBoxColumn
            // 
            this.sNAMEDataGridViewTextBoxColumn.DataPropertyName = "S_NAME";
            this.sNAMEDataGridViewTextBoxColumn.HeaderText = "Tên nhà cung cấp";
            this.sNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sNAMEDataGridViewTextBoxColumn.Name = "sNAMEDataGridViewTextBoxColumn";
            this.sNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNAMEDataGridViewTextBoxColumn.Width = 310;
            // 
            // sADDRESSDataGridViewTextBoxColumn
            // 
            this.sADDRESSDataGridViewTextBoxColumn.DataPropertyName = "S_ADDRESS";
            this.sADDRESSDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.sADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sADDRESSDataGridViewTextBoxColumn.Name = "sADDRESSDataGridViewTextBoxColumn";
            this.sADDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sADDRESSDataGridViewTextBoxColumn.Width = 370;
            // 
            // sPHONEDataGridViewTextBoxColumn
            // 
            this.sPHONEDataGridViewTextBoxColumn.DataPropertyName = "S_PHONE";
            this.sPHONEDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sPHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sPHONEDataGridViewTextBoxColumn.Name = "sPHONEDataGridViewTextBoxColumn";
            this.sPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPHONEDataGridViewTextBoxColumn.Width = 206;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.change);
            this.customPanel2.Controls.Add(this.pictureBox3);
            this.customPanel2.Controls.Add(this.reload);
            this.customPanel2.Controls.Add(this.id_name);
            this.customPanel2.Controls.Add(this.delete);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 18F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.customPanel2.GradientTopColor = System.Drawing.Color.SkyBlue;
            this.customPanel2.Location = new System.Drawing.Point(25, 117);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1150, 85);
            this.customPanel2.TabIndex = 68;
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.Transparent;
            this.change.Image = ((System.Drawing.Image)(resources.GetObject("change.Image")));
            this.change.Location = new System.Drawing.Point(803, 11);
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
            this.pictureBox3.Image = global::Supermarket.Properties.Resources.search__5_;
            this.pictureBox3.Location = new System.Drawing.Point(25, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.Transparent;
            this.reload.Image = global::Supermarket.Properties.Resources.refresh__1_;
            this.reload.Location = new System.Drawing.Point(1024, 11);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(63, 62);
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
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.Image = global::Supermarket.Properties.Resources.delete__2_;
            this.delete.Location = new System.Drawing.Point(912, 12);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(65, 62);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 48;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            this.delete.MouseHover += new System.EventHandler(this.delete_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(95, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhà cung cấp";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 1;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 228F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.customPanel1.GradientTopColor = System.Drawing.Color.SkyBlue;
            this.customPanel1.Location = new System.Drawing.Point(1, 755);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1200, 45);
            this.customPanel1.TabIndex = 68;
            // 
            // customPanel7
            // 
            this.customPanel7.BackColor = System.Drawing.Color.White;
            this.customPanel7.BorderRadius = 1;
            this.customPanel7.ForeColor = System.Drawing.Color.Black;
            this.customPanel7.GradientAngle = 33F;
            this.customPanel7.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.customPanel7.GradientTopColor = System.Drawing.Color.SkyBlue;
            this.customPanel7.Location = new System.Drawing.Point(1, 0);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.Size = new System.Drawing.Size(1200, 45);
            this.customPanel7.TabIndex = 67;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.panel2);
            this.Name = "Supplier";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sup)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sUPPLIERBindingSource;
        private Sup sup;
        private SupTableAdapters.SUPPLIERTableAdapter sUPPLIERTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox reload;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox id_name;
        private System.Windows.Forms.Label label3;
        private CustomPanel.CustomPanel customPanel2;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomPanel.CustomPanel customPanel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox change;
    }
}
