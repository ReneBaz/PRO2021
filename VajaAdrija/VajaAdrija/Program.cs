using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaAdrija
{
    class Program
    {
        static void Main(string[] args)
        {
            BazaLinqDataContext dc = new BazaLinqDataContext();
            //1. izpiši vsa imena in kode modelov letal iz tabele model

            var x1 = from a in dc.MODELs
                     select a;
            foreach(var y in x1)
            {
                Console.WriteLine(y.MOD_IME+" "+y.MOD_KODA);
            }
            Console.WriteLine("------------------------------------------------------------");
            //2. izpiši imena vseh zaposlenih, ki so piloti
            var x2 = from a in dc.PILOTs
                     from b in dc.ZAPOSELNIs
                     where a.ZAP_ST == b.ZAP_ST
                     select b;


            foreach (var y in x2)
            {
                Console.WriteLine(y.ZAP_IME);
            }

            Console.WriteLine("------------------------------------------------------------");

            //3. izpiši imena in priimke vseh strank
            var x3 = from a in dc.STRANKAs
                     select a;

            foreach (var y in x3)
            {
                Console.WriteLine(y.STR_IME);
            }

            Console.WriteLine("------------------------------------------------------------");
            //4. izpiši podatke o čarterskih poletih - datum in cilj zbrane po strankah

            var x4 = from a in dc.CHARTERs
                     group a by a.STR_KODA;

            foreach (var y in x4)
            {
                Console.WriteLine(y.CHAR_DATUM+" "+y.CHAR_CILJ);
            }
            Console.WriteLine("------------------------------------------------------------");
            //5. izpiši podatke o čarterskih poletih - datum in cilj, zbrane po pilotih
            var x5 = from a in dc.CHARTERs
                     select a;

            foreach (var y in x5)
            {
                Console.WriteLine(y.CHAR_DATUM + " " + y.CHAR_CILJ);
            }
            Console.WriteLine("------------------------------------------------------------");
            //6. izpiši podatke o čarterskih poletih urejene po ciljih

            //7. razvrsti čarterske polete po urah čakanja- izpiši cilj in ure čakanja

            //8. vstavi stranko s priimkom Saksida, imenom Miran v tabelo Strank

            //upoštevaj, da je koda stranke samoštevilo

            //9. stranki s priimkom Ramas spremeni telefon v 123-456

            //10. izbriši stranke s priimkom Smith

            Console.ReadLine();
        }
    }
}
