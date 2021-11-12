using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastneIzjeme
{
    class NegativnoExeption:ApplicationException
    {
        public NegativnoExeption() :base("Sprožila se je moja izjema") {

        }
        public NegativnoExeption(string sp) : base("Sprožila se je moja izjema \n"+sp)
        {

        }
    }
}
