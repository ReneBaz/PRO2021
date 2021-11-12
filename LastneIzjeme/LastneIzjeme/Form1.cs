﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastneIzjeme
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
                if (x < 0)
                {
                    throw new NegativnoExeption();
                }
                
                double rez = Math.Sqrt(x);
                label2.Text = "" + rez;
            }
            catch(FormatException ex)
            {
                System.Windows.Forms.MessageBox.Show("Neveljavna operacija \n" + ex);
            }
            catch (NegativnoExeption)
            {
                System.Windows.Forms.MessageBox.Show("Ni dovoljeno računanje korena od negativnih števil \n");
            }
        }
    }
}
