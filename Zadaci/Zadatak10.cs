using System;
namespace Zadaci
{
    class Zadatak10
    {
        static void Main()
        {
            int broj;
            Console.WriteLine("Unesite prvi broj");
            broj = int.Parse(Console.ReadLine());
            int broj1;
            Console.WriteLine("Unesite drugi broj");
            broj1 = int.Parse(Console.ReadLine());
            int broj2;
            Console.WriteLine("Unesite treci broj");
            broj2 = int.Parse(Console.ReadLine());
            int broj3;
            Console.WriteLine("Unesite cetvrti broj");
            broj3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Rezultat a+b+c+d je: {0}", broj + broj1 + broj2 + broj3);
            Console.WriteLine("Rezultat a-b-c-d je: {0}", broj - broj1 - broj2 - broj3);
            Console.WriteLine("Rezultat a/b/c/d je: {0}", broj / broj1 / broj2 / broj3);
            Console.WriteLine("Rezultat a*b*c*d je: {0}", broj * broj1 * broj2 * broj3);
        }
    }
}