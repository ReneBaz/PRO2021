using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PisanjeBranjeVBinarnem
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime danes = DateTime.Now;
            //FileStream fs = new FileStream("a.dat", FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, danes);
            //fs.Close();

            FileStream fs = new FileStream("a.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            DateTime x = (DateTime)bf.Deserialize(fs);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
