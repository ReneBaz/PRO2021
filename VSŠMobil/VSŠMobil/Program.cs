using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSŠMobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Kupec Janez = new Kupec();
            Janez.Ime = "janez novak";
            Janez.BeležiKlic(10, 1);
            Console.WriteLine(Janez.Ime+" dolguje "+Janez.Stanje);

            Kupec60 Alenka = new Kupec60();
            Alenka.Ime = "alenka princic";
            Alenka.BeležiKlic(70, 2);
            Console.WriteLine(Alenka.ToString());
           



            Console.ReadLine();
        }
    }
}
