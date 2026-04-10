using System;

namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. En un banco se procesan datos de cuentas corrientes.
            // Informar estado de cada cuenta (Acreedor, Deudor o Nulo)
            // y la suma total de los saldos acreedores.

            int numeroCuenta;
            float saldo;
            float totalAcreedores = 0;
            string linea;

            do
            {
                Console.Write("Ingrese numero de cuenta: ");
                linea = Console.ReadLine();
                numeroCuenta = int.Parse(linea);

                if (numeroCuenta >= 0)
                {
                    Console.Write("Ingrese saldo: ");
                    linea = Console.ReadLine();
                    saldo = float.Parse(linea);

                    if (saldo > 0)
                    {
                        Console.WriteLine("Estado: Acreedor");
                        totalAcreedores = totalAcreedores + saldo;
                    }
                    else
                    {
                        if (saldo < 0)
                        {
                            Console.WriteLine("Estado: Deudor");
                        }
                        else
                        {
                            Console.WriteLine("Estado: Nulo");
                        }
                    }
                }

            } while (numeroCuenta >= 0);

            Console.WriteLine("Total de saldos acreedores: " + totalAcreedores);

            Console.ReadKey();
        }
    }
}
