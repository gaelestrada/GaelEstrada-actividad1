using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Promedio de edades turno mañana, tarde y noche.

            int sumaManana = 0;
            int sumaTarde = 0;
            int sumaNoche = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Edad turno mañana: ");
                sumaManana += int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= 30; i++)
            {
                Console.Write("Edad turno tarde: ");
                sumaTarde += int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= 15; i++)
            {
                Console.Write("Edad turno noche: ");
                sumaNoche += int.Parse(Console.ReadLine());
            }

            float promedioManana = sumaManana / 20f;
            float promedioTarde = sumaTarde / 30f;
            float promedioNoche = sumaNoche / 15f;

            Console.WriteLine("Promedio mañana: " + promedioManana);
            Console.WriteLine("Promedio tarde: " + promedioTarde);
            Console.WriteLine("Promedio noche: " + promedioNoche);

            if (promedioManana < promedioTarde && promedioManana < promedioNoche)
            {
                Console.WriteLine("Turno mañana tiene menor promedio");
            }
            else if (promedioTarde < promedioNoche)
            {
                Console.WriteLine("Turno tarde tiene menor promedio");
            }
            else
            {
                Console.WriteLine("Turno noche tiene menor promedio");
            }

            Console.ReadKey();
        }
    }
}
