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
            x = x + d*Math.Cos(alpha*Math.PI/180);
            y = y + d*Math.Sin(alpha * Math.PI / 180);
            int x1 = risaniX(starix);
            int y1 = risaniY(stariy);
            int x2 = risaniX(x);
            int y2 = risaniY(y);
            g.DrawLine(new Pen(Color.Black, 3), x1,y1,x2,y2);
        }

        public void Koch(int n, double korak, Graphics g)
        {
            if (n == 0)
            {
                premik(korak, g);
                return;
            }
            Koch(n - 1, korak, g);
            obratlevo(60);
            Koch(n - 1, korak, g);
            obratlevo(-120);
            Koch(n - 1,korak,g);
            obratlevo(60);
            Koch(n - 1,korak,g);
        }
        public void KochInvert(int n, double korak, Graphics g)
        {
            if (n == 0)
            {
                premik(korak, g);
                return;
            }
            KochInvert(n - 1, korak, g);
            obratlevo(-60);
            KochInvert(n - 1, korak, g);
            obratlevo(120);
            KochInvert(n - 1, korak, g);
            obratlevo(-60);
            KochInvert(n - 1, korak, g);
        }
        public void Drevo(int n, double x, double y, double a, double dolžina, Graphics g, int bg)
        {
            int kot = 45;
            double pojemek = 0.55;
            bg=bg + 20;
            double cx = x + dolžina * Math.Cos(a * Math.PI / 180);
            double cy = y + dolžina * Math.Sin(a * Math.PI / 180);
            int x1 = risaniX(cx);
            int y1 = risaniY(cy);
            int x2 = risaniX(x);
            int y2 = risaniY(y);
            Pen p = new Pen(Color.FromArgb(0,bg,0),(float)(4*0.05*Math.Pow(n,1.2)));
            g.DrawLine(p, x1,y1,x2,y2);
            if (n == 0)
            {
                return;
            }
            Drevo(n - 1, cx, cy, a - kot, dolžina * pojemek, g,bg);
            Drevo(n - 1, cx, cy, a + kot, dolžina * pojemek, g,bg);
            Drevo(n - 1, cx, cy, a,dolžina*(1-pojemek), g,bg);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //x = 0.25;
            //y = 0.1;
            //alpha = 0;
            //for(int k=0; k<6; k++)
            //{
            //    double korak = 0.4;
            //    premik(korak, g);
            //    obratlevo(360 / 6);
            //}
            //Random r = new Random();
            //x=0.5;y = 0.5;alpha = 0;
            //for(int k=0; k<10000; k++)
            //{
            //    obratlevo(r.Next(360));
            //    premik(0.01,g);

            //}
            //x = 0.15;y = 0.3;alpha = 0;
            //int n = 5;

            //for(int s = 0; s < 6; s++)
            //{
            //    Koch(n, 1 / Math.Pow(3, n)/4.5, g);
            //    obratlevo(360 / 6);
            //}
            //x = 0.6;
            //for (int s = 0; s < 6; s++)
            //{
            //    KochInvert(n, 1 / Math.Pow(3, n) / 4.5, g);
            //    obratlevo(360 / 6);
            //}
            int n = 10;
            Drevo(n, 0.5, 0, 90, 0.4, g, 20);
        }
    }
}
