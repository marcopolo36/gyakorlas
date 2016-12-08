using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WargameWinForms
{
    class Ember : Wargame.Harcos
    {

        private string nemzetiseg;
        private Random r = new Random();

        public string Nemzetiseg
        {
            get { return nemzetiseg; }
        }


        public Ember(string nev, string nemzetiseg, bool tamadoE)
        {
            this.nev = nev;
            this.nemzetiseg = nemzetiseg;
            this.eletero = r.Next(4,7);
            this.sebzes = r.Next(3, 6);
            this.vedekezes = r.Next(3, 6);

            if (tamadoE == true)
            {
                this.sebzes += 4;
            }
            else
            {
                this.vedekezes += 4;
            }
        }

    }
}
