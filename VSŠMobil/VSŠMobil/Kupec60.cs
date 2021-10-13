using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSŠMobil
{
    class Kupec60:Kupec
    {
        private int visjaTarifaPorableno;

        public new void BeležiKlic(int minute, int tip)
        {
            switch (tip)
            {
                case 1:
                    stanje += minute * 0.2m;
                    break;
                case 2://prvih 60 minut po 0.05 drugo po 0.01
                    int vMinute;
                    int nMinute;
                    int šeVMinute = (visjaTarifaPorableno < 60) ? 60 - visjaTarifaPorableno : 0;
                    if (minute > šeVMinute)
                    {
                        vMinute = šeVMinute;
                        nMinute = minute - vMinute;
                    }
                    else
                    {
                        vMinute = minute;
                        nMinute = 0;
                    }
                    stanje += vMinute * 0.05m + nMinute * 0.01m;
                    visjaTarifaPorableno += vMinute;
                    break;

            }
        }
    }
}
