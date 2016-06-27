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
    public partial class Narrator2 : Form
    {

        public Narrator2()
        {
            InitializeComponent();
        }


        private void BtnKidding_Click(object sender, EventArgs e)
        {
            Narrator3 narrator3 = new Narrator3();
            narrator3.Show();
            this.Hide();
        }


        private void BtnProof_Click(object sender, EventArgs e)
        {
            Narrator3 narrator3 = new Narrator3();
            narrator3.Show();
            this.Hide();
        }


    }
}
