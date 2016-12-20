using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WargameWinForms
{
    static class Szornynevek
    {
        private static string[] elejeA= { "A", "B", "C", "D", "E" };
        private static string[] vegeB = { "asd", "ert", "wer", "tzu", "ikl", "olp" };
        static List<string> nevek = new List<string>();
        static Random r = new Random();

        static Szornynevek()
        {
            UjraGeneral();
        }

        public static string NevGeneralas()
        {
            if (nevek.Count==0)
            { 
                UjraGeneral();
            }
            String Vissza = nevek[r.Next(0,nevek.Count)];
            nevek.Remove(Vissza);
            return Vissza;
        }

        private static void UjraGeneral()
        {
            int i;
            for (i = 0; nevek.Count<25; i++)
            {
                string A = elejeA[r.Next(0, elejeA.Length)];
                string B = vegeB[r.Next(0, vegeB.Length)];
                nevek.Add(A + "'" + B);
                nevek = nevek.Distinct().ToList();

            }
        }
    }
}
