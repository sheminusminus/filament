using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilamentFinalProject
{
    class NetworkPath
    {
        public String NetName = "";
        public String Difficulty = "";
        public int difficultyLevel = 0;

        public NetworkPath(string netname, string difficulty)
        {
            this.NetName = netname;
            this.Difficulty = difficulty;

            if (Difficulty == "easy")
            {
                difficultyLevel = 1;
            }
            else if (Difficulty == "medium")
            {
                difficultyLevel = 2;
            }
            else
            {
                difficultyLevel = 3;
            }
        }
        public void AboutNetwork()
        {
            string theName = NetName;
            string theDiff = Difficulty;
            int diffLevel = difficultyLevel;

            string allInfo = theName + theDiff + Convert.ToString(diffLevel);
            MessageBox.Show(allInfo);
        }

        public string PrintAboutNetwork()
        {
            String PrintNetName = NetName;
            String PrintDiff = Difficulty;
            int PrintDiffLevel = difficultyLevel;

            string attributes = PrintNetName + PrintDiff + Convert.ToString(PrintDiffLevel);
            return attributes;
        }
    }
}