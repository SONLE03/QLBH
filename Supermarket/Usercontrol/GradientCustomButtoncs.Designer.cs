using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Supermarket.Usercontrol
{
    [DefaultEvent("Click")]
    public partial class GradientCustomButtoncs : UserControl
    {
        int w = 20;
        Color color1 = Color.BlueViolet, color2 = Color.Orange;
        private float gradientAngle = 90;
        Timer timer = new Timer();


        //public GradientCustomButtoncs()
        //{
        //    DoubleBuffered = true;
        //    timer.Interval = 30;
        //    timer.Start();
        //    timer.Tick += (s, e) => { GradientAngle = gradientAngle % 360 + 1; };
        //}
        public int BorderRadius
        {
            get { return w; }
            set { w = value; Invalidate(); }
        }
        public Color Color1
        {
            get { return color1; }
            set { color1 = value; Invalidate(); }
        }
        public Color Color2
        {
            get { return color2; }
            set { color2 = value; Invalidate(); }
        }
        public float GradientAngle
        { get => gradientAngle; set { gradientAngle = value; this.Invalidate(); } }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GradientCustomButtoncs
            // 
            this.Name = "GradientCustomButtoncs";
            this.Size = new System.Drawing.Size(179, 150);
            this.ResumeLayout(false);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(new Rectangle(0, 0, w, w), 180, 100);
            graphicsPath.AddArc(new RectangleF(Width - w, 0, w, w), -90, 90);
            graphicsPath.AddArc(new RectangleF(Width - w, Height - w, w, w), 0, 90);
            graphicsPath.AddArc(new RectangleF(0, Height - w, w, w), 90, 90);

            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, color1, color2, gradientAngle), graphicsPath);
            base.OnPaint(e);
        }

    }
}
