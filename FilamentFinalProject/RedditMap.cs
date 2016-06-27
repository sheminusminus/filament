// TO DO:
// - MAPPING AND HIT BOXES
// - CHALLENGE ONE GAME
// - END BOSS GAME

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
    public partial class RedditMap : Form
    {

        //class variables
        private string charHair = "";
        private string charShirt = "";
        private string charSex = "";
        private string charName = "";


        public RedditMap()
        {
            InitializeComponent();
            CreateStuff();
            SetTimers();

        }

        public void CreateStuff()
        {
            //gets character attributes from text files
            charName = File.ReadAllText("decisions/name.txt");
            charHair = File.ReadAllText("decisions/hair.txt");
            charShirt = File.ReadAllText("decisions/shirt.txt");
            charSex = File.ReadAllText("decisions/sex.txt");

            //make player's character object
            Character playerChar = new Character(charName, charHair, charShirt, charSex);
            playerChar.Name = charName;


            //set shirt color of panel guy
            if (charShirt == "purple")
            {
                TinyShirt.BackColor = Color.FromArgb(243, 3, 250);
            }
            else if (charShirt == "orange")
            {
                TinyShirt.BackColor = Color.FromArgb(249, 131, 7);
            }
            else
            {
                TinyShirt.BackColor = Color.FromArgb(1, 193, 255);
            }


            //set hair color of panel guy
            if (charHair == "blonde")
            {
                TinyHead.BackColor = Color.FromArgb(250, 236, 88);
            }
            else if (charHair == "black")
            {
                TinyHead.BackColor = Color.FromArgb(0, 0, 0);
            }
            else if (charHair == "red")
            {
                TinyHead.BackColor = Color.FromArgb(174, 25, 21);
            }
            else
            {
                TinyHead.BackColor = Color.FromArgb(116, 64, 7);
            }

            //set pants color of panel guy
            if (charSex == "female")
            {
                TinyPants.BackColor = Color.FromArgb(255, 192, 203);
            }
            else
            {
                TinyPants.BackColor = Color.FromArgb(119, 136, 153);
            }
        }


        //describe movements of panel guy
        private void RedditMap_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                if (TinyHead.Top >= 15)
                {
                    TinyHead.Top -= 10;
                    TinyShirt.Top -= 10;
                    TinyPants.Top -= 10;
                    TinyFace.Top -= 10;
                }
            }


            if (e.KeyCode == Keys.Down)
            {
                if (TinyHead.Top <= 400)
                {
                    TinyHead.Top += 10;
                    TinyShirt.Top += 10;
                    TinyPants.Top += 10;
                    TinyFace.Top += 10;

                }
            }


            if (e.KeyCode == Keys.Left)
            {
                if (TinyHead.Left >= 25)
                {
                    TinyHead.Left -= 10;
                    TinyShirt.Left -= 10;
                    TinyPants.Left -= 10;
                    TinyFace.Left -= 10;

                }
            }


            if (e.KeyCode == Keys.Right)
            {
                if (TinyHead.Left <= 425)
                {
                    TinyHead.Left += 10;
                    TinyShirt.Left += 10;
                    TinyPants.Left += 10;
                    TinyFace.Left += 10;

                }
            }
        }


        private void SetTimers()
        {
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer2.Enabled = false;
            timer2.Interval = 20;
            timer3.Enabled = false;
            timer3.Interval = 20;
        }


        //timer event to check for first first collision
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TinyShirt.Right >= PbAlien.Left && TinyShirt.Left <= PbAlien.Right && TinyPants.Bottom >= PbAlien.Top && TinyHead.Top <= PbAlien.Bottom)
            {
                AlienCollisionEvent();
            }
        }

        private void AlienCollisionEvent()
        {
            timer1.Enabled = false;
            timer2.Enabled = true;

            Challenge1 challenge = new Challenge1();
            challenge.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (TinyShirt.Right >= PbArrows.Left && TinyShirt.Left <= PbArrows.Right && TinyPants.Bottom >= PbArrows.Top && TinyHead.Top <= PbArrows.Bottom)
            {
                ArrowsCollisionEvent();
            }
        }

        private void ArrowsCollisionEvent()
        {
            timer2.Enabled = false;
            timer3.Enabled = true;

            Challenge2 challenge2 = new Challenge2();
            challenge2.Show();
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            if (TinyShirt.Left >= PbGold.Right && TinyHead.Top >= PbGold.Bottom)
            {
                EscapeCollisionEvent();
            }
        }

        private void EscapeCollisionEvent()
        {
            timer3.Enabled = false;

            EscapeSuccess escapeSuccess = new EscapeSuccess();
            escapeSuccess.Show();
        }

    }
}
