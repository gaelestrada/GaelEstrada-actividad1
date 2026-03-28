using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Confeccionar un programa que permita ingresar un valor del 1 al 10
            // y mostrar la tabla de multiplicar del mismo (primeros 13 términos).

            int numero;
            string linea;

            Console.Write("Ingrese un numero del 1 al 10: ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            for (int i = 1; i <= 13; i++)
            {
                Console.WriteLine(numero * i);
            }

            Console.ReadKey();
        }
    }
}

