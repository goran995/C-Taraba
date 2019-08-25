using System;
namespace Zadaci
{
    class Zadatak4
    {
        static void Main()
        {
            string ime_prezime;
            Console.WriteLine("unesite Ime i Prezime");
            ime_prezime = Console.ReadLine();
            string pol;
            Console.WriteLine("Unesite Pol");
            pol = Console.ReadLine();
            int godine;
            Console.WriteLine("Unesite Godine:");
            godine = int.Parse(Console.ReadLine());
            Console.WriteLine("Vi ste: {0} ,", ime_prezime);
            Console.Write("Pol: {0} , Imate: {1} Godina", pol, godine);
        }
    }
}