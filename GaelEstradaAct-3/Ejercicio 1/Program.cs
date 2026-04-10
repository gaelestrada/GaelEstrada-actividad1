using System;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Realizar un programa que pida cargar una fecha cualquiera,
            // luego verificar si dicha fecha corresponde a Navidad.

            int dia, mes;
            string linea;

            Console.Write("Ingrese el dia: ");
            linea = Console.ReadLine();
            dia = int.Parse(linea);

            Console.Write("Ingrese el mes: ");
            linea = Console.ReadLine();
            mes = int.Parse(linea);

            if (dia == 25 && mes == 12)
            {
                Console.Write("Es Navidad");
            }
            else
            {
                Console.Write("No es Navidad");
            }

            Console.ReadKey();
        }
    }
}
