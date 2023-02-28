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
        public int player_1_balance = 8;
        public int player_2_balance = 8;
        public int player_1_win = 0, player_2_win = 0;
        public string score = "Очки:";
        public int player_1_bet_value = 0, player_2_bet_value = 0;
        public bool player_1_bet = false, player_2_bet = false;
        public bool order = false; //false - player_1, true - player_2
        public string player_1_value, player_2_value = "2222222";
        public int result;
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
            
          

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void number_bet_Click(object sender, EventArgs e)
        {
            if (order == false && player_1_bet == false)
            {
                player_1_value = this.Text;
                if (player_1_balance > 0)
                {
                    player_1_balance -= 1;
                    player_1_bet_value += 1;
                }

                label2.Text = score + player_1_balance;
                order = true;
                player_1_bet = true;
            }
            else if (order == true && player_2_bet == false)
            {
                player_2_value = this.Text;
                if (player_2_balance > 0)
                {
                    player_2_balance -= 1;
                }

                label5.Text = score + player_2_balance;
                order = false;
                player_2_bet = true;
            }
        }
        private void small_bet_Click(object sender, EventArgs e)
        {
            if (order == false && player_1_bet == false)
            {
                player_1_value = this.Text;
                if (player_1_balance > 0)
                {
                    player_1_balance -= 1;
                    player_1_bet_value += 1;
                }

                label2.Text = score + player_1_balance;
                order = true;
                player_1_bet = true;
            }
            else if (order == true)
            {
                player_2_value = this.Text;
                if (player_2_balance > 0)
                {
                    player_2_balance -= 1;
                }

                label5.Text = score + player_2_balance;
                order = false;
                player_2_bet = true;
            }
        }
        private void medium_bet_Click(object sender, EventArgs e)
        {
            if (order == false && player_1_bet == false)
            {
                player_1_value = this.Text;
                if (player_1_balance > 0)
                {
                    player_1_balance -= 1;
                    player_1_bet_value += 1;
                }

                label2.Text = score + player_1_balance;
                order = true;
                player_1_bet = true;
            }
            else if (order == true)
            {
                player_2_value = this.Text;
                if (player_2_balance > 0)
                {
                    player_2_balance -= 1;
                }

                label5.Text = score + player_2_balance;
                order = false;
                player_2_bet = true;
            }
        }
        private void large_bet_Click(object sender, EventArgs e)
        {
            if (order == false && player_1_bet == false)
            {
                player_1_value = this.Text;
                if (player_1_balance > 0)
                {
                    player_1_balance -= 1;
                    player_1_bet_value += 1;
                }

                label2.Text = score + player_1_balance;
                order = true;
                player_1_bet = true;
            }
            else if (order == true)
            {
                player_2_value = this.Text;
                if (player_2_balance > 0)
                {
                    player_2_balance -= 1;
                }

                label5.Text = score + player_2_balance;
                order = false;
                player_2_bet = true;
            }
        }
        private void Elarge_bet_Click(object sender, EventArgs e)
        {
            if (order == false && player_1_bet == false)
            {
                player_1_value = this.Text;
                if (player_1_balance > 0)
                {
                    player_1_balance -= 1;
                    player_1_bet_value += 1;
                }

                label2.Text = score + player_1_balance;
                order = true;
                player_1_bet = true;
            }
            else if (order == true)
            {
                player_2_value = this.Text;
                if (player_2_balance > 0)
                {
                    player_2_balance -= 1;
                }

                label5.Text = score + player_2_balance;
                order = false;
                player_2_bet = true;
            }
        }

        private void spin_Click(object sender, EventArgs e)
        {
            result = new Random().Next(0, 36);
            player_1_bet = false;
            player_2_bet = false;
        }
    }
}
