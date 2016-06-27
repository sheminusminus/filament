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
    public partial class PickItem : Form
    {

        //class variables
        private string diffFile = "decisions/difficulty.txt";
        private string thingFile = "decisions/thing.txt";
        private string colorFile = "decisions/thingcolor.txt";

        private string difficulty = "";
        private string thing = "";
        private string itemColor = "";


        public PickItem()
        {
            InitializeComponent();
            GetDifficulty();
        }


        private void GetDifficulty()
        {
            string getDiff = "";
            getDiff = File.ReadAllText(diffFile);

            if (getDiff == "easy")
            {
                difficulty = "easy";
            }
            else if (getDiff == "medium")
            {
                difficulty = "medium";
            }
            else if (getDiff == "hard")
            {
                difficulty = "hard";
            }
            else
            {
                difficulty = "easy";
            }
        }


        private void PbItem_Click(object sender, EventArgs e)
        {
            PbItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            PbAbility.BorderStyle = System.Windows.Forms.BorderStyle.None;
            BtnYesItem.Visible = true;
            BtnYesAbility.Visible = false;

            if (difficulty == "easy")
            {
                thing = "electromagnet";
            }
            else if (difficulty == "medium")
            {
                thing = "headphones";
            }
            else if (difficulty == "hard")
            {
                thing = "sunglasses";
            }
            else
            {
                thing = "electromagnet";
            }

            File.WriteAllText(thingFile, thing);
        }


        private void PbAbility_Click(object sender, EventArgs e)
        {
            PbAbility.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            PbItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            BtnYesItem.Visible = false;
            BtnYesAbility.Visible = true;

            if (difficulty == "easy")
            {
                thing = "charisma";
            }
            else if (difficulty == "medium")
            {
                thing = "logic";
            }
            else if (difficulty == "hard")
            {
                thing = "liar";
            }
            else
            {
                thing = "charisma";
            }

            File.WriteAllText(thingFile, thing);
        }


        private void BtnYesItem_Click(object sender, EventArgs e)
        {
            if (difficulty == "easy" && thing == "electromagnet")
            {
                textBox5.Visible = true;
                BtnFuschia.Visible = true;
                BtnPeri.Visible = true;
                BtnMar.Visible = true;
            }
            else if (difficulty == "medium" && thing == "headphones")
            {
                textBox5.Visible = true;
                BtnFuschia.Visible = true;
                BtnPeri.Visible = true;
                BtnMar.Visible = true;
            }
            else if (difficulty == "hard" && thing == "sunglasses")
            {
                textBox5.Visible = true;
                BtnFuschia.Visible = true;
                BtnPeri.Visible = true;
                BtnMar.Visible = true;
            }
            else
            {
                BtnContinue.Visible = true;
            }

        }


        private void BtnYesAbility_Click(object sender, EventArgs e)
        {
            Thing ability = new Thing(thing);
            BtnContinue.Visible = true;
        }


        private void BtnFuschia_Click(object sender, EventArgs e)
        {
            itemColor = "fuschia";
            File.WriteAllText(colorFile, itemColor);
            BtnContinue.Visible = true;
            Thing item = new Thing(thing, itemColor);
        }


        private void BtnPeri_Click(object sender, EventArgs e)
        {
            itemColor = "periwinkle";
            File.WriteAllText(colorFile, itemColor);
            BtnContinue.Visible = true;
            Thing item = new Thing(thing, itemColor);

        }


        private void BtnMar_Click(object sender, EventArgs e)
        {
            itemColor = "maroon";
            File.WriteAllText(colorFile, itemColor);
            BtnContinue.Visible = true;
            Thing item = new Thing(thing, itemColor);

        }


        private void BtnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
