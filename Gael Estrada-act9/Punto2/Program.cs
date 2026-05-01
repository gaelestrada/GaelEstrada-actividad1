// Punto 2: Vendedores y ventas.
// Ordenar de mayor a menor y mostrar el que menos vendió.

using System;

namespace Punto2
{
    class Program
    {
        static string[] nombres = new string[5];
        static int[] ventas = new int[5];

        static void Cargar()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ventas: ");
                ventas[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Ordenar()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (ventas[i] < ventas[j])
                    {
                        int auxVenta = ventas[i];
                        ventas[i] = ventas[j];
                        ventas[j] = auxVenta;

                        string auxNombre = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxNombre;
                    }
                }
            }
        }

        static void Mostrar()
        {
            Console.WriteLine("Lista ordenada:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nombres[i] + " - " + ventas[i]);
            }

            Console.WriteLine("El que menos vendio fue: " + nombres[4]);
        }

        static void Main(string[] args)
        {
            Cargar();
            Ordenar();
            Mostrar();
            Console.ReadKey();
        }
    }
}
