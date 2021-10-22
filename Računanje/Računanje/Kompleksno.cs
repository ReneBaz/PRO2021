using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Računanje
{
    class Kompleksno
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public override string ToString()
        {
            return Re+"+i*"+Im;
        }
        //+-*

        public static Kompleksno operator +(Kompleksno a, Kompleksno b)
        {
            Kompleksno r = new Kompleksno();
            r.Re = a.Re + b.Re;
            r.Im = a.Im + b.Im;
            return r;
        }
        public static Kompleksno operator -(Kompleksno a, Kompleksno b)
        {
            Kompleksno r = new Kompleksno();
            r.Re = a.Re - b.Re;
            r.Im = a.Im - b.Im;
            return r;    
        }

        public static Kompleksno operator *(Kompleksno a, Kompleksno b)
        {
            Kompleksno r = new Kompleksno();
            r.Re = a.Re * b.Re - a.Im * b.Im;
            r.Im = a.Re * b.Im + a.Im * b.Re;
            return r;
        }
        
    }
}
