using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero");
            string ingreso = Console.ReadLine();
            int numero;

            if (int.TryParse(ingreso, out numero))
            {
                Console.WriteLine($"Ingresó un valor numerico: {numero}");
            }
            else
            {
                Console.WriteLine("No ingresó un valor numerico.");
            }
            Console.ReadKey();
        }
    }
}
