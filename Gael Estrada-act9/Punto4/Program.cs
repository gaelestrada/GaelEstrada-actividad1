// Punto 4: Docentes y notas. Mayor, menor, ordenar y contar aprobados/desaprobados.

using System;

namespace Punto4
{
    class Program
    {
        static string[] nombres = new string[6];
        static int[] notas = new int[6];

        static void Cargar()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Nota: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Ordenar()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    if (notas[i] < notas[j])
                    {
                        int auxN = notas[i];
                        notas[i] = notas[j];
                        notas[j] = auxN;

                        string auxNom = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxNom;
                    }
                }
            }
        }

        static void Procesar()
        {
            Console.WriteLine("Mayor: " + nombres[0] + " - " + notas[0]);
            Console.WriteLine("Menor: " + nombres[5] + " - " + notas[5]);

            int aprobados = 0;
            int desaprobados = 0;

            for (int i = 0; i < 6; i++)
            {
                if (notas[i] >= 6)
                    aprobados++;
                else
                    desaprobados++;
            }

            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Desaprobados: " + desaprobados);
        }

        static void Main(string[] args)
        {
            Cargar();
            Ordenar();
            Procesar();
            Console.ReadKey();
        }
    }
}
