namespace Supermarket
{
    partial class Sellers
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
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eM = new Supermarket.EM();
            this.eMPLOYEETableAdapter = new Supermarket.EMTableAdapters.EMPLOYEETableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customPanel4 = new CustomPanel.CustomPanel();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.id_name = new System.Windows.Forms.TextBox();
            this.reload = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eM)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.customPanel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.change)).BeginInit();
            this.SuspendLayout();
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.eM;
            // 
            // eM
            // 
            this.eM.DataSetName = "EM";
            this.eM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.customPanel4);
            this.panel1.Controls.Add(this.customPanel2);
            this.panel1.Controls.Add(this.customPanel1);
            this.panel1.Controls.Add(this.customPanel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 800);
            this.panel1.TabIndex = 58;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.identification_card1;
            this.pictureBox2.Location = new System.Drawing.Point(26, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderRadius = 1;
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 47F;
            this.customPanel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel4.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel4.Location = new System.Drawing.Point(0, 761);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(1207, 39);
            this.customPanel4.TabIndex = 63;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.flowLayoutPanel);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 128F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel2.Location = new System.Drawing.Point(24, 213);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1149, 530);
            this.customPanel2.TabIndex = 62;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel.Location = new System.Drawing.Point(11, 10);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1127, 511);
            this.flowLayoutPanel.TabIndex = 59;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.change);
            this.customPanel1.Controls.Add(this.id_name);
            this.customPanel1.Controls.Add(this.reload);
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 14F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel1.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel1.Location = new System.Drawing.Point(24, 114);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1150, 84);
            this.customPanel1.TabIndex = 61;
            // 
            // id_name
            // 
            this.id_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_name.Location = new System.Drawing.Point(119, 29);
            this.id_name.Multiline = true;
            this.id_name.Name = "id_name";
            this.id_name.Size = new System.Drawing.Size(415, 30);
            this.id_name.TabIndex = 3;
            this.id_name.TextChanged += new System.EventHandler(this.id_name_TextChanged);
            // 
            // reload
            // 
            this.reload.Image = global::Supermarket.Properties.Resources.refresh1;
            this.reload.Location = new System.Drawing.Point(1044, 11);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(65, 62);
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
            this.pictureBox1.Location = new System.Drawing.Point(25, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 1;
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 187F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel3.Location = new System.Drawing.Point(0, -5);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1207, 47);
            this.customPanel3.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(97, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân viên";
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.Transparent;
            this.change.Image = global::Supermarket.Properties.Resources.turnover2;
            this.change.Location = new System.Drawing.Point(925, 11);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(65, 62);
            this.change.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.change.TabIndex = 76;
            this.change.TabStop = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            this.change.MouseHover += new System.EventHandler(this.change_MouseHover);
            // 
            // Sellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.panel1);
            this.Name = "Sellers";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Sellers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.change)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private EM eM;
        private EMTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox reload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox id_name;
        private System.Windows.Forms.Label label3;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomPanel.CustomPanel customPanel4;
        private CustomPanel.CustomPanel customPanel2;
        private System.Windows.Forms.PictureBox change;
    }
}
