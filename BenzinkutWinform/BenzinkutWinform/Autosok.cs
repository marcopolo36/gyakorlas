using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzinkutWinform
{
    class Autosok
    {
        private List<Autos> l;

        public Autosok()
        {
            l = new List<Autos>();
            for (int i = 0; i < TesztAdatok.RendSzamok.Length; i++)
            {
                l.Add(new Autos(TesztAdatok.RendSzamok[i],TesztAdatok.Mennyisegek[i],TesztAdatok.Fajtak[i]));              
            }
        }

        public void UjAutos(Autos autos)
        {
            l.Add(autos);
        }

        public override string ToString()
        {
            String s="";
            for (int i = 0; i < l.Count; i++)
            {
                s += (i + 1) + ". " + l[i];
            }

           // s += "A legtöbbet tankoló autós rendszáma: " + LegtobbetTankolo() + "\n";
           // s += "A kúton tankoló autók átlagosan ennyit költöttek: " + AtlagKoltseg() + "\n";

            return s;
        }

       public String LegtobbetTankolo()
        {
            int maxIndex = 0;
            for (int i = 0; i < l.Count - 1; i++)
            {
                if (l[i].Mennyiseg > l[maxIndex].Mennyiseg)
                {
                    maxIndex = i;
                }
            }
            return l[maxIndex].Rendszam;
        }

        public double AtlagKoltseg()
        {
            double osszeg = 0;
            for (int i = 0; i<l.Count-1; i++)
            {
                osszeg += l[i].Koltseg();
            }
            return osszeg / l.Count;
        }
    }
}
