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
    public partial class PathsInfo : Form
    {
        public PathsInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Narrator4 narrator4Two = new Narrator4();
            narrator4Two.Show();
            this.Hide();
        }
    }
}
