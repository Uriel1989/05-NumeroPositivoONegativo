using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_NumeroPositivooNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Introducir un numero al azar, distinto de cero, para determinar si es positivo o negativo: ");
            a = Convert.ToInt32(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine("Numero introducido incorrecto, debe ser distinto de cero:");
                a = Convert.ToInt32(Console.ReadLine());

            }
            if (a > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            if (a < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            Console.ReadKey();
        }
    }
}
