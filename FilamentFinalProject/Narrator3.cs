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
    public partial class Narrator3 : Form
    {

        public Narrator3()
        {
            InitializeComponent();
        }


        private void BtnMention_Click(object sender, EventArgs e)
        {
            Narrator4 narrator4 = new Narrator4();
            narrator4.Show();
            this.Hide();
        }


        private void BtnSoWhat_Click(object sender, EventArgs e)
        {
            Narrator4 narrator4 = new Narrator4();
            narrator4.Show();
            this.Hide();
        }


    }
}
