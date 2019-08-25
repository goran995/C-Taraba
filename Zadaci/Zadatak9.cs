using System;
namespace Zadaci
{
    class Zadatak9
    {
        static void Main()
        {
            int broj;
            int broj1;
            int broj2;
            Console.WriteLine("Unesite prvi broj: ");
            broj = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite treci broj: ");
            broj2 = int.Parse(Console.ReadLine());
            int sabiranje = broj + broj1;

            Console.WriteLine("Rezultat operacije a+b*c: {0}", sabiranje * broj2);

        }
    }
}