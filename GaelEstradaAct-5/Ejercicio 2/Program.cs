using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leer los lados de n triángulos e informar tipo y cantidades.

            int n;
            int equilatero = 0;
            int isosceles = 0;
            int escaleno = 0;
            string linea;

            Console.Write("Ingrese cantidad de triangulos: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            for (int i = 1; i <= n; i++)
            {
                int lado1, lado2, lado3;

                Console.Write("Ingrese lado 1: ");
                lado1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese lado 2: ");
                lado2 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese lado 3: ");
                lado3 = int.Parse(Console.ReadLine());

                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Equilatero");
                    equilatero++;
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Isosceles");
                    isosceles++;
                }
                else
                {
                    Console.WriteLine("Escaleno");
                    escaleno++;
                }
            }

            Console.WriteLine("Cantidad Equilateros: " + equilatero);
            Console.WriteLine("Cantidad Isosceles: " + isosceles);
            Console.WriteLine("Cantidad Escalenos: " + escaleno);

            if (equilatero < isosceles && equilatero < escaleno)
            {
                Console.WriteLine("El menor es: Equilatero");
            }
            else if (isosceles < escaleno)
            {
                Console.WriteLine("El menor es: Isosceles");
            }
            else
            {
                Console.WriteLine("El menor es: Escaleno");
            }

            Console.ReadKey();
        }
    }
}
