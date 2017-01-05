using System;

namespace Wargame
{
    class Program
    {
        
        static void Main()
        {
            Arena arena = new Arena();
            Random _r = new Random();
            //az egyszerűség kedvéért itt nem beolvasunk, rögtön létrehozzuk a 
            /*
            arena.HarcosHozzadasa("Arnold", 5, _r.Next(2, 5), _r.Next(2, 5));
            arena.HarcosHozzadasa("Bruce", 5, _r.Next(2, 5), _r.Next(2, 5));
            arena.HarcosHozzadasa("Clint", 5, _r.Next(2, 5), _r.Next(2, 5));
            arena.HarcosHozzadasa("Daniel", 5, _r.Next(2, 5), _r.Next(2, 5));
            */

            //a csata addig tart, amíg van túlélő, elég egyszer meghívni
            arena.Csata();

            Console.ReadLine();
        }
    }
}