// Punto 1:
// Crear una matriz de 2 filas y 5 columnas.
// Realizar la carga de componentes por columna
// e imprimir luego la matriz.

using System;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[2, 5];

            // Carga por columna
            for (int columna = 0; columna < 5; columna++)
            {
                for (int fila = 0; fila < 2; fila++)
                {
                    Console.Write("Ingrese valor para fila " + fila + " columna " + columna + ": ");
                    matriz[fila, columna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz cargada:");

            // Mostrar matriz
            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    Console.Write(matriz[fila, columna] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
