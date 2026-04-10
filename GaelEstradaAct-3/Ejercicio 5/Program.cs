
using System;

namespace Punto5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Escribir un programa que pida ingresar la coordenada de un punto en el plano,
            // dos valores enteros x e y (distintos a cero). Luego imprimir en que cuadrante se ubica.

            int x, y;
            string linea;

            Console.Write("Ingrese coordenada X: ");
            linea = Console.ReadLine();
            x = int.Parse(linea);

            Console.Write("Ingrese coordenada Y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);

            if (x > 0 && y > 0)
            {
                Console.Write("Primer Cuadrante");
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.Write("Segundo Cuadrante");
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        Console.Write("Tercer Cuadrante");
                    }
                    else
                    {
                        if (x > 0 && y < 0)
                        {
                            Console.Write("Cuarto Cuadrante");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
