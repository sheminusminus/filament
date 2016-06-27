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
    public partial class Credits : Form
    {

        public Credits()
        {
            InitializeComponent();
        }


        private void BtnToMenu_Click(object sender, EventArgs e)
        {
            StartScreen startGame = new StartScreen();
            startGame.Show();
            this.Hide();
        }


    }
}
