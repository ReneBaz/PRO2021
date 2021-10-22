using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaPravokotnik
{
    class Pravokotnik
    {
        
        public double Širina { get; set; }
        public double Višina { get; set; }
        public Pravokotnik()
        {

        }
        public Pravokotnik(double š, double v)
        {
            Širina = š;
            Višina = v;
        }
        public double Ploscina()
        {
            return Širina * Višina;
        }

        public static bool operator ==(Pravokotnik p1,  Pravokotnik p2)
        {
            return p1.Ploscina() == p2.Ploscina();
        }
        public static bool operator !=(Pravokotnik p1, Pravokotnik p2)
        {
            return !(p1 == p2);
        }
        public static bool operator >(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploscina()> p2.Ploscina();
        }
        public static bool operator <(Pravokotnik p1, Pravokotnik p2)
        {
            return !(p1 > p2);
        }
        public static bool operator >=(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploscina() >= p2.Ploscina();
        }
        public static bool operator <=(Pravokotnik p1, Pravokotnik p2)
        {
            return !(p1 >= p2);
        }

        public override string ToString()
        {
            return "Višina ="+Višina+" Širina ="+Širina ;
        }

    }
}
