//5. Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo (La circunferencia se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el radio: ");
        double radio = double.Parse(Console.ReadLine());

        double circunferencia = 2 * Math.PI * radio;
        double area = Math.PI * radio * radio;

        Console.WriteLine("Circunferencia: " + circunferencia);
        Console.WriteLine("Área: " + area);
    }
}
