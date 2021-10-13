using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrejanjeTabel
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 50000;
            //double[] tab = new double[n];
            //Random r = new Random();
            //for(int k = 0; k < n; k++)
            //{
            //    tab[k] = r.Next(n);
            //}
            //DateTime d = DateTime.Now;
            string[] tab = {"banana","jabolka","kruh","avto","kolo","drevo","zelenjava","meso"};
            Izpis(tab);
            QuickSortString(0, tab.Length - 1, tab);
            Izpis(tab);
            //Vstavljanje(a);
            //DateTime d1 = DateTime.Now;
            //TimeSpan ts = d1 - d;
            //Console.WriteLine("cas za quick je "+ts+"ms");
            //for (int k = 0; k < n; k++)
            //{
            //    a[k] = r.Next(n);
            //}
            //d = DateTime.Now;
            //Izbiranje(a);
            //d1 = DateTime.Now;
            //ts = d1 - d;
            //Console.WriteLine("cas za izbiranje je " + ts + "ms");





            Console.ReadLine();
        }
        static void Izbiranje(int[] a)
        {
            for(int k=0; k < a.Length; k++)
            {
                int min = a[k];
                int minIndex = k;
                for(int j = k; j < a.Length; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j];
                        minIndex = j;
                    }
                }
                int temp = a[k];
                a[k] = a[minIndex];
                a[minIndex] = temp;
               // Izpis(a);
            }
        }
        static void Vstavljanje(int[] a)
        {
            for(int k = 1; k < a.Length; k++)
            {
                int j = k;
                int temp = a[k];
                    while (j>0 && a[j - 1] > temp)
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = temp;
                //Izpis(a);
            }
        }
        static int PivotDouble(int zac, int kon, double[] tab)
        {
            double p = tab[zac];
            int m = zac;
            int n = kon + 1;
            //poisci z m prvega ki je veci od p
            do
            {
                m = m + 1;
            } while (tab[m] <= p && m < kon);
            do
            {
                n = n - 1;
            } while (tab[n] > p);
            //tab[m] je veci od p
            //tab[n] je mansi od p
            //zamenjaj jih
            while (m < n)
            {
                double temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do
                {
                    m = m + 1;
                } while (tab[m] <= p);
                do
                {
                    n = n - 1;
                } while (tab[n] > p);
            }
            double temp2 = tab[n];
            tab[n] = tab[zac];
            tab[zac] = temp2;
            //Izpis(tab);
            return n;
            
        }
        
        static void QuickSortDouble(int zac, int kon, double[] tab)
        {
            if (zac >= kon)
            {
                return;
            }
            int a = PivotDouble(zac, kon, tab);
            QuickSortDouble(zac, a - 1, tab);
            QuickSortDouble(a + 1, kon, tab);
        }
        static int PivotString(int zac, int kon, string[] tab)
        {
            string p = tab[zac];
            int m = zac;
            int n = kon + 1;
            //poisci z m prvega ki je veci od p
            do
            {
                m = m + 1;
            } while (tab[m].CompareTo(p)<=0 && m < kon);
            do
            {
                n = n - 1;
            } while (tab[n].CompareTo(p)>0);
            //tab[m] je veci od p
            //tab[n] je mansi od p
            //zamenjaj jih
            while (m < n)
            {
                string temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do
                {
                    m = m + 1;
                } while (tab[m].CompareTo(p) <= 0);
                do
                {
                    n = n - 1;
                } while (tab[n].CompareTo(p) > 0);
            }
            string temp2 = tab[n];
            tab[n] = tab[zac];
            tab[zac] = temp2;
            //Izpis(tab);
            return n;

        }

        static void QuickSortString(int zac, int kon, string[] tab)
        {
            if (zac >= kon)
            {
                return;
            }
            int a = PivotString(zac, kon, tab);
            QuickSortString(zac, a - 1, tab);
            QuickSortString(a + 1, kon, tab);
        }

        static void Izpis(string[] a)
        {
            for(int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k]+"\t");
            }
            Console.WriteLine();
        }
    }
}
