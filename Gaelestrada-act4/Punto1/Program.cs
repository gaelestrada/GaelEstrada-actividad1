using System;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500,
            // realizar un programa que lea los sueldos e informe cuántos cobran entre 100 y 300,
            // cuántos cobran más de 300 y el gasto total en sueldos.

            int n, x;
            float sueldo;
            int entre100y300 = 0;
            int mas300 = 0;
            float totalSueldos = 0;
            string linea;

            Console.Write("Ingrese la cantidad de empleados: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            x = 1;
            while (x <= n)
            {
                Console.Write("Ingrese sueldo: ");
                linea = Console.ReadLine();
                sueldo = float.Parse(linea);

                if (sueldo >= 100 && sueldo <= 300)
                {
                    entre100y300++;
                }
                else
                {
                    if (sueldo > 300)
                    {
                        mas300++;
                    }
                }

                totalSueldos = totalSueldos + sueldo;
                x = x + 1;
            }

            Console.WriteLine("Cantidad entre 100 y 300: " + entre100y300);
            Console.WriteLine("Cantidad mayor a 300: " + mas300);
            Console.WriteLine("Gasto total en sueldos: " + totalSueldos);

            Console.ReadKey();
        }
    }
}