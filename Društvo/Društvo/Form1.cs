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
            d.Opombe = TxtOpombe.Text;

            FileStream fs = new FileStream("Darovi.txt", FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, d);
            fs.Close();
        }
    }
}
