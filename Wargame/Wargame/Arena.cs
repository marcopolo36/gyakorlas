using System;
using System.Collections.Generic;

namespace Wargame
{
    //ez az osztály felügyeli a harcokat és harcosokat
    class Arena
    {
        //random típusú mező

        private Random r;
        private List <Harcos> harcosok;

        public Random R
        {
            get
            {
                return r;
            }

        }

        internal List<Harcos> Harcosok
        {
            get
            {
                return harcosok;
            }

        }

        //lista mező, amiben a harcosokat tároljuk - használhatunk tömböt is, ha lista még nem volt


        //csak olvasható tulajdonság

        //konstruktor
        public Arena( )
        {
            this.harcosok = new List<Harcos>();
        }

        //metódusok

        public void HarcosHozzadasa(int eletero, string nev, int sebzes, int vedekezes)
        {

            Harcos egy_harcos = new Harcos(eletero, nev, sebzes, vedekezes);
            this.harcosok.Add(egy_harcos);
            Console.WriteLine(egy_harcos);
        }

        public void HarcosTorlese(Harcos harcos)
        {
            this.harcosok.Remove(harcos);
            Console.WriteLine(harcos);
        }

    }
}