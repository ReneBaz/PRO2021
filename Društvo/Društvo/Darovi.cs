using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Društvo
{ [Serializable]
    public class Darovi
    {
        public int ZapŠT { get; set; }
        public DateTime Datum { get; set; }
        public string Namen { get; set; }
        public decimal Znesek { get; set; }
        public string Opombe { get; set; }

        //zaradi serializacije mora bit konstruktor brez parametrov

        public Darovi()
        {

        }
    }
}
