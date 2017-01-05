using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WargameWinForms
{
    class Ij : Wargame.Fegyver
    {
        public override int Sebez()
        {
            Wargame.Napló.Naplózás($"Az íjjal sebzett: {sebzes} pontot");
            return sebzes;
        }
    }
}
