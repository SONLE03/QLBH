namespace Supermarket.Usercontrol
{
    partial class UcHome
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
            this.home = new CustomPanel.CustomPanel();
            this.customPanel2 = new CustomPanel.CustomPanel();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1 = new CustomPanel.CustomPanel();
            this.customPictureBox1 = new Supermarket.CustomPictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.DarkViolet;
            this.home.BorderRadius = 30;
            this.home.Controls.Add(this.customPanel2);
            this.home.Controls.Add(this.date);
            this.home.Controls.Add(this.time);
            this.home.Controls.Add(this.label1);
            this.home.Controls.Add(this.customPanel1);
            this.home.Controls.Add(this.customPictureBox1);
            this.home.ForeColor = System.Drawing.Color.Black;
            this.home.GradientAngle = 217F;
            this.home.GradientBottomColor = System.Drawing.Color.SkyBlue;
            this.home.GradientTopColor = System.Drawing.Color.Violet;
            this.home.Location = new System.Drawing.Point(-19, -9);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(1231, 809);
            this.home.TabIndex = 0;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 10;
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 332F;
            this.customPanel2.GradientBottomColor = System.Drawing.Color.SkyBlue;
            this.customPanel2.GradientTopColor = System.Drawing.Color.DarkViolet;
            this.customPanel2.Location = new System.Drawing.Point(390, 474);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(498, 10);
            this.customPanel2.TabIndex = 2;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(501, 487);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(131, 54);
            this.date.TabIndex = 4;
            this.date.Text = "label3";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(493, 409);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(155, 62);
            this.time.TabIndex = 3;
            this.time.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(424, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 89);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Bán Hàng";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 161F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.SkyBlue;
            this.customPanel1.GradientTopColor = System.Drawing.Color.DarkViolet;
            this.customPanel1.Location = new System.Drawing.Point(408, 287);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(646, 19);
            this.customPanel1.TabIndex = 1;
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.customPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.customPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.customPictureBox1.BorderSize = 2;
            this.customPictureBox1.GradientAngle = 50F;
            this.customPictureBox1.Image = global::Supermarket.Properties.Resources.cash_register;
            this.customPictureBox1.Location = new System.Drawing.Point(174, 143);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(229, 229);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customPictureBox1.TabIndex = 0;
            this.customPictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // UcHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.home);
            this.Name = "UcHome";
            this.Size = new System.Drawing.Size(1200, 800);
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel.CustomPanel home;
        private System.Windows.Forms.Label label1;
        private CustomPanel.CustomPanel customPanel1;
        private CustomPictureBox customPictureBox1;
        private CustomPanel.CustomPanel customPanel2;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer;
    }
}
