//6. Escribir un programa que lea el peso (en kilogramos) y la altura (en metros) de una persona, y mostrar por pantalla su índice de masa corporal (IMC) (El IMC se calcula dividiendo el peso entre el cuadrado de la altura).
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Ingrese su altura (m): ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("Su IMC es: " + imc);
    }
}
