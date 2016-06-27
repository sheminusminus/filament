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
    public partial class Instructions : Form
    {

        public Instructions()
        {
            InitializeComponent();
        }


        private void BtnToMenu_Click(object sender, EventArgs e)
        {
            StartScreen start = new StartScreen();
            start.Show();
            this.Hide();
        }


    }
}
