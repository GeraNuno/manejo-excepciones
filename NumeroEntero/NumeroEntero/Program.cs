using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroEntero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            try
            {
                Console.Write("Escribe un número entero: ");
                num = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEl cuadrado de " + num + " es: " + Math.Pow(num,2));
            }
            catch (FormatException e)
            {
                Console.WriteLine("\n" + e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("\n" + e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("\n" + e.Message);
            }
            Console.WriteLine("\nPresione ENTER para salir del programa...");
            Console.ReadKey();
        }
    }
}
