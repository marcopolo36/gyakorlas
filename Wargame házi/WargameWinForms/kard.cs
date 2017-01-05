using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WargameWinForms
{
    class Kard : Wargame.Fegyver
    {

        public override int Sebez()
        {
            Wargame.Napló.Naplózás($"A karddal sebzett: {sebzes} pontot");
            return sebzes;
        }

    }
}
