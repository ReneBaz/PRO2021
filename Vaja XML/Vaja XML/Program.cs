using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Vaja_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("D:\\PRO2021\\Vaja XML\\Vaja XML\\IzdaniRačuni.xml", FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(IzdaniRacunEnostavni));
            IzdaniRacunEnostavni r = (IzdaniRacunEnostavni)xml.Deserialize(fs);

            foreach(IzdaniRacunEnostavniRacunPostavkeRacuna x in r.Racun.PostavkeRacuna)
            {
                Console.WriteLine(x.OpisiArtiklov.OpisArtikla.OpisArtikla1+" "+x.KolicinaArtikla.Kolicina+" "+x.ZneskiPostavke.ZnesekPostavke);
            }

            Console.ReadLine();
        }
    }
}
