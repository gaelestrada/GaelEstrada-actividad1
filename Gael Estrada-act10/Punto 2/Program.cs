// Punto 2:
// Crear una matriz de n * m filas (cargar n y m por teclado).
// Intercambiar la primer fila con la segunda.
// Imprimir luego la matriz.

using System;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas;
            int columnas;

            Console.Write("Ingrese cantidad de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            // Carga de matriz
            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    Console.Write("Ingrese valor: ");
                    matriz[fila, columna] = int.Parse(Console.ReadLine());
                }
            }

            // Intercambio de filas
            for (int columna = 0; columna < columnas; columna++)
            {
                int aux = matriz[0, columna];
                matriz[0, columna] = matriz[1, columna];
                matriz[1, columna] = aux;
            }

            Console.WriteLine("Matriz modificada:");

            // Mostrar matriz
            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    Console.Write(matriz[fila, columna] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
