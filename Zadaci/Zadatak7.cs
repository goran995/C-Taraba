using System;
namespace Zadaci
{
    class Zadatak7
    {
        static void Main()
        {
            int broj;
            Console.Write("Unesite broj:");
            broj = int.Parse(Console.ReadLine());
            int broj1;
            Console.Write("Unesite drugi broj:");
            broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Rezultat oduzimanja je: {0}", broj - broj1);
        }
    }
}