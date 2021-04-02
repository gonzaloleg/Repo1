using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cadena con tildes:");
            string ingreso = Console.ReadLine();
            ingreso = ingreso.ToLower();

            if (ingreso.Contains("á"))
            {
                ingreso = ingreso.Replace('á', 'a');
            }
            if (ingreso.Contains("é"))
            {
                ingreso = ingreso.Replace('é', 'e');
            }
            if (ingreso.Contains("í"))
            {
                ingreso = ingreso.Replace('í', 'i');
            }
            if (ingreso.Contains("ó"))
            {
                ingreso = ingreso.Replace('ó', 'o');
            }
            if (ingreso.Contains("ú"))
            {
                ingreso = ingreso.Replace('ú', 'u');
            }

            Console.WriteLine($"Su ingreso sin tildes es {ingreso}");
            Console.ReadKey();
        }
    }
}
