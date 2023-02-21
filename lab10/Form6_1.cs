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
    public partial class Form6_1 : Form
    {
        Form8 form8;
        
        public bool c = false;
        public int res;
        public int points_1 = 8, points_2 = 8;
        public int[] bet1 = {2,4,6,8,10,12,14,16,18};
        public Form6_1()
        {
            InitializeComponent();
        }

        private void Wait(double seconds)
        {
            int ticks = System.Environment.TickCount + (int)Math.Round(seconds * 1000.0);
            while (System.Environment.TickCount < ticks)
            {
                Application.DoEvents();
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                c = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Hide();
            button10.Show();
            label4.Show();
            label5.Show();
            
        }

        private void Form6_1_Load(object sender, EventArgs e)
        {
            score();

        }

        private void score()
        {
            Form8 form8 = new Form8();
            if(points_1 == 0 || points_2 == 0)
            {
                form8.Show();
                this.Close();

            }
            label2.Text = $"Очки - {points_1}";
            label5.Text = $"Очки - {points_2}";
        }

        private bool check()
        {             
            return c; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Hide();
            button9.Show();
            label4.Hide();
            label5.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int k = int.Parse(textBox1.Text);


        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor=Color.Black;
            if(c == false)
            {
                points_1 -= 1;
                c = true;
            }
            else
            {
                points_2 -=1;
                c = false;
            }
            score();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                points_1 -= 1;
                c = true;
            }
            else
            {
                points_2 -= 1;
                c = false;
            }
            score();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                points_1 -= 1;
                c = true;
            }
            else
            {
                points_2 -= 1;
                c = false;
            }
            score();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                points_1 -= 1;
                c = true;
            }
            else
            {
                points_2 -= 1;
                c = false;
            }
            score();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                points_1 -= 1;
                c = true;
            }
            else
            {
                points_2 -= 1;
                c = false;
            }
            score();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                points_1 -= 1;
                c = true;
            }
            else
            {
                points_2 -= 1;
                c = false;
            }
            score();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            res = rnd.Next(0, 36);
            label6.Text = res.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                points_1 -= 1;
                c = true;
            }
            else
            {
                points_2 -= 1;
                c = false;
            }
            score();
        }

       
    }
}
