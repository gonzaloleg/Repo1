using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero18
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

            numero = Math.Round(numero, 2);
            Console.WriteLine("Su numero redondeado con 2 decimales es: " + numero);
            Console.ReadKey();
        }
    }
}
