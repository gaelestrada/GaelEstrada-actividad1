// 4. Cargar nombres de 5 países y en otro vector la cantidad de habitantes.
// Ordenar alfabéticamente e imprimir. Luego ordenar por habitantes (mayor a menor).

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

            // Ordenar alfabéticamente
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (paises[i].CompareTo(paises[j]) > 0)
                    {
                        string auxP = paises[i];
                        paises[i] = paises[j];
                        paises[j] = auxP;

                        int auxH = habitantes[i];
                        habitantes[i] = habitantes[j];
                        habitantes[j] = auxH;
                    }
                }
            }

            Console.WriteLine("Orden alfabetico:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(paises[i] + " - " + habitantes[i]);
            }

            // Ordenar por habitantes (mayor a menor)
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (habitantes[i] < habitantes[j])
                    {
                        int auxH = habitantes[i];
                        habitantes[i] = habitantes[j];
                        habitantes[j] = auxH;

                        string auxP = paises[i];
                        paises[i] = paises[j];
                        paises[j] = auxP;
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
