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
            if ( nev == String.Empty || nemzetiseg == String.Empty)
            {
                throw new ArgumentException();
            }
            if (nev == null || nemzetiseg == null)
            {
                throw new ArgumentNullException();
            }
            this.nev = nev;
            this.nemzetiseg = nemzetiseg;
            this.eletero = r.Next(4,7);
            this.sebzes = r.Next(3, 6);
            this.vedekezes = r.Next(3, 6);
            fegyver = new Kard();

            if (tamadoE == true)
            {
                this.sebzes += 4;
            }
            else
            {
                this.vedekezes += 4;
            }
        }

        public override void InkábbTámadj()
        {
            //ha 0-ra csökkenne a védekezés, nem hajtjuk végre a módosításokat
            if (vedekezes == 1)
            {
                return;
            }
            int novekmeny = r.Next(1, 5);
            sebzes += novekmeny;
            vedekezes -= 1;
            Wargame.Napló.Naplózás($"{nev} inkább támadott, sebzése {novekmeny}, védekezése -1 ponttal változott.");

        }

        //Saját metódus - megnöveli a védekezőértéket, csökkenti a támadóértéket
        public override void InkábbVédekezz()
        {
            //ha 0-ra csökkenne a támadás, nem hajtjuk végre a módosításokat
            if (sebzes == 1)
            {
                return;
            }

            int novekmeny = r.Next(1, 5);
            vedekezes += novekmeny;
            sebzes -= 1;
            Wargame.Napló.Naplózás($"{nev} inkább védekezett, védekezése {novekmeny}, sebzése -1 ponttal változott.");
        }

    }
}
