using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzinkutOOP
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

        public Autosok(int max)
        {
            l = new List<Autos>();
            Console.Write("Adja meg a tankoló autósok adatait! \n(Ha nincs több autós, adjon meg üres rendszámot!)\n\n");
            Autos a;
            int db = 0;
            while (db < max)
            {
                a = new Autos();
                l.Add(a);
                db++;
            }
        }

        public override string ToString()
        {
            String s = "\nAz autósok adatai\n";
            for (int i = 0; i < l.Count; i++)
            {
                s += (i + 1) + ". autós adatai: " + l[i];
            }

            s += "A legtöbbet tankoló autós rendszáma: " + LegtobbetTankolo() + "\n";
            s += "A kúton tankoló autók átlagosan ennyit költöttek: " + AtlagKoltseg() + "\n";

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
