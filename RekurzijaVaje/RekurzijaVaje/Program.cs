using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekurzijaVaje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(vaja3(7));
            Console.ReadLine();
        }

        static int PotencaIterativno(int n)
        {
            int potenca = 1;
            for(int k=1; k<=n; k++)
            {
                potenca = potenca * 2;
            }
            return potenca;
        }

        static int PotencaRekurzivno(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return 2 * PotencaRekurzivno(n - 1);
        }
        static int fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return fib(n-1)+fib(n-2);
        }

        static int vaja3(int n)
        {
            if (n==1||n==2)
            {
                return 2;
            }
            return vaja3(n - 2) * vaja3(n - 1) - 1;
        }
        static int vaja4(int n)
        {
            
        }
        static int vaja5(int n)
        {
           
        }
    }
}
