using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
    class Program
    {
        //defineramo delegat
        public delegate bool FunkcijaZaNize(String s);
        //metoda ki sprejme delegat kot parameter
        public static List<string> delakOperacijeNadNizi(string[] nizi, Func<string,bool> mojFunkcija)
        {
            List<string> a = new List<string>();
            foreach(string x in nizi)
            {
                if (mojFunkcija(x))
                    a.Add(x);
            }
            return a;
        }
        //dodaj metode ki ustrezajo deligatu
        public static bool ZačneZA(string s)
        {
            return s.StartsWith("A");
        }
        public static bool KoncaZn(string s)
        {
            return s.EndsWith("n");
        }
        static void Main(string[] args)
        {
            string[] mojNiz = { "Adam", "Alan", "Bob", "jim", "Aidem", "Rob", "Bill", "Jacob", "James" };

            List<string> aji = delakOperacijeNadNizi(mojNiz, ZačneZA);
            List<string> nji = delakOperacijeNadNizi(mojNiz, KoncaZn);

            Console.WriteLine("Začne z a");
            foreach(string s in aji)
            {
                Console.WriteLine(s);
            }
            foreach(string s in nji)
                Console.WriteLine(s);


            List<string> bji = delakOperacijeNadNizi(mojNiz, delegate (string s) { return s.StartsWith("B"); });
            Console.WriteLine("Začne se na b");
            foreach(string s in bji)
            {
                Console.WriteLine(s);
            }

            //lambda al neki takega parameter => pogoj

            List<string> bbji = delakOperacijeNadNizi(mojNiz, s => s.StartsWith("B"));
            Console.WriteLine("Začne se na b");
            foreach (string s in bbji)
            {
                Console.WriteLine(s);
            }


         








            //List<string> niziA = new List<string>();
            //string izbira = Console.ReadLine();
            //Console.WriteLine("Katero crko");
            //string črka = Console.ReadLine();
            //List<string> imena = new List<string>();
            //if(izbira == "1")
            //{
            //    imena = DobiNizeZačetka(črka, mojNiz);
            //}
            //else{
            //    imena= DobiNizeKonec(črka, mojNiz);
            //        }
            //foreach(var s in imena)
            //{
            //    Console.WriteLine(s);
            //}












            Console.ReadLine();
        }

        //private static List<string> DobiNizeKonec(string črka, string[] mojNiz)
        //{
        //    List<string> r = new List<string>();
        //    foreach(var s in mojNiz)
        //    {
        //        if (s.StartsWith(črka))
        //            r.Add(s);
        //    }
        //    return r;
        //}

        //private static List<string> DobiNizeZačetka(string črka, string[] mojNiz)
        //{
        //    List<string> r = new List<string>();
        //    foreach (var s in mojNiz)
        //    {
        //        if (s.EndsWith(črka))
        //            r.Add(s);
        //    }
        //    return r;

        //}
    }
}
