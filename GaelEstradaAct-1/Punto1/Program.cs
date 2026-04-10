//1. Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el lado del cuadrado:");
        string dato = Console.ReadLine();

        int lado = Convert.ToInt32(dato);

        int perimetro = lado * 4;

        Console.WriteLine("El perímetro es: " + perimetro);

        Console.ReadKey(); // 
    }
}