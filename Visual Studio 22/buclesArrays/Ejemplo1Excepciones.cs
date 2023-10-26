using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class Ejemplo1Excepciones
    {
        static void Main(string[] args)
        {
            int numero = 0;
            try
            {
                Console.WriteLine("Ingrese un número");
                numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine("Se sigue ejecutando el código");
            Console.ReadKey();
        }
    }
}
