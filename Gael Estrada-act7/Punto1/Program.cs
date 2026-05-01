// 1- Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
// El valor acumulado de todos los elementos del vector.
// El valor acumulado de los elementos del vector que sean mayores a 36.
// Cantidad de valores mayores a 50.

using System;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[8];

            int sumaTotal = 0;
            int sumaMayores36 = 0;
            int cantidadMayores50 = 0;

            for (int i = 0; i < 8; i++)
            {
                Console.Write("Ingrese el valor " + (i + 1) + ": ");
                vector[i] = Convert.ToInt32(Console.ReadLine());

                sumaTotal += vector[i];

                if (vector[i] > 36)
                {
                    sumaMayores36 += vector[i];
                }

                if (vector[i] > 50)
                {
                    cantidadMayores50++;
                }
            }

            Console.WriteLine("Suma total del vector: " + sumaTotal);
            Console.WriteLine("Suma de los mayores a 36: " + sumaMayores36);
            Console.WriteLine("Cantidad de valores mayores a 50: " + cantidadMayores50);

            Console.ReadKey();
        }
    }
}
