using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            //var prvo = 5;
            //Console.WriteLine(prvo.GetType());
            //var drugo = "dobro jutro";
            //Console.WriteLine(drugo.GetType());
            //var tretje = 0.67;
            //Console.WriteLine(tretje.GetType());
            string[] dr = { "Texas", "Tlinos", "New york", "Washington", "Florida", "Indiana", "Oregon", "Ioa" };
            //osnovna link stvarca
            var državenai = from s in dr
                            where s.StartsWith("I")
                            select s;

            foreach(var d in državenai)
            {
                Console.WriteLine(d);
            }
            //izpiši vse države ki imajo ime dalše od 5 znakov
            Console.WriteLine("----------------------------------------");
            var x1 = from a in dr
                     where a.Length > 5
                     select a;

            foreach (var a in x1)
            {
                Console.WriteLine(a);
            }
            //se začnejo na i in so dalsa od 5
            Console.WriteLine("----------------------------------------");
            var x2 = from a in dr
                     where a.Length > 5 && a.StartsWith("I")
                     select a;

            foreach (var a in x2)
            {
                Console.WriteLine(a);
            }

            //ureditev
            Console.WriteLine("----------------------------------------");
            var x3 = from a in dr
                     orderby a descending
                     select a;

            foreach (var a in x3)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
