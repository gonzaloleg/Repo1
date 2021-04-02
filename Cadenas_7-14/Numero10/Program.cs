using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese algo:");
            string ingreso = Console.ReadLine();
            ingreso = ingreso.ToLower();

            Console.WriteLine($"Usted ingreso: {ingreso}");
            Console.ReadKey();
        }
    }
}
