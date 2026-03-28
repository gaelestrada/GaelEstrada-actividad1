using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cargar 10 valores e informar negativos, positivos,
            // múltiplos de 15 y suma de pares.

            int negativos = 0;
            int positivos = 0;
            int multiplos15 = 0;
            int sumaPares = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese un valor: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor < 0)
                {
                    negativos++;
                }
                else if (valor > 0)
                {
                    positivos++;
                }

                if (valor % 15 == 0)
                {
                    multiplos15++;
                }

                if (valor % 2 == 0)
                {
                    sumaPares = sumaPares + valor;
                }
            }

            Console.WriteLine("Cantidad negativos: " + negativos);
            Console.WriteLine("Cantidad positivos: " + positivos);
            Console.WriteLine("Cantidad multiplos de 15: " + multiplos15);
            Console.WriteLine("Suma de pares: " + sumaPares);

            Console.ReadKey();
        }
    }
}
