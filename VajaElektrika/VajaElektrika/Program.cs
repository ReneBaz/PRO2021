using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaElektrika
{
    class Program
    {
        static void Main(string[] args)
        {
            ElektrikaEntities db = new ElektrikaEntities();
            //1. izberi čas meritve in skupno moč
            var x1 = from a in db.Meritve
                     select new { Čas = a.ZapisČas, Moč = a.kW1 + a.kW2 + a.kW3 };
            Console.WriteLine(x1.Count());
            Console.WriteLine("-----------------------------------------------------------");
            //ista poizvedba z lambda izrazom


            //2. izberi čas meritve in skupno moč za datum 18.8.2013
            DateTime datum1 = DateTime.Parse("19.8.2013");
            DateTime datum2 = DateTime.Parse("17.8.2013");
            var x2 = from a in db.Meritve
                     where a.ZapisČas<datum1 && a.ZapisČas>datum2
                     select new { Čas = a.ZapisČas, Moč = a.kW1 + a.kW2 + a.kW3 };
            //foreach (var y in x2)
            //{
            //    Console.WriteLine(y.Čas + "| " + y.Moč);
            //}
            Console.WriteLine("-----------------------------------------------------------");
            //3. izračunaj povprečno moč za datum 18.8.2013
            var x3 = (from a in db.Meritve
                     where a.ZapisČas < datum1 && a.ZapisČas > datum2
                     select a.kW1+a.kW2+a.kW3).Average();
            Console.WriteLine("Avg "+x3);
            Console.WriteLine("-----------------------------------------------------------");
            //4. izračunaj maximalno moč za ta datum
            var x4 = (from a in db.Meritve
                      where a.ZapisČas < datum1 && a.ZapisČas > datum2
                      select a.kW1 + a.kW2 + a.kW3).Max();
            Console.WriteLine("Max "+x4);
            Console.WriteLine("-----------------------------------------------------------");

            //5. izračunaj minimalno moč za ta datum
            var x5 = (from a in db.Meritve
                      where a.ZapisČas < datum1 && a.ZapisČas > datum2
                      select a.kW1 + a.kW2 + a.kW3).Min();
            Console.WriteLine("Min "+x5);
            Console.WriteLine("-----------------------------------------------------------");

            //6. izračunaj povprečno moč po urah za dan 18.8.2013
            var x6 = (from a in db.Meritve
                      where a.ZapisČas < datum1 && a.ZapisČas > datum2
                      group a.kW1 + a.kW2 + a.kW3 by a.ZapisČas.Value.Hour into b
                      select b);
            
            foreach(var y in x6)
            {
                Console.WriteLine("Avg po urah "+y.Key+" " + y.Average());
            }
            Console.WriteLine("-----------------------------------------------------------");

            //7.izračunaj 15 minutna povprečja za 18.8.2013
            var x7 = (from a in db.Meritve
                      where a.ZapisČas < datum1 && a.ZapisČas > datum2
                      let ura=a.ZapisČas.Value.Hour
                      let min=a.ZapisČas.Value.Minute
                      let quarter=min/15
                      group a.kW1 + a.kW2 + a.kW3 by new {ura,quarter} into b
                      select b);

            foreach (var y in x7)
            {
                Console.WriteLine("Avg po 15 min "+y.Key + y.Average());
            }
            Console.WriteLine("-----------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
