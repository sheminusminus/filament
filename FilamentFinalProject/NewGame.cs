using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilamentFinalProject
{
    public partial class NewGame : Form
    {

        public NewGame()
        {
            InitializeComponent();
        }


        private void BtnWhat_Click(object sender, EventArgs e)
        {
            NarratorIntro narratorIntro = new NarratorIntro();
            narratorIntro.Show();
            this.Hide();
        }


    }
}
