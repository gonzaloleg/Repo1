using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero7
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Hola, ingresa tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}.");
            Console.ReadKey();

        }
    }
}
