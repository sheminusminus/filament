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
    public partial class FbPrequel : Form
    {
        public FbPrequel()
        {
            InitializeComponent();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FbMap facebookmap = new FbMap();
            facebookmap.Show();
            this.Hide();
        }
    }
}
