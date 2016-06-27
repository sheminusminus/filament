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
    public partial class NarratorIntro : Form
    {

        public NarratorIntro()
        {
            InitializeComponent();
        }


        private void BtnWhereQ_Click(object sender, EventArgs e)
        {
            Narrator2 narrator2 = new Narrator2();
            narrator2.Show();
            this.Hide();
        }


        private void BtnOtherQ_Click(object sender, EventArgs e)
        {
            Narrator2 narrator2 = new Narrator2();
            narrator2.Show();
            this.Hide();
        }


    }
}
