using System;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Realizar un programa que acumule valores ingresados por teclado hasta ingresar 9999.
            // No sumar dicho valor. Imprimir el acumulado e indicar si es cero, mayor o menor a cero.

            int valor;
            int suma = 0;
            string linea;

            do
            {
                Console.Write("Ingrese un valor (9999 para finalizar): ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);

                if (valor != 9999)
                {
                    suma = suma + valor;
                }

            } while (valor != 9999);

            Console.WriteLine("Valor acumulado: " + suma);

            if (suma == 0)
            {
                Console.WriteLine("El valor es cero");
            }
            else
            {
                if (suma > 0)
                {
                    Console.WriteLine("El valor es mayor a cero");
                }
                else
                {
                    Console.WriteLine("El valor es menor a cero");
                }
            }

            Console.ReadKey();
        }
    }
}