using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrimerJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Učilnica u = JsonConvert.DeserializeObject<Učilnica>(

                File.ReadAllText(@"D:\PRO2021\PrimerJson\PrimerJson\Učilnica.json")
                );
            foreach(var p in u.Poglavja)
            {
                Console.WriteLine(p.name);
                foreach(var m in p.modules)
                {
                    Console.WriteLine("\t"+m.name);
                }
            }
            Console.ReadLine();
        }
    }
}
