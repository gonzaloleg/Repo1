using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese algo:");
            string ingreso1 = Console.ReadLine();
            Console.WriteLine("Ingrese algo más:");
            string ingreso2 = Console.ReadLine();

            if (ingreso1.Equals(ingreso2))
            {
                Console.WriteLine("Ambos ingresos son iguales");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Los ingresos no son iguales");
                Console.ReadKey();
            }
        }
    }
}
