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
    public partial class FourChan : Form
    {
        public FourChan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FbMap fbmap = new FbMap();
            fbmap.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reddit redditMap = new Reddit();
            redditMap.Show();
            this.Hide();
        }
    }
}
