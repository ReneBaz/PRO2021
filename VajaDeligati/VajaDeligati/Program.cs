using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaDeligati
{
    class Program
    {
        //delegate string Spremeni(string vhodniNiz);
        static void Main(string[] args)
        {
            //Func<string,string> metoda = delegate(string s) { return s.ToUpper(); };
            Func<string, string> metoda = s => s.ToUpper();
            string ime = "Dokota";
            Console.WriteLine(metoda(ime));


            int[] numbers = { 5, 10, 8, 3, 6, 12 };
            var deljivaZDva = from x in numbers
                              where x % 2 == 0
                              orderby x
                              select x;
            foreach(var x in deljivaZDva)
            {
                Console.Write(x);
            }


            Console.WriteLine("");
            var zDva = numbers.Where(s => s % 2 == 0).OrderBy(n=>n);

            foreach (var x in zDva)
            {
                Console.Write(x);
            }




            Console.ReadLine();
        }
        //static string VVelike(string a)//tipa spremeni
        //{
        //    return a.ToUpper();
        //}
    }
}
