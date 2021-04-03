using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero17
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
                Console.WriteLine("No ingresó un valor numerico. Pulse cualquier tecla para finalizar.");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            Console.ReadKey();
            Console.WriteLine("Escriba otro numero");
            string ingreso2 = Console.ReadLine();
            int numero2;

            if (int.TryParse(ingreso2, out numero2))
            {
                Console.WriteLine($"Ingresó un valor numerico: {numero2}");
            }
            else
            {
                Console.WriteLine("No ingresó un valor numerico. Pulse cualquier tecla para finalizar.");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            Console.ReadKey();
            Console.WriteLine($"La suma de {numero} y {numero2} es: {numero + numero2}");
            Console.WriteLine($"La resta entre {numero} y {numero2} es: {numero - numero2}");
            Console.WriteLine($"La multiplicacion entre {numero} y {numero2} es: {numero * numero2}");
            Console.WriteLine($"La potencia. Base {numero}, exponente {numero2}:" + Math.Pow(numero, numero2));
            Console.WriteLine($"La division entre {numero} y {numero2} es: {numero / numero2}");
            Console.WriteLine($"El resto de la division entre {numero} y {numero2} es: {numero % numero2}");
            Console.ReadKey();
        }
    }
}
