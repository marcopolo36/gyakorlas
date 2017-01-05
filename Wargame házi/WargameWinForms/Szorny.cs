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
            if (nev == String.Empty || klan == String.Empty || OsszErtek < 6 || OsszErtek > 12 )
            {
                throw new ArgumentException();
            }
            if (nev == null || klan == null)
            {
                throw new ArgumentNullException();
            }
            this.nev = nev;
            this.klan = klan;
            this.eletero = r.Next(4,7);
            this.sebzes = r.Next(3, (OsszErtek - 3)+1);
            this.Vedekezes1 = OsszErtek - this.sebzes;
            Fegyver = new Ij();
        }

        public override void InkábbTámadj()
        {
            //ha 0-ra csökkenne a védekezés, nem hajtjuk végre a módosításokat
            if (Vedekezes1 == 1)
            {
                return;
            }

            sebzes += 2;
            Vedekezes1 -= 1;
            Wargame.Napló.Naplózás($"{nev} inkább támadott, sebzése +2, védekezése -1 ponttal változott.");

        }

        //Saját metódus - megnöveli a védekezőértéket, csökkenti a támadóértéket
        public override void InkábbVédekezz()
        {
            //ha 0-ra csökkenne a támadás, nem hajtjuk végre a módosításokat
            if (sebzes == 1)
            {
                return;
            }

            Vedekezes1 += 2;
            sebzes -= 1;
            Wargame.Napló.Naplózás($"{nev} inkább védekezett, védekezése +2, sebzése -1 ponttal változott.");

        }
    }
}
