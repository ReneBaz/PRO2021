using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaBazeNovaPovezava
{
    class Program
    {
        static void Main(string[] args)
        {
            BazaZaVajeEntities db = new BazaZaVajeEntities();
            DateTime datum = DateTime.Parse("20.1.2004");
            var x1 = from a in db.PRODUKT
                     where a.P_DATUM < datum
                     select new {a.P_OPIS,a.P_ZALOGA,a.P_MIN,a.P_CENA,a.P_DATUM };
            foreach(var y in x1)
            {
                Console.WriteLine("opis "+y.P_OPIS+"| "+y.P_DATUM);
            }
            Console.WriteLine("----------------------------------------------------");

            TimeSpan ts = new TimeSpan(365,0,0,0);
            DateTime zapadlost = DateTime.Now.Add(ts);
            var x2 = from a in db.PRODUKT
                     select a;
            foreach (var y in x2)
            {
                Console.WriteLine(y.P_OPIS+"| "+y.P_ZALOGA+"| "+y.P_DATUM+"| "+zapadlost);
            }
            Console.WriteLine("----------------------------------------------------");

            //izberi P_OPIS, P_ZALOGA, P_MIN,P_CENA iz tabele PRODUKT, kjer je P_CENA manjša od 50 in
            //je P_DATUM večji kot 15.jan. 2004
            DateTime datum1 = DateTime.Parse("15.1.2004");
            var x3 = from a in db.PRODUKT
                     where a.P_CENA<50 && a.P_DATUM>datum1
                     select a;
            foreach (var y in x3)
            {
                Console.WriteLine(y.P_OPIS + "| " + y.P_ZALOGA +"| "+y.P_MIN+"| " + y.P_CENA);
            }
            Console.WriteLine("----------------------------------------------------");


            //izberi vse atribute iz tabele DOBAVITELJ katerih ime se začne s Smith

            var x4 = from a in db.DOBAVITELJ
                     where a.D_IME.StartsWith("Smith")
                     select a;
            foreach (var y in x4)
            {
                Console.WriteLine(y.D_IME);
            }
            Console.WriteLine("----------------------------------------------------");

            //izberi vse dobavitelje, kjer je zaloga v produktu manjša od dvakratnika minimalne zaloge

            var x5 = from a in db.PRODUKT
                     from b in db.DOBAVITELJ
                     where a.P_ZALOGA<(a.P_MIN*2)
                     select b;
            foreach (var y in x5)
            {
                Console.WriteLine(y.D_IME);
            }
            Console.WriteLine("----------------------------------------------------");

            //izberi D_KODA od dobaviteljev, ki so nam že dobavili katerega izmed produktov. Vsak
            //dobavitelj naj bo v rešitvi samo enkrat

            var x6 = (from a in db.PRODUKT
                     from b in db.DOBAVITELJ
                     where a.D_KODA==b.D_KODA
                     select b).Distinct();
            foreach (var y in x6)
            {
                Console.WriteLine(y.D_IME);
            }
            Console.WriteLine("----------------------------------------------------");

            //g. izberi kodo in ime dobavitelja, ki nam še niso ničesar dobavili (njihova koda se ne pojavlja v
            //   tabeli PRODUKT) 

            var x7 = (from a in db.PRODUKT
                      from b in db.DOBAVITELJ
                      where b.D_KODA != a.D_KODA
                      select b).Distinct();
            foreach (var y in x7)
            {
                Console.WriteLine(y.D_IME);
            }
            Console.WriteLine("----------------------------------------------------");

            //h. izpiši vsoto vseh stanj pri kupcih (KUP_STANJE) (2089,28)
            
            var x8 = (from a in db.KUPEC
                      select a.KUP_STANJE).Sum();
            Console.WriteLine(x8);
            Console.WriteLine("----------------------------------------------------");

            //izračunaj celotno vrednost blaga na zalogi (15.084,52€) 
            var x9 = (from a in db.PRODUKT
                      select a.P_ZALOGA*a.P_CENA).Sum();
            Console.WriteLine(x9);
            Console.WriteLine("----------------------------------------------------");

            //izpiši število različnih produktov posameznega dobavitelja po posameznem dobavitelju iz
            //tabele produkt(rešitev ima 6 vrstic, če izključimo dobavitelja null) 
            var x10 = (from a in db.PRODUKT
                       group a.P_KODA by a.D_KODA into b
                      select b);
            foreach (var y in x10)
            {
                Console.WriteLine(y.Key);
            }
            Console.WriteLine("----------------------------------------------------");



            Console.ReadLine();
        }
    }
}
