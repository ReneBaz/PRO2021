using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQVaja1
{
    class Program
    {
        static void Main(string[] args)
        {
            var kupci = new[]{
 new {KupecID=1,Ime="Janez",Priimek="Kranjski",Podjetje="Kolo"},
 new {KupecID=2,Ime="Miha",Priimek="Polanc",Podjetje="Djak"},
 new {KupecID=3,Ime="Gašper",Priimek="Rupnik",Podjetje="Fitnes"},
 new {KupecID=4,Ime="Martin",Priimek="Bolčina",Podjetje="Kolo"},
 new {KupecID=5,Ime="Alenka",Priimek="Puncer",Podjetje="Kolo"},
 new {KupecID=6,Ime="Mojca",Priimek="Širok",Podjetje="Djak"},
 new {KupecID=7,Ime="Peter",Priimek="Gulin",Podjetje="Djak"},
 new {KupecID=8,Ime="Pavel",Priimek="Gantar",Podjetje="Inn"},
 new {KupecID=9,Ime="David",Priimek="Niven",Podjetje="Inn"},
 new {KupecID=10,Ime="Erik",Priimek="Kompara",Podjetje="Fitnes"}
 };
            var podjetja = new[] {
 new {ImePodjetja="Kolo",Mesto="Nova Gorica",Država="Slovenija"},
 new {ImePodjetja="Djak",Mesto="Nova Gorica",Država="Slovenija"},
 new {ImePodjetja="Fitnes",Mesto="Ljubljana",Država="Slovenija"},
 new {ImePodjetja="Inn",Mesto="Trst",Država="Italija"},
 };
            //1. napiši LINQ stavek s katerim izbereš in izpišeš vsa imena kupcev
            var x1 = from x in kupci
                     select x.Ime;
            foreach(var x in x1)
                Console.WriteLine(x);
            Console.WriteLine("--------------------------");
            //2. napiši LINQ stavek katerim izbereš in izpišeš imena in priimke kupcev
            var x2 = from x in kupci
                     select new {x.Ime,x.Priimek};
            foreach (var x in x2)
                Console.WriteLine(x.Ime+" "+x.Priimek);
            Console.WriteLine("--------------------------");
            //3. izberi in izpiši vsa imena podjetji iz Slovenije
            var x3 = from x in podjetja
                     select x.ImePodjetja;
            foreach (var x in x3)
                Console.WriteLine(x);
            Console.WriteLine("--------------------------");
            //4. Izpiši imena podjetji urejena po abecedi
            var x4 = from x in podjetja
                     orderby x.ImePodjetja
                     select x.ImePodjetja;
            foreach (var x in x4)
                Console.WriteLine(x);
            Console.WriteLine("--------------------------");
            //5. izpiši koliko je različnih podjetji
            var x5 = (from x in podjetja
                     select x).Count();
                Console.WriteLine(""+x5.ToString());
            Console.WriteLine("--------------------------");
            //6. izpiši koliko podjetij je iz Italije
            var x6 = (from x in podjetja
                     where x.Država== "Italija"
                     select x).Count();
           
                Console.WriteLine(x6.ToString());
            Console.WriteLine("--------------------------");
            //7. izpiši iz koliko različnih držav imamo podjetja
            var x7 = (from x in podjetja
                      select x.Država).Distinct();
                Console.WriteLine(x7.Count());

            //grupiranje
            var xx = from a in kupci
                    group a by a.Podjetje into p
                    select p;
            foreach(var y1 in xx)
            {
                Console.WriteLine(y1.Key);
                foreach (var y2 in y1)
                {
                    Console.WriteLine("\t"+y2.Ime+" "+y2.Priimek);
                }
            }


            Console.ReadLine();
        }
    }
}
