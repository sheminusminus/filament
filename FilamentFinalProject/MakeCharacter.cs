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
    public partial class MakeCharacter : Form
    {

        //class variables
        private string hairFile = "decisions/hair.txt";
        private string toneFile = "decisions/shirt.txt";
        private string sexFile = "decisions/sex.txt";
        private string hairColor = "";
        private string shirtColor = "";
        private string playerSex = "";


        public MakeCharacter()
        {
            InitializeComponent();
        }
            

        private void PbMaleSymbol_Click(object sender, EventArgs e)
        {
            playerSex = "male";

            PbBrownM.Visible = true;
            PbBlondeM.Visible = true;
            PbRedM.Visible = true;
            PbBlackM.Visible = true;
            PbBrownF.Visible = false;
            PbBlondeF.Visible = false;
            PbBlackF.Visible = false;
            PbRedF.Visible = false;

            PbHair.Visible = true;

            PbFemaleSymbol.Visible = false;
            PbMaleSymbol.Visible = true;
        }


        private void PbFemaleSymbol_Click(object sender, EventArgs e)
        {
            playerSex = "female";

            PbBrownF.Visible = true;
            PbBlondeF.Visible = true;
            PbBlackF.Visible = true;
            PbRedF.Visible = true;
            PbBrownM.Visible = false;
            PbBlondeM.Visible = false;
            PbRedM.Visible = false;
            PbBlackM.Visible = false;

            PbHair.Visible = true;

            PbMaleSymbol.Visible = false;
            PbFemaleSymbol.Visible = true;
        }


        private void PbBlackM_Click(object sender, EventArgs e)
        {
            hairColor = "black";

            PbBlueM.Visible = true;
            PbPurpleM.Visible = true;
            PbOrangeM.Visible = true;
            PbBrownF.Visible = false;
            PbBlondeF.Visible = false;
            PbBlackF.Visible = false;
            PbRedF.Visible = false;
            PbBrownM.Visible = false;
            PbBlondeM.Visible = false;
            PbRedM.Visible = false;
            PbBlackM.Visible = true;

            PbWear.Visible = true;
        }


        private void PbBlondeM_Click(object sender, EventArgs e)
        {
            hairColor = "blonde";

            PbBlueM.Visible = true;
            PbPurpleM.Visible = true;
            PbOrangeM.Visible = true;
            PbBrownF.Visible = false;
            PbBlondeF.Visible = false;
            PbBlackF.Visible = false;
            PbRedF.Visible = false;
            PbBrownM.Visible = false;
            PbBlondeM.Visible = true;
            PbRedM.Visible = false;
            PbBlackM.Visible = false;

            PbWear.Visible = true;
        }


        private void PbBrownM_Click(object sender, EventArgs e)
        {
            hairColor = "brown";

            PbBlueM.Visible = true;
            PbPurpleM.Visible = true;
            PbOrangeM.Visible = true;
            PbBrownF.Visible = false;
            PbBlondeF.Visible = false;
            PbBlackF.Visible = false;
            PbRedF.Visible = false;
            PbBrownM.Visible = true;
            PbBlondeM.Visible = false;
            PbRedM.Visible = false;
            PbBlackM.Visible = false;

            PbWear.Visible = true;
        }


        private void PbRedM_Click(object sender, EventArgs e)
        {
            hairColor = "red";

            PbBlueM.Visible = true;
            PbPurpleM.Visible = true;
            PbOrangeM.Visible = true;
            PbBrownF.Visible = false;
            PbBlondeF.Visible = false;
            PbBlackF.Visible = false;
            PbRedF.Visible = false;
            PbBrownM.Visible = false;
            PbBlondeM.Visible = false;
            PbRedM.Visible = true;
            PbBlackM.Visible = false;

            PbWear.Visible = true;
        }


        private void PbRedF_Click(object sender, EventArgs e)
        {
            hairColor = "red";

            PbBlueF.Visible = true;
            PbPurpleF.Visible = true;
            PbOrangeF.Visible = true;
            PbBlueM.Visible = false;
            PbPurpleM.Visible = false;
            PbOrangeM.Visible = false;

            PbBrownF.Visible = false;
            PbBlondeF.Visible = false;
            PbBlackF.Visible = false;
            PbRedF.Visible = true;
            PbBrownM.Visible = false;
            PbBlondeM.Visible = false;
            PbRedM.Visible = false;
            PbBlackM.Visible = false;

            PbWear.Visible = true;

        }


        private void PbBrownF_Click(object sender, EventArgs e)
        {
            hairColor = "brown";

            PbBlueF.Visible = true;
            PbPurpleF.Visible = true;
            PbOrangeF.Visible = true;
            PbBlueM.Visible = false;
            PbPurpleM.Visible = false;
            PbOrangeM.Visible = false;
            PbBrownF.Visible = true;
            PbBlondeF.Visible = false;
            PbBlackF.Visible = false;
            PbRedF.Visible = false;
            PbBrownM.Visible = false;
            PbBlondeM.Visible = false;
            PbRedM.Visible = false;
            PbBlackM.Visible = false;

            PbWear.Visible = true;
        }


        private void PbBlondeF_Click(object sender, EventArgs e)
        {
            hairColor = "blonde";

            PbBlueF.Visible = true;
            PbPurpleF.Visible = true;
            PbOrangeF.Visible = true;
            PbBlueM.Visible = false;
            PbPurpleM.Visible = false;
            PbOrangeM.Visible = false;
            PbBrownF.Visible = false;
            PbBlondeF.Visible = true;
            PbBlackF.Visible = false;
            PbRedF.Visible = false;
            PbBrownM.Visible = false;
            PbBlondeM.Visible = false;
            PbRedM.Visible = false;
            PbBlackM.Visible = false;

            PbWear.Visible = true;
        }


        private void PbBlackF_Click(object sender, EventArgs e)
        {
            hairColor = "black";

            PbBlueF.Visible = true;
            PbPurpleF.Visible = true;
            PbOrangeF.Visible = true;
            PbBlueM.Visible = false;
            PbPurpleM.Visible = false;
            PbOrangeM.Visible = false;
            PbBrownF.Visible = false;
            PbBlondeF.Visible = false;
            PbBlackF.Visible = true;
            PbRedF.Visible = false;
            PbBrownM.Visible = false;
            PbBlondeM.Visible = false;
            PbRedM.Visible = false;
            PbBlackM.Visible = false;

            PbWear.Visible = true;
        }


        private void PbBlueM_Click(object sender, EventArgs e)
        {
            shirtColor = "blue";

            PbBlueM.Visible = true;
            PbPurpleM.Visible = false;
            PbOrangeM.Visible = false;
            PbBlueF.Visible = false;
            PbPurpleF.Visible = false;
            PbOrangeF.Visible = false;
        }


        private void PbPurpleM_Click(object sender, EventArgs e)
        {
            shirtColor = "purple";

            PbBlueM.Visible = false;
            PbPurpleM.Visible = true;
            PbOrangeM.Visible = false;
            PbBlueF.Visible = false;
            PbPurpleF.Visible = false;
            PbOrangeF.Visible = false;
        }


        private void PbOrangeM_Click(object sender, EventArgs e)
        {
            shirtColor = "orange";

            PbBlueM.Visible = false;
            PbPurpleM.Visible = false;
            PbOrangeM.Visible = true;
            PbBlueF.Visible = false;
            PbPurpleF.Visible = false;
            PbOrangeF.Visible = false;
        }


        private void PBOrangeF_Click(object sender, EventArgs e)
        {
            shirtColor = "orange";

            PbBlueF.Visible = false;
            PbPurpleF.Visible = false;
            PbOrangeF.Visible = true;
            PbBlueM.Visible = false;
            PbPurpleM.Visible = false;
            PbOrangeM.Visible = false;
        }


        private void PbPurpleF_Click(object sender, EventArgs e)
        {
            shirtColor = "purple";

            PbBlueF.Visible = false;
            PbPurpleF.Visible = true;
            PbOrangeF.Visible = false;
            PbBlueM.Visible = false;
            PbPurpleM.Visible = false;
            PbOrangeM.Visible = false;
        }


        private void PbBlueF_Click(object sender, EventArgs e)
        {
            shirtColor = "blue";

            PbBlueF.Visible = true;
            PbPurpleF.Visible = false;
            PbOrangeF.Visible = false;
            PbBlueM.Visible = false;
            PbPurpleM.Visible = false;
            PbOrangeM.Visible = false;
        }


        //starts the creation process over
        private void BtnStartOver_Click(object sender, EventArgs e)
        {
            PbFemaleSymbol.Visible = true;
            PbMaleSymbol.Visible = true;
            PbSex.Visible = true;
            PbBlueM.Visible = false;
            PbPurpleM.Visible = false;
            PbOrangeM.Visible = false;
            PbBlueF.Visible = false;
            PbPurpleF.Visible = false;
            PbOrangeF.Visible = false;
            PbWear.Visible = false;
            PbHair.Visible = false;
            PbBrownF.Visible = false;
            PbBlondeF.Visible = false;
            PbBlackF.Visible = false;
            PbRedF.Visible = false;
            PbBrownM.Visible = false;
            PbBlondeM.Visible = false;
            PbRedM.Visible = false;
            PbBlackM.Visible = false;

            playerSex = "";
            hairColor = "";
            shirtColor = "";

            File.WriteAllText(sexFile, playerSex);
            File.WriteAllText(hairFile, hairColor);
            File.WriteAllText(toneFile, shirtColor);
        }


        private void CreateInfoFiles(string sex, string hair, string tone)
        {
            sex = playerSex;
            hair = hairColor;
            tone = shirtColor;

            File.WriteAllText(sexFile, playerSex);
            File.WriteAllText(hairFile, hairColor);
            File.WriteAllText(toneFile, shirtColor);
        }


        private void BtnAllDone_Click(object sender, EventArgs e)
        {
            CreateInfoFiles(playerSex, hairColor, shirtColor);

            NewGame gameOn = new NewGame();
            gameOn.Show();
            this.Hide();
        }


    }
}
