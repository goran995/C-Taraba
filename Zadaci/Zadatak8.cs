using System;
namespace Zadaci
{
    class Zadatak8
    {
        static void Main()
        {
            decimal a;
            decimal b;
            Console.Write("Unesite decimalni broj: ");
            a = decimal.Parse(Console.ReadLine());
            Console.Write("Unesite drugi decimalni broj: ");
            b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Rezultat deljenja je: {0}", a / b);
        }
    }
}