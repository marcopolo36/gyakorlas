using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzinkutWinform
{
    static class TesztAdatok
    {
        private static readonly double[] arak = { 330, 360, 400 };
        private static readonly String[] rendSzamok = { "ABC-123", "XYZ-456", "MNO-986", "PQR-321", "ASD-678" };
        private static readonly double[] mennyisegek = { 13.6, 34.9, 27.8, 45.7, 19.8 };
        private static readonly byte[] fajtak = { 0, 1, 2, 2, 0 };

        private static readonly String[] fajtaNevek = { "Normál", "Super", "Extra" };


       public static String[] RendSzamok
        {
            get { return rendSzamok;}
        }

        public static double[] Mennyisegek
        {
            get { return mennyisegek; }
        }

        public static byte[] Fajtak
        {
            get { return fajtak; }
        }

        public static String[] FajtaNevek
        {
            get { return fajtaNevek; }
        }

        public static double[] Arak
        {
            get
            {
                return arak;
            }
        }
    }
}
