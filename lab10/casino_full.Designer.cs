
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab10
{
    partial class Form6
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            /*this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button54 = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.button58 = new System.Windows.Forms.Button();
            this.button59 = new System.Windows.Forms.Button();*/
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button60 = new System.Windows.Forms.Button();
            this.button61 = new System.Windows.Forms.Button();
            this.button62 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            //
            // number_bet
            //
            int button_id = 1;
            for (int i = 0; i < 12; i++)
            { 
                for(int j = 0; j < 3; ++j)
                {   
                    Button button = new Button();
                    button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                    button.FlatAppearance.BorderColor = System.Drawing.Color.White;
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    button.ForeColor = System.Drawing.SystemColors.ControlText;
                    button.Location = new System.Drawing.Point(start_button_x + j * ( button_padding + bet_button_width), start_button_y + i * (button_padding + smallBet_button_height));
                    button.Name = $"number_bet_{button_id}";
                    button.Size = new System.Drawing.Size(bet_button_width, smallBet_button_height);
                    button.TabIndex = 2;
                    button.Tag = "number_bet";
                    button.Text = $"{button_id}";
                    button.UseVisualStyleBackColor = true;
                    button.Click += new System.EventHandler(this.number_bet_Click);
                    button_id += 1;
                    this.Controls.Add(button);
                    this.listOfButtons.Add(button);
                }

            }
            //
            // small_bet
            //
            button_id = 1;
            int range = 1;
            for (int i = 0; i < 12 ; i++)
            {   
                Button button = new Button();
                button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
                button.FlatAppearance.BorderColor = System.Drawing.Color.White;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.SystemColors.ControlText;
                button.Location = new System.Drawing.Point(small_bet_start_x, start_button_y + i * (button_padding + smallBet_button_height));
                button.Name = $"small_bet_{button_id}";
                button.Size = new System.Drawing.Size(bet_button_width, smallBet_button_height);
                button.TabIndex = 2;
                button.Tag = "small_bet";
                button.Text = $"{range}-{range + 2}";
                range += 3;
                button.UseVisualStyleBackColor = true;
                button.Click += new System.EventHandler(this.small_bet_Click);
                button_id += 1;
                this.Controls.Add(button);
                this.listOfButtons.Add(button);
            }
            //
            // medium_bet
            //
            range = 1;
            for (int i = 0; i < 6; i++)
            {
                Button button = new Button();
                button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
                button.FlatAppearance.BorderColor = System.Drawing.Color.White;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.SystemColors.ControlText;
                button.Location = new System.Drawing.Point(medium_bet_start_x, start_button_y + i * (button_padding + mediumBet_button_height));
                button.Name = $"medium_bet_{button_id}";
                button.Size = new System.Drawing.Size(bet_button_width, mediumBet_button_height);
                button.TabIndex = 2;
                button.Tag = "medium_bet";
                button.Text = $"{range}-{range + 5}";
                range += 6;
                button.UseVisualStyleBackColor = true;
                button.Click += new System.EventHandler(this.medium_bet_Click);
                button_id += 1;
                this.Controls.Add(button);
                this.listOfButtons.Add(button);
            }
            //
            // large_bet
            //
            range = 1;
            for (int i = 0; i < 3; i++)
            {
                Button button = new Button();
                button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
                button.FlatAppearance.BorderColor = System.Drawing.Color.White;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.SystemColors.ControlText;
                button.Location = new System.Drawing.Point(large_bet_start_x, start_button_y + i * (button_padding + largeBet_button_height));
                button.Name = $"large_bet_{button_id}";
                button.Size = new System.Drawing.Size(bet_button_width, largeBet_button_height);
                button.TabIndex = 2;
                button.Tag = "large_bet";
                button.Text = $"{range}-{range + 11}";
                range += 12;
                button.UseVisualStyleBackColor = true;
                button.Click += new System.EventHandler(this.large_bet_Click);
                button_id += 1;
                this.Controls.Add(button);
                this.listOfButtons.Add(button);
            }

            //
            // Elarge_bet
            // 
            range = 1;
            for (int i = 0; i < 2; i++)
            {
                Button button = new Button();
                button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
                button.FlatAppearance.BorderColor = System.Drawing.Color.White;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.ForeColor = System.Drawing.SystemColors.ControlText;
                button.Location = new System.Drawing.Point(Elarge_bet_start_x, start_button_y + i * (button_padding + ElargeBet_button_height));
                button.Name = $"Elarge_bet_{button_id}";
                button.Size = new System.Drawing.Size(bet_button_width, ElargeBet_button_height);
                button.TabIndex = 2;
                button.Tag = "Elarge_bet";
                button.Text = $"{range}-{range + 17}";
                range += 18;
                button.UseVisualStyleBackColor = true;
                button.Click += new System.EventHandler(this.Elarge_bet_Click);
                button_id += 1;
                this.Controls.Add(button);
                this.listOfButtons.Add(button);
            }
            //
            // textBox1
            //
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(488, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 0;

            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::lab10.Properties.Resources.casino1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(720, 597);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 67;
            this.label4.Text = "2 игрок";
            this.label4.AutoEllipsis = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(695, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 48);
            this.label5.TabIndex = 66;
            this.label5.Text = $"Очки:{player_2_balance}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 65;
            this.label3.Text = "1 игрок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 48);
            this.label2.TabIndex = 64;
            this.label2.Text = $"Очки:{player_1_balance}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(93, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 73);
            this.label6.TabIndex = 68;
            this.label6.Text = "36";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(650,720);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 73);
            this.label7.TabIndex = 68;
            this.label7.Text = "Ставка 2 игрока - ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(200, 720);
            this.label8.Name = "label7";
            this.label8.Size = new System.Drawing.Size(104, 73);
            this.label8.TabIndex = 68;
            this.label8.Text = "Ставка 1 игрока - ";
            // 
            // button60
            // 
            this.button60.Location = new System.Drawing.Point(503, 615);
            this.button60.Name = "button60";
            this.button60.Size = new System.Drawing.Size(100, 42);
            this.button60.TabIndex = 63;
            this.button60.Text = "Убрать второго игрока";
            this.button60.UseVisualStyleBackColor = true;
            // 
            // button61
            // 
            this.button61.Location = new System.Drawing.Point(503, 615);
            this.button61.Name = "button61";
            this.button61.Size = new System.Drawing.Size(100, 42);
            this.button61.TabIndex = 62;
            this.button61.Text = "Добавить второго игрока";
            this.button61.UseVisualStyleBackColor = true;
            // 
            // button62
            // 
            this.button62.BackColor = System.Drawing.Color.Gold;
            this.button62.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button62.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.button62.Location = new System.Drawing.Point(92, 484);
            this.button62.Name = "button62";
            this.button62.Size = new System.Drawing.Size(105, 73);
            this.button62.TabIndex = 69;
            this.button62.Text = "Крутить";
            this.button62.UseVisualStyleBackColor = false;
            button62.Click += new System.EventHandler(this.spin_Click);
            // 
            // Form6
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.button62);
            this.Controls.Add(this.button60);
            this.Controls.Add(this.button61);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);

            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form6_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button60;
        private System.Windows.Forms.Button button61;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button62;
        private List<Button> listOfButtons = new List<Button>();
        private List<int> player1_bets;
        private List<int> player2_bets;
        private int bet_button_width = 83;
        private const int button_padding = 6;
        private int smallBet_button_height = 36;
        private int mediumBet_button_height = 78;
        private int largeBet_button_height = 162;
        private int ElargeBet_button_height = 246;
        private const int number_bet_count = 36;
        private const int start_button_x = 309, start_button_y = 79;
        private const int small_bet_start_x = 573, small_bet_start_y = 415;
        private const int medium_bet_start_x = 662;
        private const int large_bet_start_x = 751;
        private const int Elarge_bet_start_x = 840;
        
    }
}