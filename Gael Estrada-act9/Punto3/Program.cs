// Punto 3: Atletas y tiempos.
// Promedio, mejor, peor y quienes superan el promedio.

using System;

namespace Punto3
{
    class Program
    {
        static string[] nombres = new string[5];
        static int[] tiempos = new int[5];

        static void Cargar()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Tiempo: ");
                tiempos[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Procesar()
        {
            int suma = 0;

            int mejor = tiempos[0];
            int peor = tiempos[0];

            int posMejor = 0;
            int posPeor = 0;

            for (int i = 0; i < 5; i++)
            {
                suma += tiempos[i];

                if (tiempos[i] < mejor)
                {
                    mejor = tiempos[i];
                    posMejor = i;
                }

                if (tiempos[i] > peor)
                {
                    peor = tiempos[i];
                    posPeor = i;
                }
            }

            double promedio = suma / 5.0;

            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Mejor tiempo: " + nombres[posMejor]);
            Console.WriteLine("Peor tiempo: " + nombres[posPeor]);

            Console.WriteLine("Superaron el promedio:");

            for (int i = 0; i < 5; i++)
            {
                if (tiempos[i] < promedio)
                {
                    Console.WriteLine(nombres[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Cargar();
            Procesar();
            Console.ReadKey();
        }
    }
}
