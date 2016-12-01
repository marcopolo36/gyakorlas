using System;

namespace Wargame
{
    class Program
    {
        
        static void Main()
        {
            Aréna aréna = new Aréna();
            Random _r = new Random();
            //az egyszerűség kedvéért itt nem beolvasunk, rögtön létrehozzuk a harcosokat
            aréna.HarcosHozzáadása("Arnold", 5, _r.Next(2, 5), _r.Next(2, 5));
            aréna.HarcosHozzáadása("Bruce", 5, _r.Next(2, 5), _r.Next(2, 5));
            aréna.HarcosHozzáadása("Clint", 5, _r.Next(2, 5), _r.Next(2, 5));
            aréna.HarcosHozzáadása("Daniel", 5, _r.Next(2, 5), _r.Next(2, 5));

            //a csata addig tart, amíg van túlélő, elég egyszer meghívni
            aréna.Csata();

            Console.ReadLine();
        }
    }
}