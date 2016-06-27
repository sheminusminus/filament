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
    public partial class Narrator4 : Form
    {


        //class variables
        private string netName = "";
        private string diffChoice = "";
        private string diffFile = "decisions/difficulty.txt";

        public Narrator4()
        {
            InitializeComponent();
        }


        private void BtnFacebook_Click(object sender, EventArgs e)
        {
            netName = "Facebook";
            diffChoice = "easy";

            File.WriteAllText(diffFile, diffChoice);

            NetworkPath network = new NetworkPath(netName, diffChoice);

            FbMap fbmap = new FbMap();
            fbmap.Show();
            this.Hide();
        }


        private void BtnReddit_Click(object sender, EventArgs e)
        {
            netName = "Reddit";
            diffChoice = "medium";

            File.WriteAllText(diffFile, diffChoice);

            NetworkPath network = new NetworkPath(netName, diffChoice);


            Reddit reddit = new Reddit();
            reddit.Show();
            this.Hide();

        }


        private void Btn4chan_Click(object sender, EventArgs e)
        {
            FourChan chanMap = new FourChan();
            chanMap.Show();
            this.Hide();
        }


        private void BtnGetInfo_Click(object sender, EventArgs e)
        {
            PathsInfo showInfo = new PathsInfo();
            showInfo.Show();
            this.Hide();
        }


    }
}
