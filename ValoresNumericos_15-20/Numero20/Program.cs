using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero");
            string ingreso = Console.ReadLine();
            decimal numero;

            if (decimal.TryParse(ingreso, out numero))
            {
                Console.WriteLine($"Ingresó un valor numerico: {numero}");
            }
            else
            {
                Console.WriteLine("No ingresó un valor numerico. Pulse cualquier tecla para finalizar.");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            Console.ReadKey();
            Console.WriteLine("Escriba otro numero");
            string ingreso2 = Console.ReadLine();
            decimal numero2;

            if (decimal.TryParse(ingreso2, out numero2))
            {
                Console.WriteLine($"Ingresó un valor numerico: {numero2}");
            }
            else
            {
                Console.WriteLine("No ingresó un valor numerico. Pulse cualquier tecla para finalizar.");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            Console.WriteLine("El numero mayor es: " + Math.Max(numero, numero2));
            Console.ReadKey();
        }
    }
}
