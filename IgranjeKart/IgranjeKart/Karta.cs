using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgranjeKart
{
    class Karta
    {
        public Vrednosti Vrednosti { get; set; }
        public Barva Barva { get; set; }
        public string Ime {
        get { return Vrednosti + " " + Barva; }
        }
        public Karta(Vrednosti v, Barva b)
        {
            Vrednosti = v;
            Barva = b;
        }
    }
}
