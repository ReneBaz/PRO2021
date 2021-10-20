using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSŠMobil
{
    class Kupec
    {
        protected string ime;
        protected decimal stanje;

        public string Ime { get => ime; set => ime = value; }
        public decimal Stanje { get => stanje;}//read only iz drugih razredov

        public void BeležiPlačilo(decimal plačilo)
        {
            stanje = stanje - plačilo;
        }

        public virtual void BeležiKlic(int minute, int tip)
        {
            switch (tip)
            {
                case 1:
                    stanje += minute * 0.2m;
                    break;
                case 2://mobilno
                    stanje += minute * 0.03m;
                    break;
                    
            }
        }

        public override string ToString()
        {
            return ime + " dolguje " + stanje;
        }
    }
}
