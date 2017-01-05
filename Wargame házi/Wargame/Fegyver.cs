using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wargame
{
    abstract class Fegyver
    {
        protected int sebzes;

        public int Sebzes
        {
            get
            {
                return sebzes;
            }
        }

        public abstract int Sebez();

        public bool SebzesModositas(int szam)
        {
            if (szam > -2 && szam < 2 && this.sebzes + szam >= 1)
            {
                this.sebzes += szam;
                Wargame.Napló.Naplózás($"Sebzés módosult: {szam} ponttal");
                return true;
            }
            Wargame.Napló.Naplózás($"Sebzés nem változott");
            return false;
        }
    }
}
