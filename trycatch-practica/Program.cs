using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch_practica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delaración de variables
            int Numero;

          try
            {
                Console.Write("Ingrese un número entero: ");
                Numero = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEl cuadrado del número entero es: " + Math.Pow(Numero, 2));
            }
            catch(OverflowException s)
            {
                Console.WriteLine(s.Message);
            }
            catch(FormatException s)
            {
                Console.WriteLine(s.Message);
            }
            Console.WriteLine("\nPresione ENTER para salir");
            Console.ReadKey();
        }
    }
}
