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

            Kupec[] vsi = new Kupec[3];
            vsi[0] = new Kupec();
            vsi[1] = new Kupec60();
            vsi[1].Ime = "Maja Novak";
            vsi[1].BeležiKlic(70, 2);
            Console.WriteLine(vsi[1].ToString());



            Console.ReadLine();
        }
    }
}
