using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki

{
    class Program
    {
        static void Main(string[] args)
        {
            //mi ne dela
            PovezanaLista<int, String> p = new PovezanaLista<int, string>();
            p.Dodaj(14, "A");
            p.Dodaj(12, "B");
            p.Dodaj(1, "C");
            string x = p.Najdi(12);
            Console.WriteLine("Našel sem "+x);
            Console.ReadLine();
        }
    }
}
