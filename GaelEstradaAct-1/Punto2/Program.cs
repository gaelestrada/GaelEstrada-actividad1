//2. Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        int num3 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el cuarto número: ");
        int num4 = int.Parse(Console.ReadLine());

        int suma = num1 + num2;
        int producto = num3 * num4;

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Producto: " + producto);
    }
}
