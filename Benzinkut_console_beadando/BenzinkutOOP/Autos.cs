using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzinkutOOP
{
    class Autos
    {
        private String rendszam;
        private double mennyiseg;
        private byte fajta;

        public String Rendszam
        {
            get { return rendszam; }
        }

        public double Mennyiseg
        {
            get { return mennyiseg; }
        }

        public byte Fajta
        {
            get
            {
                return fajta;
            }

        }

        public Autos(String rendszam, double mennyiseg, byte fajta)
        {
            this.rendszam = rendszam;
            this.mennyiseg = mennyiseg;
            this.fajta = fajta;
        }

        public Autos()
        {
            this.rendszam = Beolvas.RendszamBeolvas();
            if (this.rendszam != "")
            {
                this.mennyiseg = Beolvas.MennyisegBeolvas();
                this.fajta = Beolvas.FajtaBeolvas();
            }
        }

        public override string ToString()
        {
            return "\n\tRendszám: " + rendszam + "\n" +
                    "\tMennyiség: " + mennyiseg + " l" + "\n" +
                    "\tFajta:" + FajtaToString(fajta) + "\n\n";
        }

        private String FajtaToString(byte fajta)
        {
            return TesztAdatok.FajtaNevek[fajta];
        }

        
        public double Koltseg()
        {
            double ertek = 0;
            if (this.mennyiseg > 50)
            {
                ertek = (50 * TesztAdatok.Arak[this.fajta]) + ((this.mennyiseg - 50) * (TesztAdatok.Arak[this.fajta])) * 0.8;
            }
            else
            {
                ertek = this.mennyiseg * TesztAdatok.Arak[this.fajta];
            }

            return ertek;
        }
    }
}
