using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int xn = this.Width / 2;
            int yn = this.Height / 2;
            g.TranslateTransform(xn, yn);
            g.DrawLine(new Pen(Color.Brown, 1.0f), -1000, 0, 1000, 0);
            g.DrawLine(new Pen(Color.Brown, 1.0f), 0, -1000, 0, 1000);
            double x;
            double z;
            double a = 5;
            double b = 20;
            double n = 40;
            for (x = -100; x < n; x += 0.001)

            {
                z = x*x - 18*x + 72;

                g.DrawEllipse(new Pen(Color.Blue, 3.0f), (float)(x * 20), (float)(-z * 20), 1, 1);
            }
        }
    }
}
