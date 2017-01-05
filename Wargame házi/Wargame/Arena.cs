using System;
using System.Collections.Generic;

namespace Wargame
{
    //ez az osztály felügyeli a harcokat és harcosokat
    class Arena
    {
        public class CsataNemIndithatoException : System.Exception
        {   
            private string message = "A csata nem indítható!";

            public override string Message { get { return message; } }
            
            public CsataNemIndithatoException() 
            {}
        }
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
            this.r = new Random();
        }

        //metódusok

        public void HarcosHozzadasa(Harcos harcos)
        {
            this.harcosok.Add(harcos);
            Napló.Naplózás($"Hozzáadva: {harcos.ToString()}");
        }

       /* public void HarcosHozzadasa(string nev, int eletero, int sebzes, int vedekezes)
        {

            Harcos harcos = new Harcos(nev, eletero, sebzes, vedekezes);
            this.harcosok.Add(harcos);
            Napló.Naplózás($"Hozzáadva: {harcos.ToString()}");
        }*/

        public void HarcosTorlese(Harcos harcos)
        {
            this.harcosok.Remove(harcos);
            Napló.Naplózás($"Törölve: {harcos.ToString()}");
        }

        public void Csata()
        {   
            if (harcosok.Count < 2)
            {
                throw new CsataNemIndithatoException();
            }

            Napló.Naplózás("Elindult a csata!");
            int kör = 0;
            //addig tart a csata, amíg van túlélő.
            while (harcosok.Count > 1 && kör < 100)
            {
                Napló.Naplózás($"--- Új kör: {kör++}. ---");
                //kiválasztjuk a lista első két harcosát
                Harcos h1 = harcosok[0];
                Napló.Naplózás($"Az első harcos: {h1.ToString()}");
                Harcos h2 = harcosok[1];
                Napló.Naplózás($"A második harcos: {h2.ToString()}");

                //az egyik harcos odacsap a másiknak
                Odacsapás(h1, h2);

                if (h2.Eletero < 1)
                {
                    //ha ettől a másik meghalt, eltávolítjuk a listából - itt utólag kitérni a GC működésére
                    harcosok.Remove(h2);
                    Napló.Naplózás($"{h2.Nev} elpatkolt.");
                }
                else
                {
                    //ha nem halt meg, visszacsap
                    Odacsapás(h2, h1);
                    if (h1.Eletero < 1)
                    {
                        harcosok.Remove(h1);
                        Napló.Naplózás($"{h1.Nev} elpatkolt.");
                    }
                }
            }
            if ( harcosok.Count != 1)
            {
                Napló.Naplózás("Túl hosszú ideig tartott a csata, eluntuk...");
            }
            else
            {
                Napló.Naplózás($"Véget ért a csata, a győztes: {harcosok[0].ToString()}!");
            }

        }

        //private metódus: csak az Arena osztályból lehet hívni.
        private void Odacsapás(Harcos támadó, Harcos védő)
        {
            //Később, kivételkezelésnél: null-ellenőrzés és ellenőrzés, hogy a két harcos nem ugyanaz-e (equals override is lehet)
            //a sebzések és védekezések egy 0-4, 0-2 értékkel nőnek az alappontokhoz képest
            int támadás = támadó.Fegyver.Sebez() + r.Next(0, 4);
            Napló.Naplózás($"{támadó.Nev} támadása: {támadás} pont.");

            int védés = védő.Vedekezes + r.Next(0, 2);
            Napló.Naplózás($"{védő.Nev} védése: {védés} pont.");

            if (támadás > védés)
            {
                védő.Eletero--;
                Napló.Naplózás($"{védő.Nev} vesztett egy életpontot.");
                //ha fogy az életpont, h2 agresszívabb lesz
                védő.InkábbTámadj();
            }
            else
            {
                //ha sikeresen védte a támadást, még jobban fog védekezni
                védő.InkábbVédekezz();
            }
        }
    }

}
