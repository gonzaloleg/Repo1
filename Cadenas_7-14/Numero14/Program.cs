using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese algo:");
            string ingreso1 = Console.ReadLine();
            Console.WriteLine("Ingrese algo más:");
            string ingreso2 = Console.ReadLine();

            if (ingreso1.Equals(ingreso2, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Ambas cadenas son iguales (case insensitive)");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Las cadenas no son iguales");
                Console.ReadKey();
            }
        }
    }
}
