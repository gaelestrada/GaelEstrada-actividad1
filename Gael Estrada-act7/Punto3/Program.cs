// 3- Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de un videojuego.
// Mostrar la puntuación más alta y la más baja.
// Calcular el promedio de puntuación.
// Contar cuántas veces superó los 500 puntos.

using System;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] puntuaciones = new int[6];

            int suma = 0;
            int mayor = 0;
            int menor = 0;
            int mayores500 = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese puntuación: ");
                puntuaciones[i] = Convert.ToInt32(Console.ReadLine());

                suma += puntuaciones[i];

                if (i == 0)
                {
                    mayor = puntuaciones[i];
                    menor = puntuaciones[i];
                }
                else
                {
                    if (puntuaciones[i] > mayor)
                    {
                        mayor = puntuaciones[i];
                    }

                    if (puntuaciones[i] < menor)
                    {
                        menor = puntuaciones[i];
                    }
                }

                if (puntuaciones[i] > 500)
                {
                    mayores500++;
                }
            }

            double promedio = suma / 6.0;

            Console.WriteLine("Puntuación más alta: " + mayor);
            Console.WriteLine("Puntuación más baja: " + menor);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Veces que superó 500 puntos: " + mayores500);
            Console.ReadKey();
        }
    }
}
