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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            string[] s = text.Split(' ');
            int m = int.Parse(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
                if (int.Parse(s[i]) > m)
                {
                    m = int.Parse(s[i]);
                }
            }

            textBox1.AppendText("Максимальное значение - " + m);
        }
    }
}
