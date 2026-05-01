// Punto 3:
// Crear una matriz de n * m filas (cargar n y m por teclado).
// Imprimir los cuatro valores que se encuentran en los vértices de la matriz.

using System;

namespace Punto3
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

            Console.WriteLine("Valores de los vertices:");

            Console.WriteLine("Superior izquierdo: " + matriz[0, 0]);
            Console.WriteLine("Superior derecho: " + matriz[0, columnas - 1]);
            Console.WriteLine("Inferior izquierdo: " + matriz[filas - 1, 0]);
            Console.WriteLine("Inferior derecho: " + matriz[filas - 1, columnas - 1]);

            Console.ReadKey();
        }
    }
}
