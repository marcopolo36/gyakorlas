using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzinkutOOP
{
    static class Beolvas
    {
        private static bool joRendszam(string rendszam)
        {
            if (rendszam.Length != 7)
            {
                return false;
            }
            else
            {
                if (rendszam[3] != '-')
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (!Char.IsLetter(rendszam[i])) {
                            return false;
                        }
                    }
                    for (int i = 4; i < 7; i++)
                    {
                        if (!Char.IsDigit(rendszam[i])) {
                            return false;
                        }
                    }

                }
            }

            return true;
        }

        public static String RendszamBeolvas()  
        {
            string r;
            Console.Write("A következő autós adatai:\n\tRendszám: ");

            r = Console.ReadLine();
            if (joRendszam(r))
            {
                return r;
            }
            else
            {
                return RendszamBeolvas();
            }
        }

        public static double MennyisegBeolvas()
        {
            string s = "";
            double d = 0;
            Console.Write("\tTankolt benzin mennyisége (l): ");
            s = Console.ReadLine();
            if (!double.TryParse(s, out d) && d <= 0)
            {
                Console.Write("Hibás adat !");
                d = MennyisegBeolvas();
            }
            return d;
        }

        public static byte FajtaBeolvas()
        {
            string r;
            int d;
            Console.Write("\tTankolt benzin fajtája (0 - Normál, 1- Super, 2 -Extra): ");
            r = Console.ReadLine();
 

            if (int.TryParse(r, out d) && (d == 0 || d == 1 || d == 2))
            { 
               return byte.Parse(r);   
            }
            Console.Write("Rossz érték! 0 vagy 1 vagy 2 érték fogadható csak el!\n");
            return FajtaBeolvas();
        }
    }
}
