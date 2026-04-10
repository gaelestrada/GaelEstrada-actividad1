//3. Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.
using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 4; i++)
        {
            Console.Write("Ingrese número " + i + ": ");
            suma += int.Parse(Console.ReadLine());
        }

        double promedio = suma / 4.0;

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Promedio: " + promedio);
    }
}
