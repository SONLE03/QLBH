namespace Supermarket
{
    partial class Customers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUS = new Supermarket.CUS();
            this.cUSTOMERTableAdapter = new Supermarket.CUSTableAdapters.CUSTOMERTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customPanel4 = new CustomPanel.CustomPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cUSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.PTBChange = new Supermarket.CustomPictureBox();
            this.PTBReload = new Supermarket.CustomPictureBox();
            this.PTBDel = new Supermarket.CustomPictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.id_name = new System.Windows.Forms.TextBox();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUS)).BeginInit();
            this.panel2.SuspendLayout();
            this.customPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTBChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTBReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTBDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.cUS;
            // 
            // cUS
            // 
            this.cUS.DataSetName = "CUS";
            this.cUS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.customPanel4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.customPanel2);
            this.panel2.Controls.Add(this.customPanel1);
            this.panel2.Controls.Add(this.customPanel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 800);
            this.panel2.TabIndex = 57;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderRadius = 30;
            this.customPanel4.Controls.Add(this.dataGridView);
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 333F;
            this.customPanel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel4.GradientTopColor = System.Drawing.Color.Plum;
            this.customPanel4.Location = new System.Drawing.Point(49, 231);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(1092, 502);
            this.customPanel4.TabIndex = 96;
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
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(137)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(132)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 35;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSIDDataGridViewTextBoxColumn,
            this.cUSNAMEDataGridViewTextBoxColumn,
            this.cUSPHONEDataGridViewTextBoxColumn,
            this.cUSADDRESSDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.cUSTOMERBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(129)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(134)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.Location = new System.Drawing.Point(12, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1069, 478);
            this.dataGridView.TabIndex = 58;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // cUSIDDataGridViewTextBoxColumn
            // 
            this.cUSIDDataGridViewTextBoxColumn.DataPropertyName = "CUS_ID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.cUSIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.cUSIDDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.cUSIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSIDDataGridViewTextBoxColumn.Name = "cUSIDDataGridViewTextBoxColumn";
            this.cUSIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSIDDataGridViewTextBoxColumn.Width = 202;
            // 
            // cUSNAMEDataGridViewTextBoxColumn
            // 
            this.cUSNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUS_NAME";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.cUSNAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cUSNAMEDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.cUSNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSNAMEDataGridViewTextBoxColumn.Name = "cUSNAMEDataGridViewTextBoxColumn";
            this.cUSNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSNAMEDataGridViewTextBoxColumn.Width = 310;
            // 
            // cUSPHONEDataGridViewTextBoxColumn
            // 
            this.cUSPHONEDataGridViewTextBoxColumn.DataPropertyName = "CUS_PHONE";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.cUSPHONEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.cUSPHONEDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.cUSPHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSPHONEDataGridViewTextBoxColumn.Name = "cUSPHONEDataGridViewTextBoxColumn";
            this.cUSPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSPHONEDataGridViewTextBoxColumn.Width = 230;
            // 
            // cUSADDRESSDataGridViewTextBoxColumn
            // 
            this.cUSADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CUS_ADDRESS";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.cUSADDRESSDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.cUSADDRESSDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.cUSADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSADDRESSDataGridViewTextBoxColumn.Name = "cUSADDRESSDataGridViewTextBoxColumn";
            this.cUSADDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSADDRESSDataGridViewTextBoxColumn.Width = 350;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.qualitative_research;
            this.pictureBox1.Location = new System.Drawing.Point(31, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 1;
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 220F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.Plum;
            this.customPanel2.Location = new System.Drawing.Point(0, 762);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1201, 38);
            this.customPanel2.TabIndex = 87;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.PTBChange);
            this.customPanel1.Controls.Add(this.PTBReload);
            this.customPanel1.Controls.Add(this.PTBDel);
            this.customPanel1.Controls.Add(this.pictureBox3);
            this.customPanel1.Controls.Add(this.id_name);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 13F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.customPanel1.GradientTopColor = System.Drawing.Color.LightBlue;
            this.customPanel1.Location = new System.Drawing.Point(49, 109);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1092, 92);
            this.customPanel1.TabIndex = 86;
            // 
            // PTBChange
            // 
            this.PTBChange.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PTBChange.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PTBChange.BorderColor2 = System.Drawing.Color.HotPink;
            this.PTBChange.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PTBChange.BorderSize = 3;
            this.PTBChange.GradientAngle = 50F;
            this.PTBChange.Image = global::Supermarket.Properties.Resources.turnover;
            this.PTBChange.Location = new System.Drawing.Point(787, 13);
            this.PTBChange.Name = "PTBChange";
            this.PTBChange.Size = new System.Drawing.Size(67, 67);
            this.PTBChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PTBChange.TabIndex = 96;
            this.PTBChange.TabStop = false;
            this.PTBChange.Click += new System.EventHandler(this.PTBChange_Click);
            this.PTBChange.MouseHover += new System.EventHandler(this.change_MouseHover);
            // 
            // PTBReload
            // 
            this.PTBReload.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PTBReload.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PTBReload.BorderColor2 = System.Drawing.Color.HotPink;
            this.PTBReload.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PTBReload.BorderSize = 3;
            this.PTBReload.GradientAngle = 50F;
            this.PTBReload.Image = global::Supermarket.Properties.Resources.refresh__1_;
            this.PTBReload.Location = new System.Drawing.Point(988, 13);
            this.PTBReload.Name = "PTBReload";
            this.PTBReload.Size = new System.Drawing.Size(67, 67);
            this.PTBReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PTBReload.TabIndex = 88;
            this.PTBReload.TabStop = false;
            this.PTBReload.Click += new System.EventHandler(this.PTBReload_Click);
            this.PTBReload.MouseHover += new System.EventHandler(this.reload_MouseHover);
            // 
            // PTBDel
            // 
            this.PTBDel.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PTBDel.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PTBDel.BorderColor2 = System.Drawing.Color.HotPink;
            this.PTBDel.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PTBDel.BorderSize = 3;
            this.PTBDel.GradientAngle = 50F;
            this.PTBDel.Image = global::Supermarket.Properties.Resources.delete__2_;
            this.PTBDel.Location = new System.Drawing.Point(887, 13);
            this.PTBDel.Name = "PTBDel";
            this.PTBDel.Size = new System.Drawing.Size(67, 67);
            this.PTBDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PTBDel.TabIndex = 87;
            this.PTBDel.TabStop = false;
            this.PTBDel.Click += new System.EventHandler(this.PTBDel_Click);
            this.PTBDel.MouseHover += new System.EventHandler(this.delete_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Supermarket.Properties.Resources.search__1_;
            this.pictureBox3.Location = new System.Drawing.Point(23, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // id_name
            // 
            this.id_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_name.Location = new System.Drawing.Point(115, 31);
            this.id_name.Multiline = true;
            this.id_name.Name = "id_name";
            this.id_name.Size = new System.Drawing.Size(415, 34);
            this.id_name.TabIndex = 3;
            this.id_name.TextChanged += new System.EventHandler(this.id_name_TextChanged);
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 3;
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 116F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.Plum;
            this.customPanel3.Location = new System.Drawing.Point(-3, -3);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1213, 44);
            this.customPanel3.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(93, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khách hàng";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.panel2);
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTBChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTBReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTBDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private CUS cUS;
        private CUSTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox id_name;
        private System.Windows.Forms.Label label3;
        private CustomPanel.CustomPanel customPanel3;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPictureBox PTBDel;
        private CustomPictureBox PTBReload;
        private CustomPanel.CustomPanel customPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSADDRESSDataGridViewTextBoxColumn;
        private CustomPictureBox PTBChange;
        private CustomPanel.CustomPanel customPanel4;
    }
}
