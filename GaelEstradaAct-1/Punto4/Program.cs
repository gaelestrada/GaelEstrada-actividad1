//4. Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el precio del artículo: ");
        double precio = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        double total = precio * cantidad;

        Console.WriteLine("Total a pagar: " + total);
    }
}
