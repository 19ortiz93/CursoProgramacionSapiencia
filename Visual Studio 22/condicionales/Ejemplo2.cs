using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales
{
    internal class Ejemplo2
    {
        static void Main(string[] args)
        {
            /*
             Hacer un programa que lea un número por consola e imprima si es
             un número par o impar
             */

            int numero;
            Console.WriteLine("ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0 )
            {
                Console.WriteLine($"El numero {numero} es par");
            }
            else
            {
                Console.WriteLine($"El numero {numero} no es par");
            }

            Console.ReadKey();
        }
    }
}
