// Punto 1: Registrar nombres y notas de 6 estudiantes.
// Mostrar el mayor y menor, y si se repiten esas notas.

using System;

namespace Punto1
{
    class Program
    {
        static string[] nombres = new string[6];
        static int[] notas = new int[6];

        static void Cargar()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese nota: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Procesar()
        {
            int mayor = notas[0];
            int menor = notas[0];
            int posMayor = 0;
            int posMenor = 0;

            for (int i = 1; i < 6; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor = notas[i];
                    posMayor = i;
                }

                if (notas[i] < menor)
                {
                    menor = notas[i];
                    posMenor = i;
                }
            }

            int contMayor = 0;
            int contMenor = 0;

            for (int i = 0; i < 6; i++)
            {
                if (notas[i] == mayor)
                {
                    contMayor++;
                }

                if (notas[i] == menor)
                {
                    contMenor++;
                }
            }

            Console.WriteLine("Mayor nota: " + nombres[posMayor] + " - " + mayor);
            Console.WriteLine("Menor nota: " + nombres[posMenor] + " - " + menor);

            if (contMayor > 1)
            {
                Console.WriteLine("La nota maxima se repite");
            }

            if (contMenor > 1)
            {
                Console.WriteLine("La nota minima se repite");
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
