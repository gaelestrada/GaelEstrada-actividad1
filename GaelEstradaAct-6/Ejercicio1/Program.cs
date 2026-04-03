// Punto 1: Desarrollar una clase que represente un punto en el plano y permita cargar
// los valores de x e y, e imprimir en que cuadrante se encuentra.

using System;

namespace Ejercicio1
{
    class Punto
    {
        int x, y;

        public void Cargar()
        {
            Console.Write("Ingrese valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese valor de Y: ");
            y = int.Parse(Console.ReadLine());
        }

        public void Cuadrante()
        {
            if (x > 0 && y > 0)
                Console.WriteLine("Se encuentra en el primer cuadrante");
            else if (x < 0 && y > 0)
                Console.WriteLine("Se encuentra en el segundo cuadrante");
            else if (x < 0 && y < 0)
                Console.WriteLine("Se encuentra en el tercer cuadrante");
            else if (x > 0 && y < 0)
                Console.WriteLine("Se encuentra en el cuarto cuadrante");
            else
                Console.WriteLine("El punto se encuentra sobre un eje");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Punto punto = new Punto();
            punto.Cargar();
            punto.Cuadrante();

            Console.ReadKey();
        }
    }
}
