using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class Ejemplo2Excepciones
    {
        static void Main(string[] args)
        {
            int num1, num2;
            try
            {
                Console.WriteLine("Ingrese el primer número: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                num2 = int.Parse(Console.ReadLine());

                double dividir = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.WriteLine("Se sigue ejecutando codigo");

            Console.ReadKey();
        }
    }
}
