using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero8
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("Hola. Ingrese una frase:");
            frase = Console.ReadLine();
            if (frase.Contains("fin"))
            {
                Console.WriteLine("Su frase contiene la palabra 'fin'.");
                Console.ReadKey();
            }
        }
    }
}
