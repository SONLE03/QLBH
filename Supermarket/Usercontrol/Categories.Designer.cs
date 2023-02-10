namespace Supermarket
{
    partial class Categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cate = new Supermarket.Cate();
            this.cATEGORYTableAdapter = new Supermarket.CateTableAdapters.CATEGORYTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.change = new System.Windows.Forms.PictureBox();
            this.id_name = new System.Windows.Forms.TextBox();
            this.reload = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.customPanel7 = new CustomPanel.CustomPanel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cate)).BeginInit();
            this.panel2.SuspendLayout();
            this.customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            this.SuspendLayout();
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.cate;
            // 
            // cate
            // 
            this.cate.DataSetName = "Cate";
            this.cate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.customPanel3);
            this.panel2.Controls.Add(this.customPanel2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.customPanel1);
            this.panel2.Controls.Add(this.customPanel7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 810);
            this.panel2.TabIndex = 56;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 1;
            this.customPanel3.Controls.Add(this.dataGridView);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 144F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.customPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel3.Location = new System.Drawing.Point(35, 216);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1129, 520);
            this.customPanel3.TabIndex = 72;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView.DataSource = this.cATEGORYBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Location = new System.Drawing.Point(11, 9);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1105, 501);
            this.dataGridView.TabIndex = 57;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CAT_ID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nguyên liệu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CAT_NAME";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nguyên liệu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 360;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CAT_DESCRIPTION";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn3.HeaderText = "Mô tả";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 445;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 1;
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 135F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel2.Location = new System.Drawing.Point(-4, 756);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1213, 45);
            this.customPanel2.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.catalog;
            this.pictureBox1.Location = new System.Drawing.Point(29, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.change);
            this.customPanel1.Controls.Add(this.id_name);
            this.customPanel1.Controls.Add(this.reload);
            this.customPanel1.Controls.Add(this.pictureBox3);
            this.customPanel1.Controls.Add(this.delete);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 258F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.Violet;
            this.customPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel1.Location = new System.Drawing.Point(25, 111);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1150, 86);
            this.customPanel1.TabIndex = 70;
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.Transparent;
            this.change.Image = global::Supermarket.Properties.Resources.add;
            this.change.Location = new System.Drawing.Point(825, 13);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(65, 62);
            this.change.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.change.TabIndex = 73;
            this.change.TabStop = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            this.change.MouseHover += new System.EventHandler(this.change_MouseHover);
            // 
            // id_name
            // 
            this.id_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_name.ForeColor = System.Drawing.Color.Red;
            this.id_name.Location = new System.Drawing.Point(97, 30);
            this.id_name.Multiline = true;
            this.id_name.Name = "id_name";
            this.id_name.Size = new System.Drawing.Size(415, 30);
            this.id_name.TabIndex = 3;
            this.id_name.TextChanged += new System.EventHandler(this.id_name_TextChanged);
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.Transparent;
            this.reload.Image = global::Supermarket.Properties.Resources.refresh__1_;
            this.reload.Location = new System.Drawing.Point(1039, 12);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(65, 62);
            this.reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reload.TabIndex = 11;
            this.reload.TabStop = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            this.reload.MouseHover += new System.EventHandler(this.reload_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Supermarket.Properties.Resources.search__4_;
            this.pictureBox3.Location = new System.Drawing.Point(18, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.Image = global::Supermarket.Properties.Resources.delete__2_;
            this.delete.Location = new System.Drawing.Point(934, 12);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(65, 62);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 48;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            this.delete.MouseHover += new System.EventHandler(this.delete_MouseHover);
            // 
            // customPanel7
            // 
            this.customPanel7.BackColor = System.Drawing.Color.White;
            this.customPanel7.BorderRadius = 1;
            this.customPanel7.ForeColor = System.Drawing.Color.Black;
            this.customPanel7.GradientAngle = 198F;
            this.customPanel7.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.customPanel7.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(148)))), ((int)(((byte)(28)))));
            this.customPanel7.Location = new System.Drawing.Point(-10, -1);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.Size = new System.Drawing.Size(1215, 45);
            this.customPanel7.TabIndex = 69;
            this.customPanel7.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel7_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(98, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại sản phẩm";
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.panel2);
            this.Name = "Categories";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cate)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn cATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private Cate cate;
        private CateTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox reload;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox id_name;
        private System.Windows.Forms.Label label3;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel7;
        private CustomPanel.CustomPanel customPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private CustomPanel.CustomPanel customPanel3;
        private System.Windows.Forms.PictureBox change;
    }
}
