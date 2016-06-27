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
    public partial class StartScreen : Form
    {

        //class variables
        public string nameFile = "decisions/name.txt";
        private string playerName = "";


        public static StartScreen Screen = null;


        public StartScreen()
        {
            InitializeComponent();

            StartScreen.Screen = this;
        }



        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            TxtRequestName.Visible = true;
            TxtPlayerName.Visible = true;
            BtnLetsGo.Visible = true;
        }


        private void TxtPlayerName_TextChanged(object sender, EventArgs e)
        {
            playerName = TxtPlayerName.Text;
        }

        private string VerifyPath(string filepath)
        {
            string path = Path.GetDirectoryName(filepath);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return filepath;
        }

        private void BtnLetsGo_Click(object sender, EventArgs e)
        {
            string input = TxtPlayerName.Text;
            File.WriteAllText(VerifyPath(nameFile), input);

            MakeCharacter character = new MakeCharacter();
            character.Name = input;
            character.Show();

            this.Hide();
        }


        private void BtnInstruct_Click(object sender, EventArgs e)
        {
            Instructions instructions = new Instructions();
            instructions.Show();

            this.Hide();
        }


        private void BtnCredits_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
            this.Hide();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.Hide();
                }
            }
        }
    }
}
