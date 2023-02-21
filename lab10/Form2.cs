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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            string[] s = text.Split(' ');
            for (int i = 0; i < s.Length; i++)
            {
                richTextBox2.AppendText("" + int.Parse(s[i]) * 2 + "\n");
            }
        }

        
    }
}
