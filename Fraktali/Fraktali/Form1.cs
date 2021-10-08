using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraktali
{
    public partial class Form1 : Form
    {
        private double x;
        private double y;
        private double alpha;//kot glede na os x
        public Form1()
        {
            InitializeComponent();
        }
        
        private int risaniX(double xr)
        {
            return (int)Math.Round(this.Width * xr);
        }

        private int risaniY(double yr)
        {
            return (int)Math.Round(this.Height-this.Height * yr);
        }

        public void obratlevo(double kot)
        {
            alpha = alpha + kot;
        }

        public void premik(double d, Graphics g)
        {
            double starix = x;
            double stariy = y;
            x = x + Math.Cos(alpha*Math.PI/180);
            y = y + Math.Sin(alpha * Math.PI / 180);
            int x1 = risaniX(starix);
            int y1 = risaniY(stariy);
            int x2 = risaniX(x);
            int y2 = risaniY(y);
            g.DrawLine(new Pen(Color.Black, 3), x1,y1,x2,y2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            x = 0.5;
            y = 0.5;
            alpha = 0;
            premik(0.5, g);
        }
    }
}
