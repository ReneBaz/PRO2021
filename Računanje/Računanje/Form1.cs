using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Računanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kompleksno prvo = new Kompleksno();
            prvo.Re = double.Parse(TxtRe1.Text);
            prvo.Im = double.Parse(TxtIm1.Text);
            Kompleksno drugo = new Kompleksno();
            drugo.Re = double.Parse(TxtRe2.Text);
            drugo.Im = double.Parse(TxtIm2.Text);
            label6.Text = prvo.ToString();
            label7.Text = drugo.ToString();
            label8.Text = (prvo + drugo).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kompleksno prvo = new Kompleksno();
            prvo.Re = double.Parse(TxtRe1.Text);
            prvo.Im = double.Parse(TxtIm1.Text);
            Kompleksno drugo = new Kompleksno();
            drugo.Re = double.Parse(TxtRe2.Text);
            drugo.Im = double.Parse(TxtIm2.Text);
            label6.Text = prvo.ToString();
            label7.Text = drugo.ToString();
            label8.Text = (prvo - drugo).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kompleksno prvo = new Kompleksno();
            prvo.Re = double.Parse(TxtRe1.Text);
            prvo.Im = double.Parse(TxtIm1.Text);
            Kompleksno drugo = new Kompleksno();
            drugo.Re = double.Parse(TxtRe2.Text);
            drugo.Im = double.Parse(TxtIm2.Text);
            label6.Text = prvo.ToString();
            label7.Text = drugo.ToString();
            label8.Text = (prvo * drugo).ToString();
        }
    }
}
