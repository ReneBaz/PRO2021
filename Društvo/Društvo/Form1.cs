using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Društvo
{
    public partial class Form1 : Form
    {
        string pot = Resource1.pot;
        public Form1()
        {
            InitializeComponent();
        }

        private void butVnesi_Click(object sender, EventArgs e)
        {
            Darovi d = new Darovi();

            
                d.ZapŠT = int.Parse(TxtZaŠt.Text);
  
    d.Datum = DtpDatum.Value;
            d.Namen = TxtNamen.Text;
           
                d.Znesek = decimal.Parse(TxtZnesek.Text);
                sbStatusL.Text = "Pripravljen";
            
            d.Opombe = TxtOpombe.Text;

            FileStream fs = new FileStream(pot, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, d);
            fs.Close();
            sbStatusL.Text = "Zapisano";
            TxtZaŠt.Clear();
            TxtZnesek.Clear();
            TxtNamen.Clear();
            TxtOpombe.Clear();
        }

        private void DtpDatum_Enter(object sender, EventArgs e)
        {
            sbStatusL.Text = "Nov";
        }

        private void TxtZaŠt_Leave(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(TxtZaŠt.Text);
                butVnesi.Enabled = true;
            }
            catch
            {
                sbStatusL.Text = "Napačna zaporedna številka";
                TxtZaŠt.Clear();
                TxtZaŠt.Focus();
                butVnesi.Enabled = false;
            }
        }

        private void TxtZnesek_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal y = decimal.Parse(TxtZnesek.Text);
                butVnesi.Enabled = true;
            }
            catch
            {
                sbStatusL.Text = "Napačen znesek";
                TxtZnesek.Clear();
                TxtZnesek.Focus();
                butVnesi.Enabled = false;
            }
        }
    }
}
