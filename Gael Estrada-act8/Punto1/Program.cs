// 1. Cargar un vector de n elementos.
// Imprimir el menor y un mensaje si se repite dentro del vector.

using System;

namespace Punto1
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

            int menor = vector[0];

            for (int i = 1; i < n; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }

            int contador = 0;

            for (int i = 0; i < n; i++)
            {
                if (vector[i] == menor)
                {
                    contador++;
                }
            }

            Console.WriteLine("El menor valor es: " + menor);

            if (contador > 1)
            {
                Console.WriteLine("El menor se repite");
            }

            Console.ReadKey();
        }
    }
}
