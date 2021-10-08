using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiskiStolpi
{
    class Program
    {
        static void Main(string[] args)
        {
           
            palindrom("rene");
            Console.Read();

        }

        static void Premakni(int n, string začetni, string končni, string pomožni)
        {
            if (n==1)
            {
                Console.WriteLine("premakni iz "+začetni+" na "+končni);
                return;
            }
            Premakni(n - 1, začetni, pomožni, končni);//iz a na b pomagaj si s c
            Console.WriteLine("premakni iz " + začetni + " na "+končni);
            Premakni(n - 1, pomožni, končni, začetni);
        }

        static void palindrom(string beseda)
        {
            if(beseda.Length ==1 || beseda.Length == 0)
            {
                 Console.WriteLine("je palindrom");
                return;
            }
            if (beseda[0].Equals(beseda[beseda.Length-1]))
            {
                palindrom(beseda.Substring(1,beseda.Length-2));
            }
            else
            {
                Console.WriteLine("ni palindrom");
                return;
            }
            
        }
    }
}
