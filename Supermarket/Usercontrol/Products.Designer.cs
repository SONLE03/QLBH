namespace Supermarket
{
    partial class Products
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pRODUCTTableAdapter = new Supermarket.ProTableAdapters.PRODUCTTableAdapter();
            this.id_name = new System.Windows.Forms.TextBox();
            this.pro = new Supermarket.Pro();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.customPanel4 = new CustomPanel.CustomPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.change = new System.Windows.Forms.PictureBox();
            this.reload = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customPanel3 = new CustomPanel.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.customPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.SeaShell;
            this.flowLayoutPanel.Location = new System.Drawing.Point(11, 11);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1118, 510);
            this.flowLayoutPanel.TabIndex = 54;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // id_name
            // 
            this.id_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_name.Location = new System.Drawing.Point(133, 20);
            this.id_name.Multiline = true;
            this.id_name.Name = "id_name";
            this.id_name.Size = new System.Drawing.Size(415, 30);
            this.id_name.TabIndex = 3;
            this.id_name.TextChanged += new System.EventHandler(this.id_name_TextChanged);
            // 
            // pro
            // 
            this.pro.DataSetName = "Pro";
            this.pro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.pro;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.customPanel4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.customPanel2);
            this.panel3.Controls.Add(this.customPanel1);
            this.panel3.Controls.Add(this.customPanel3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1203, 800);
            this.panel3.TabIndex = 55;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.White;
            this.customPanel4.BorderRadius = 30;
            this.customPanel4.Controls.Add(this.flowLayoutPanel);
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 316F;
            this.customPanel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel4.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel4.Location = new System.Drawing.Point(29, 202);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(1141, 530);
            this.customPanel4.TabIndex = 74;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.delivery_box;
            this.pictureBox2.Location = new System.Drawing.Point(24, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 1;
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 76F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel2.Location = new System.Drawing.Point(1, 761);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1201, 39);
            this.customPanel2.TabIndex = 57;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 20;
            this.customPanel1.Controls.Add(this.change);
            this.customPanel1.Controls.Add(this.reload);
            this.customPanel1.Controls.Add(this.id_name);
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 207F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.BlueViolet;
            this.customPanel1.GradientTopColor = System.Drawing.Color.SkyBlue;
            this.customPanel1.Location = new System.Drawing.Point(24, 103);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1150, 70);
            this.customPanel1.TabIndex = 56;
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.Transparent;
            this.change.Image = global::Supermarket.Properties.Resources.productions;
            this.change.Location = new System.Drawing.Point(921, 5);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(65, 62);
            this.change.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.change.TabIndex = 74;
            this.change.TabStop = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            this.change.MouseHover += new System.EventHandler(this.change_MouseHover);
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.reload.Image = global::Supermarket.Properties.Resources.refresh1;
            this.reload.Location = new System.Drawing.Point(1029, 10);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(57, 48);
            this.reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reload.TabIndex = 11;
            this.reload.TabStop = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            this.reload.MouseHover += new System.EventHandler(this.reload_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.server;
            this.pictureBox1.Location = new System.Drawing.Point(42, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 45);
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
            this.customPanel3.GradientAngle = 246F;
            this.customPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.Thistle;
            this.customPanel3.Location = new System.Drawing.Point(0, 0);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1201, 39);
            this.customPanel3.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(13)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(83, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sản phẩm";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.panel3);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private ProTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.TextBox id_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox reload;
        private Pro pro;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPanel.CustomPanel customPanel3;
        private CustomPanel.CustomPanel customPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomPanel.CustomPanel customPanel4;
        private System.Windows.Forms.PictureBox change;
    }
}
