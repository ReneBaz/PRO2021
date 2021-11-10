using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    class PovezanaLista<K,T> where K: IComparable
    {
        public Vozel<K, T> Glava;
        public PovezanaLista()
        {
            Glava = new Vozel<K, T>();
        }
        //dodaj glavo
        public void Dodaj(K key,T Item)
        {
            Vozel<K, T> nov = new Vozel<K, T>(key, Item, Glava.Naslednji);
        }
        public T Najdi(K ka)
        {
            Vozel<K, T> trenutni = Glava;
            while(trenutni.Naslednji != null)
            {
                if(trenutni.Kay.CompareTo(ka) == 0)
                {
                    break;
                }
                else
                {
                    trenutni = trenutni.Naslednji;
                }
            }
            return trenutni.Item;
        }
    }
}
