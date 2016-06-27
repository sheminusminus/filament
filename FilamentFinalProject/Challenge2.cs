using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilamentFinalProject
{
    public partial class Challenge2 : Form
    {
        string difficulty = File.ReadAllText("decisions/difficulty.txt");

        Random rnd = new Random();

        int userRoll1 = 0;
        int userRoll2 = 0;
        int enemyRoll1 = 0;
        int enemyRoll2 = 0;

        int numRolls = 0;

        bool wonRoll1 = false;
        bool wonRoll2 = false;
        bool wonGame = false;

        
        public Challenge2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numRolls++;
            if (numRolls == 1)
            {
                RollDice(difficulty);
            }
            else if (numRolls == 2)
            {
                MakeSecondVisible();
            }
            else
            {
                button3.Visible = false;
            }
        }
        
        private void RollDice(string difficulty)
        {
                if (difficulty == "easy")
                {
                    enemyRoll1 = rnd.Next(1, 3);
                    enemyRoll2 = rnd.Next(1, 3);

                }

                else if (difficulty == "medium")
                {
                    enemyRoll1 = rnd.Next(1, 4);
                    enemyRoll2 = rnd.Next(1, 4);

                }
                else if (difficulty == "hard")
                {
                    enemyRoll1 = rnd.Next(1, 5);
                    enemyRoll2 = rnd.Next(1, 5);

                }
                else
                {
                    enemyRoll1 = rnd.Next(1, 3);
                    enemyRoll2 = rnd.Next(1, 4);

                }
 
            userRoll1 = rnd.Next(1, 7);
            userRoll2 = rnd.Next(1, 7);

            int imageIndex1 = userRoll1 - 1;
            int imageIndex3 = enemyRoll1 - 1;

            UserDice1.BackgroundImage = imageList1.Images[imageIndex1];
            EnemyDice1.BackgroundImage = imageList2.Images[imageIndex3];
            EnemyDice1.Visible = true;
            UserDice1.Visible = true;
            textBox2.Text = "Roll: " + Convert.ToString(userRoll1);
            textBox4.Text = "Roll: " + Convert.ToString(enemyRoll1);


            //evalute who won the dice roll
            if (userRoll1 > enemyRoll1)
            {
                wonRoll1 = true;
                label2.Visible = true;
            }
            else
            {
                wonRoll1 = false;
                label1.Text = "You lost!";
                label1.BackColor = Color.FromArgb(178, 34, 34);
                label1.Visible = true;
                button3.Visible = false;
                button4.Text = "Shucks!";
                button4.Visible = true;
                //TO DO display loss message and return
            }
            
        }

        private void MakeSecondVisible()
        {
            label2.Visible = false;
            int imageIndex4 = enemyRoll2 - 1;
            int imageIndex2 = userRoll2 - 1;

            UserDice2.BackgroundImage = imageList1.Images[imageIndex2];
            EnemyDice2.BackgroundImage = imageList2.Images[imageIndex4];
            EnemyDice2.Visible = true;
            UserDice2.Visible = true;
            textBox3.Text = "Roll: " + Convert.ToString(userRoll2);
            textBox5.Text = "Roll: " + Convert.ToString(enemyRoll2);
            if (userRoll2 > enemyRoll2)
            {
                wonRoll2 = true;
            }
            else
            {
                wonRoll2 = false;
            }

            WhoWins();

        }

        private void WhoWins()
        {
            if (wonRoll1 && wonRoll2 == true)
            {
                wonGame = true;
            }
            else
            {
                wonGame = false;
            }

            if (wonGame == true)
            {
                label1.Text = "You won!";
                label1.BackColor = Color.FromArgb(0, 100, 0);
                label1.Visible = true;
                button3.Visible = false;
                button4.Text = "Yay!";
                button4.Visible = true;

            }
            else
            {
                label1.Text = "You lost!";
                label1.BackColor = Color.FromArgb(178, 34, 34);
                label1.Visible = true;
                button3.Visible = false;
                button4.Text = "Shucks!";
                button4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
   

    }
}

