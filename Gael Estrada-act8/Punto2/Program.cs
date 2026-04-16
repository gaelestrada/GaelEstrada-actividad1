// 2. Definir un vector con nombres de 5 países y ordenarlos alfabéticamente.

using System;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] paises = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un pais: ");
                paises[i] = Console.ReadLine();
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (paises[i].CompareTo(paises[j]) > 0)
                    {
                        string aux = paises[i];
                        paises[i] = paises[j];
                        paises[j] = aux;
                    }
                }
            }

            Console.WriteLine("Paises ordenados:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(paises[i]);
            }

            Console.ReadKey();
        }
    }
}
