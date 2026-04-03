// Punto 2: Desarrollar una clase que represente un Cuadrado y permita cargar el valor
// del lado e imprimir su perímetro y su superficie.

using System;

namespace Ejercicio2
{
    class Cuadrado
    {
        int lado;

        public void Cargar()
        {
            Console.Write("Ingrese el valor del lado: ");
            lado = int.Parse(Console.ReadLine());
        }

        public void Perimetro()
        {
            int perimetro = lado * 4;
            Console.WriteLine("El perímetro es: " + perimetro);
        }

        public void Superficie()
        {
            int superficie = lado * lado;
            Console.WriteLine("La superficie es: " + superficie);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.Cargar();
            cuadrado.Perimetro();
            cuadrado.Superficie();

            Console.ReadKey();
        }
    }
}
