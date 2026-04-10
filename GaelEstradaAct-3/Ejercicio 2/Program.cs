using System;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Se ingresan tres valores por teclado, si todos son iguales se imprime
            // la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.

            int num1, num2, num3, suma, resultado;
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

            if (num1 == num2 && num1 == num3)
            {
                suma = num1 + num2;
                resultado = suma * num3;

                Console.Write("La suma de los primeros es : " + suma);
                Console.Write("El resultado es: " + resultado);
            
            }

            Console.ReadKey();
        }
    }
}
