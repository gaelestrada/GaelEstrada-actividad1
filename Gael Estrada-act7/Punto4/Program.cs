// 4- Cargar un vector de 10 elementos y verificar posteriormente
// si el mismo está ordenado de menor a mayor y de mayor a menor.

using System;

namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese valor: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool ascendente = true;
            bool descendente = true;

            for (int i = 0; i < 9; i++)
            {
                if (vector[i] >= vector[i + 1])
                {
                    ascendente = false;
                }

                if (vector[i] <= vector[i + 1])
                {
                    descendente = false;
                }
            }

            if (ascendente)
            {
                Console.WriteLine("El vector está ordenado de menor a mayor");
            }
            else
            {
                if (descendente)
                {
                    Console.WriteLine("El vector está ordenado de mayor a menor");
                }
                else
                {
                    Console.WriteLine("El vector no está ordenado");
                }
            }
            Console.ReadKey();
        }
    }
}
