using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukture
{
    class Program
    {
        struct Vektor
        {
            public double x, y, z;
            public override string ToString()
            {
                return "(" + x + ", " + y + ", " + z + ")";
            }
            public Vektor(double x1, double y1, double z1)
            {
                x = x1; y = y1; z = z1;
            }
            public Vektor(Vektor v)
            {
                x = v.x; y = v.y; z = v.z;
            }
            //preobteževanje operatorja +
            public static Vektor operator +(Vektor levi, Vektor desni)
            {
                Vektor r;
                r.x = levi.x + desni.x;
                r.y = levi.y + desni.y;
                r.z = levi.z + desni.z;
                return r;
            }
            public static Vektor operator *(double levi, Vektor desni)
            {
                Vektor r;
                r.x = levi * desni.x;
                r.y = levi * desni.y;
                r.z = levi * desni.z;
                return r;
            }
            public static Vektor operator *(Vektor levi, double desni)
            {
                return desni * levi;
            }

            public static double operator *(Vektor v, Vektor w)
            {
                return v.x* w.x + v.y * w.y + v.z * w.z;
            }
            public static bool operator ==(Vektor v, Vektor w)
            {
                return v.x == w.x && v.y == w.y && v.z == w.z;
            }
            public static bool operator !=(Vektor v, Vektor w)
            {
                return !(v==w);
            }
        }
        static void Main(string[] args)
        {
            Vektor v1;
            v1.x = 1;
            v1.y = 1;
            v1.z = 1;
            Console.WriteLine(v1.ToString());
            Vektor v2 = new Vektor(2,-1,2);
            Console.WriteLine(v2.ToString());
            Vektor v3 = v1+v2;
            Console.WriteLine(v3.ToString());
            Console.WriteLine((7*v1).ToString());
            Console.WriteLine((v1*v2).ToString());

            Console.ReadLine();
        }
    }
}
