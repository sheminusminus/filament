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
    public partial class EscapeSuccess : Form
    {
        string nameFile = "decisions/name.txt";
        string sexFile = "decisions/sex.txt";
        string hairFile = "decisions/hair.txt";
        string shirtFile = "decisions/shirt.txt";
        string diffFile = "decisions/difficulty.txt";

        string name = "";
        string sex = "";
        string hair = "";
        string shirt = "";
        string difficulty = "";

        public EscapeSuccess()
        {
            InitializeComponent();
        }

        private void EscapeSuccess_Load(object sender, EventArgs e)
        {
            name = File.ReadAllText(nameFile);
            shirt = File.ReadAllText(shirtFile);
            sex = File.ReadAllText(sexFile);
            hair = File.ReadAllText(hairFile);
            difficulty = File.ReadAllText(diffFile);

            //recall player's name
            label4.Text = name;

            //recall player's character information
            if (shirt == "blue")
            {
                Shirt.BackColor = Color.FromArgb(1, 193, 255);
            }
            else if (shirt == "purple")
            {
                Shirt.BackColor = Color.FromArgb(243, 3, 250);
            }
            else
            {
                Shirt.BackColor = Color.FromArgb(249, 131, 7);
            }

            if (sex == "female")
            {
                Pants.BackColor = Color.FromArgb(255, 192, 203);
            }
            else
            {
                Pants.BackColor = Color.FromArgb(119, 136, 153);
            }

            if (hair == "black")
            {
                Hair.BackColor = Color.FromArgb(0, 0, 0);
            }
            else if (hair == "blonde")
            {
                Hair.BackColor = Color.FromArgb(250, 236, 88);
            }
            else
            {
                Hair.BackColor = Color.FromArgb(174, 25, 21);
            }

            if (difficulty == "easy")
            {
                label3.Text = "Route chosen: Facebook";
            }
            else if (difficulty == "medium")
            {
                label3.Text = "Route chosen: Reddit";
            }
            else
            {
                label3.Text = "Route chosen: 4Chan";
            }
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        //exit the game
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            StartScreen.Screen.Close();
        }
    }
}
