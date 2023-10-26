using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class EjemploWhile2
    {
        static void Main(string[] args)
        {
            //Hacer un programa que lea un número entre 1 y 5, si escribe alguno
            //que esté fuera de ese rango deberá volver a pedir el número.

            int numero = 0;
            while(numero <= 0 || numero >= 6)
            {
                Console.WriteLine("Ingrese un número del 1 al 5");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El numero fue ingresado correctamente");
            Console.ReadKey();
        }
    }
}
