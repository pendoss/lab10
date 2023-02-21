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
    public partial class Form6 : Form
    {   
        
        private void click(Button button)
        {   
            button.BackColor = Color.Black;
            button.ForeColor = Color.White;
            button.FlatAppearance.BorderColor = Color.Black;
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_Paint(object sender, PaintEventArgs e)
        {
            Graphics R = e.Graphics;
            int xn = this.Height/2;
            int yn = this.Width/2;
            
           /* R.TranslateTransform(xn, yn);
            R.DrawLine(new Pen(Color.Brown, 1.0f), -1000, 0, 1000, 0);
            R.DrawLine(new Pen(Color.Brown, 1.0f), 0, -1000, 0, 1000);
           *//* R.DrawEllipse(new Pen(Color.Blue, 3.0f), 50, 50, 400, -400);*//*
            R.FillEllipse(new SolidBrush(Color.FromArgb(255,32, 69, 26)), 50, 50, 400, -400);*/

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
      
    }
}
