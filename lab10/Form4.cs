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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int xn = this.Width / 2;
            int yn = this.Height / 2;
            g.TranslateTransform(xn, yn);
            g.DrawLine(new Pen(Color.Brown, 1.0f), -3000, 0, 3000, 0);
            g.DrawLine(new Pen(Color.Brown, 1.0f), 0, -3000, 0, 3000);
            double x;
            double y;
            double a = 1;
            double b = (4) * Math.PI;
            double n = 50;
            for (x = -100; x < n; x+=0.001)

            {   
                y = (3* Math.Sin(x))/x;
                    
                g.DrawEllipse(new Pen(Color.Blue, 3.0f), (float)(x*20), (float)(-y*20), 1, 1);
            }
        }
    }
}
