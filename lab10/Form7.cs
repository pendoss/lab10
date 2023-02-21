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
    public partial class Form7 : Form
    {
        Form1 aob;
        public Form7(Form1 form1)
        {
            InitializeComponent();
            aob = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Close();
            Form1 frm = new Form1();
            frm.Close();

        }
    }
}
