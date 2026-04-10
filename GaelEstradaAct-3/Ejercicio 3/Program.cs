using System;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Se ingresan por teclado tres números, si todos los valores ingresados
            // son menores a 10, imprimir "Todos los números son menores a diez"

            int num1, num2, num3;
            string linea;

            Console.Write("Ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese el tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 < 10 && num2 < 10 && num3 < 10)
            {
                Console.Write("Todos los numeros son menores a diez");
            }

            Console.ReadKey();
        }
    }
}
