using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelejenjeZ0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);

                double rez = x / y;
                label3.Text = "" + rez;
            }
            catch (ArithmeticException ex)
            {
                System.Windows.Forms.MessageBox.Show("Poskus deljenja z 0 \n" + ex);
            }
            catch (FormatException ex)
            {
                System.Windows.Forms.MessageBox.Show("Neveljaven format \n"+ex);
            }
        }
    }
}
