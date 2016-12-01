using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wargame
{
    //A class kulcsszóval vezetünk be egy osztályt.
    //Az osztály egy újrafelhasználható leírás. Minden példányosításakor egy ugyanolyan tudású 
    //objektum jön létre a memóriában. Az osztály minden példánya ugyanazokkal az adattároló 
    //rekeszekkel (mező) és képességekkel (metódus) rendelkezik. A konkrét adatok különbözőek 
    //lehetnek minden egyes példányban.
    class Harcos
    {
        //mezők - adattároló tagok. Mindegyik harcos saját értékekkel rendelkezhet.
        //private láthatóság - csak a harcos maga férhet hozzá a mezőhöz, kívülről nem lehet se lekérdezni, se be/átállítani
        //Ha az osztályon belül nem írsz láthatóságot valamire, az alapértelmezetten private lesz.
        private int eletero;
        private string nev;
        private int sebzes;
        private int vedekezes;

        public int Eletero
        {
            get
            {
                return eletero;
            }

            set
            {
                eletero = value;
            }
        }

        public string Nev
        {
            get
            {
                return nev;
            }

        }

        public int Sebzes
        {
            get
            {
                return sebzes;
            }
            
        }

        public int Vedekezes
        {
            get
            {
                return vedekezes;
            }

        }






        //tulajdonságok - ellenőrzött hozzáférés a mezőkhöz. A get és set tulajdonképpen metódusok, olyan kódot írunk beléjük, amilyet akarunk.




        //konstruktor metódus, amivel létrehozható egy példány, és beállíthatók az adott harcos értékei
        public Harcos (int eletero, string nev, int sebzes, int vedekezes)
        {
            this.eletero = eletero;
            this.nev = nev;
            this.sebzes = sebzes;
            this.vedekezes = vedekezes;
        }

        //A ToString minden objektumon (példányon) hívható, visszaad egy szöveget.
        //Az override kulcsszó itt fontos - jelentését később tárgyaljuk

        public override string ToString()
        {
            return "Életerő: " + eletero + " Név:" + nev + " Sebzés:" + sebzes + " Védekezés:" + vedekezes;
        }


        //Saját metódus - megnöveli a támadóértéket, csökkenti a védekezőértéket
        public void InkábbTámadj()
        {
            //ha 0-ra csökkenne a védekezés, nem hajtjuk végre a módosításokat
            if (vedekezes == 1) {
                return;
            }

            sebzes += 1;
            vedekezes -= 1;

        }

        //Saját metódus - megnöveli a védekezőértéket, csökkenti a támadóértéket
        public void InkábbVédekezz()
        {
            //ha 0-ra csökkenne a támadás, nem hajtjuk végre a módosításokat
            if (sebzes == 1)
            {
                return;
            }

            vedekezes += 1;
            sebzes -= 1;

        }
    }
}