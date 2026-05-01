// 3. Cargar un vector de n elementos enteros y ordenarlo.

using System;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Ingrese cantidad de elementos: ");
            n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese valor: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        int aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }

            Console.WriteLine("Vector ordenado:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vector[i]);
            }

            Console.ReadKey();
        }
    }
}
