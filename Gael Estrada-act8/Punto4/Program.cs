// 4. Cargar nombres de 5 países y en otro vector la cantidad de habitantes.
// Ordenar alfabéticamente e imprimir.
// Luego ordenar por habitantes (mayor a menor).

using System;

namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] paises = new string[5];
            int[] habitantes = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese pais: ");
                paises[i] = Console.ReadLine();

                Console.Write("Ingrese habitantes: ");
                habitantes[i] = int.Parse(Console.ReadLine());
            }

            // Orden alfabético
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (paises[i].CompareTo(paises[j]) > 0)
                    {
                        string auxPais = paises[i];
                        paises[i] = paises[j];
                        paises[j] = auxPais;

                        int auxHabitantes = habitantes[i];
                        habitantes[i] = habitantes[j];
                        habitantes[j] = auxHabitantes;
                    }
                }
            }

            Console.WriteLine("Orden alfabetico:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(paises[i] + " - " + habitantes[i]);
            }

            // Orden por habitantes (mayor a menor)
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (habitantes[i] < habitantes[j])
                    {
                        int auxHabitantes = habitantes[i];
                        habitantes[i] = habitantes[j];
                        habitantes[j] = auxHabitantes;

                        string auxPais = paises[i];
                        paises[i] = paises[j];
                        paises[j] = auxPais;
                    }
                }
            }

            Console.WriteLine("Orden por habitantes:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(paises[i] + " - " + habitantes[i]);
            }
            Console.ReadKey();
        }
    }
}
