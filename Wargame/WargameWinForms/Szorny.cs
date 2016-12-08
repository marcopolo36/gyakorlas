using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WargameWinForms
{
    class Szorny : Wargame.Harcos
    {
        private string klan;
        private Random r = new Random();

        public string Klan
        {
            get { return klan; }
        }

        public Szorny( string nev, string klan, int OsszErtek )
        {
            this.nev = nev;
            this.klan = klan;
            this.eletero = r.Next(4,7);
            this.sebzes = r.Next(3, (OsszErtek - 3)+1);
            this.vedekezes = OsszErtek - this.sebzes;
        }
    }
}
