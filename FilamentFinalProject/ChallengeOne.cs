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
    public partial class ChallengeOne : Form
    {
        string difficulty = File.ReadAllText("decisions/difficulty.txt");

        Random location = new Random();
        List<Point> points = new List<Point>();
        List<PictureBox> picturebox = new List<PictureBox>();

        int secondsLeft = 0;
        int matches = 0;

        PictureBox pendImage1 = null;
        PictureBox pendImage2 = null;


        public ChallengeOne()
        {
            InitializeComponent();
        }

        private void ChallengeOne_Load(object sender, EventArgs e)
        {
            foreach (PictureBox picture in CardHolder.Controls)
            {
                points.Add(picture.Location);
                picture.Enabled = false;
            }
            foreach (PictureBox picture in CardHolder.Controls)
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }

            if (difficulty == "easy")
            {
                secondsLeft = 5;
                timer1.Enabled = true;
                timer2.Enabled = true;
                countdown.Text = Convert.ToString(5);
            }
            else
            {
                secondsLeft = 3;
                timer4.Enabled = true;
                timer5.Enabled = true;
                countdown.Text = Convert.ToString(3);
            }
            card1.Image = Properties.Resources.lap;
            dupCard1.Image = Properties.Resources.lap;
            card2.Image = Properties.Resources.net;
            dupCard2.Image = Properties.Resources.net;
            card3.Image = Properties.Resources.guy;
            dupCard3.Image = Properties.Resources.guy;
            card4.Image = Properties.Resources.qr;
            dupCard4.Image = Properties.Resources.qr;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox picture in CardHolder.Controls)
            {
                picture.Enabled = true;
                picture.Image = Properties.Resources.qmark;
                picture.Cursor = Cursors.Hand;
            }

            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            secondsLeft--;
            countdown.Text = Convert.ToString(secondsLeft);

            if (secondsLeft == 0)
            {
                label1.Visible = false;
                countdown.Visible = false;
                timer2.Enabled = false;
            }
        }

        //assign and change card images
        #region Card Images

        private void card1_Click(object sender, EventArgs e)
        {
            card1.Image = Properties.Resources.lap;
            if (pendImage1 == null)
            {
                pendImage1 = card1;
            }
            else if (pendImage1 != null && pendImage2 == null)
            {
                pendImage2 = card1;
            }
            
            if (pendImage1 != null && pendImage2 != null)
            {
                if (pendImage1.Tag == pendImage2.Tag)
                {
                    matches++;
                    matchesMade.Text = Convert.ToString(matches);
                    pendImage1 = null;
                    pendImage2 = null;
                    card1.Enabled = false;
                    dupCard1.Enabled = false;
                    if (matches == 4)
                    {
                        WinMatching();
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dupCard1_Click(object sender, EventArgs e)
        {
            dupCard1.Image = Properties.Resources.lap;
            if (pendImage1 == null)
            {
                pendImage1 = dupCard1;
            }
            else if (pendImage1 != null && pendImage2 == null)
            {
                pendImage2 = dupCard1;
            }

            if (pendImage1 != null && pendImage2 != null)
            {
                if (pendImage1.Tag == pendImage2.Tag)
                {
                    matches++;
                    matchesMade.Text = Convert.ToString(matches);
                    pendImage1 = null;
                    pendImage2 = null;
                    card1.Enabled = false;
                    dupCard1.Enabled = false;
                    if (matches == 4)
                    {
                        WinMatching();
                    }
                }
                else
                {
                    timer3.Start();
                }
            }

        }

        private void card2_Click(object sender, EventArgs e)
        {
            card2.Image = Properties.Resources.net;
            if (pendImage1 == null)
            {
                pendImage1 = card2;
            }
            else if (pendImage1 != null && pendImage2 == null)
            {
                pendImage2 = card2;
            }

            if (pendImage1 != null && pendImage2 != null)
            {
                if (pendImage1.Tag == pendImage2.Tag)
                {
                    matches++;
                    matchesMade.Text = Convert.ToString(matches);
                    pendImage1 = null;
                    pendImage2 = null;
                    card2.Enabled = false;
                    dupCard2.Enabled = false;
                    if (matches == 4)
                    {
                        WinMatching();
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void card4_Click(object sender, EventArgs e)
        {
            card4.Image = Properties.Resources.qr;
            if (pendImage1 == null)
            {
                pendImage1 = card4;
            }
            else if (pendImage1 != null && pendImage2 == null)
            {
                pendImage2 = card4;
            }

            if (pendImage1 != null && pendImage2 != null)
            {
                if (pendImage1.Tag == pendImage2.Tag)
                {
                    matches++;
                    matchesMade.Text = Convert.ToString(matches);
                    pendImage1 = null;
                    pendImage2 = null;
                    card4.Enabled = false;
                    dupCard4.Enabled = false;
                    if (matches == 4)
                    {
                        WinMatching();
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dupCard4_Click(object sender, EventArgs e)
        {
            dupCard4.Image = Properties.Resources.qr;
            if (pendImage1 == null)
            {
                pendImage1 = dupCard4;
            }
            else if (pendImage1 != null && pendImage2 == null)
            {
                pendImage2 = dupCard4;
            }

            if (pendImage1 != null && pendImage2 != null)
            {
                if (pendImage1.Tag == pendImage2.Tag)
                {
                    matches++;
                    matchesMade.Text = Convert.ToString(matches);
                    pendImage1 = null;
                    pendImage2 = null;
                    card4.Enabled = false;
                    dupCard4.Enabled = false;
                    if (matches == 4)
                    {
                        WinMatching();
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dupCard3_Click(object sender, EventArgs e)
        {
            dupCard3.Image = Properties.Resources.guy;
            if (pendImage1 == null)
            {
                pendImage1 = dupCard3;
            }
            else if (pendImage1 != null && pendImage2 == null)
            {
                pendImage2 = dupCard3;
            }

            if (pendImage1 != null && pendImage2 != null)
            {
                if (pendImage1.Tag == pendImage2.Tag)
                {
                    matches++;
                    matchesMade.Text = Convert.ToString(matches);
                    pendImage1 = null;
                    pendImage2 = null;
                    card3.Enabled = false;
                    dupCard3.Enabled = false;
                    if (matches == 4)
                    {
                        WinMatching();
                    }
                }
                else
                {
                    timer3.Start();
                }
            }

        }

        private void card3_Click(object sender, EventArgs e)
        {
            card3.Image = Properties.Resources.guy;
            if (pendImage1 == null)
            {
                pendImage1 = card3;
            }
            else if (pendImage1 != null && pendImage2 == null)
            {
                pendImage2 = card3;
            }

            if (pendImage1 != null && pendImage2 != null)
            {
                if (pendImage1.Tag == pendImage2.Tag)
                {
                    matches++;
                    matchesMade.Text = Convert.ToString(matches);
                    pendImage1 = null;
                    pendImage2 = null;
                    card3.Enabled = false;
                    dupCard3.Enabled = false;
                    if (matches == 4)
                    {
                        WinMatching();
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dupCard2_Click(object sender, EventArgs e)
        {
            dupCard2.Image = Properties.Resources.net;
            if (pendImage1 == null)
            {
                pendImage1 = dupCard2;
            }
            else if (pendImage1 != null && pendImage2 == null)
            {
                pendImage2 = dupCard2;
            }

            if (pendImage1 != null && pendImage2 != null)
            {
                if (pendImage1.Tag == pendImage2.Tag)
                {
                    matches++;
                    matchesMade.Text = Convert.ToString(matches);
                    pendImage1 = null;
                    pendImage2 = null;
                    card2.Enabled = false;
                    dupCard2.Enabled = false;
                    if (matches == 4)
                    {
                        WinMatching();
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }
        #endregion

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            if (pendImage1 != null)
            {
                pendImage1.Image = Properties.Resources.qmark;
            }
            if (pendImage2 != null)
            {
                pendImage2.Image = Properties.Resources.qmark;

            }
            pendImage1 = null;
            pendImage2 = null;
        }

        private void WinMatching()
        {
            label3.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox picture in CardHolder.Controls)
            {
                picture.Enabled = true;
                picture.Image = Properties.Resources.qmark;
                picture.Cursor = Cursors.Hand;
            }

            timer4.Enabled = false;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            secondsLeft--;
            countdown.Text = Convert.ToString(secondsLeft);

            if (secondsLeft == 0)
            {
                label1.Visible = false;
                countdown.Visible = false;
                timer5.Enabled = false;
            }
        }

    }
}
