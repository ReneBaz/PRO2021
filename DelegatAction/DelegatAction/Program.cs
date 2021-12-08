using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatAction
{
    class Program
    {
        delegate void Izpis(string message);
        static void Main(string[] args)
        {
            Action<string> cilj;
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                cilj = s=>MessageBox.Show(s);
            }
            else
            {
                cilj = Console.WriteLine;
            }

            cilj("pozdravljen svet");

            Console.ReadLine();
        }
        //private static void ShowMessage(string massage)
        //{
        //    MessageBox.Show(massage);
        //}
    }
}
