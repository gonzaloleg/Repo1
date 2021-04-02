using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese algo:");
            string ingreso = Console.ReadLine();
            ingreso = ingreso.ToUpper();

            Console.WriteLine($"Usted ingreso: {ingreso}");
            Console.ReadKey();
        }
    }
}
