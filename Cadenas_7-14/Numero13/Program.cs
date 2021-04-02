using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese algo:");
            string ingreso1 = Console.ReadLine();
            Console.WriteLine("Ingrese algo más:");
            string ingreso2 = Console.ReadLine();

            var length1 = ingreso1.Length;
            var length2 = ingreso2.Length;

            if (length1 == length2)
            {
                Console.WriteLine("Ambas cadenas tienen la misma longitud.");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Las cadenas no tienen la misma longitud.");
                Console.ReadKey();
            }
        }
    }
}
