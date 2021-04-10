using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero22
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            Console.WriteLine($"Hoy es {fecha.ToString("dd/MM/yyyy")}");
            Console.ReadKey();
        }
    }
}
