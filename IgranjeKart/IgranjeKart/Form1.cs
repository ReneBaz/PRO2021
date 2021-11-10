using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgranjeKart
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vrednost je nakljucno stevilo med 1 in 12, barva je nakljucno stevilo med 1 in 4

            Karta k = new Karta((Vrednosti)r.Next(1, 14),(Barva)r.Next(1, 5));
            MessageBox.Show(k.Ime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //generiraj 5 nakljucnih kart
            string rezultat = "";
            for(int i = 0; i < 5; i++)
            {
                Karta karta = new Karta((Vrednosti)r.Next(1, 14), (Barva)r.Next(1, 5));
                rezultat = rezultat + " " + karta.Ime;
            }
            MessageBox.Show(rezultat);
        }
    }
}
