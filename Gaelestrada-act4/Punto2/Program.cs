using System;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.

            int x = 1;

            while (x <= 25)
            {
                Console.WriteLine(x * 11);
                x = x + 1;
            }

            Console.ReadKey();
        }
    }
}