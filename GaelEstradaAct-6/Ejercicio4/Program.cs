// Punto 4: Implementar la clase Operaciones. Cargar dos valores enteros y calcular
// suma, resta, multiplicación y división, cada una en un método.

using System;

namespace Ejercicio4
{
    class Operaciones
    {
        int valor1, valor2;

        public void Cargar()
        {
            Console.Write("Ingrese el primer valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
        }

        public void Suma()
        {
            int suma = valor1 + valor2;
            Console.WriteLine("Suma: " + suma);
        }

        public void Resta()
        {
            int resta = valor1 - valor2;
            Console.WriteLine("Resta: " + resta);
        }

        public void Multiplicacion()
        {
            int multiplicacion = valor1 * valor2;
            Console.WriteLine("Multiplicación: " + multiplicacion);
        }

        public void Division()
        {
            if (valor2 != 0)
            {
                int division = valor1 / valor2;
                Console.WriteLine("División: " + division);
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.Cargar();
            op.Suma();
            op.Resta();
            op.Multiplicacion();
            op.Division();

            Console.ReadKey();
        }
    }
}
