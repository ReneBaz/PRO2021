using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Društvo
{
    public partial class GlavoOkno : Form
    {
        public GlavoOkno()
        {
            InitializeComponent();
        }

        private void vnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.MdiParent = this;
            a.Show();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pregled a = new Pregled();
            a.MdiParent = this;
            a.Show();
        }
    }
}
