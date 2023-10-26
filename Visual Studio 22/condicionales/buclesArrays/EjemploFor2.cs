using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class EjemploFor2
    {
        static void Main(string[] args)
        {
            // hacer un programa que lea un número e imprima en pantalla el factorial
            // del numero ingresado
            double fact = 1, fact2 = 1;
            int numero;

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                fact = fact * i;
                Console.WriteLine(fact+"\t"+i);
            }
            Console.WriteLine($"el factorial del numero {numero} es: {fact}");

            Console.WriteLine(" ");
            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = numero; i >= 1; i--)
            {
                fact2 = fact2 * i;
                Console.WriteLine(fact2 + "\t" + i);
            }
            Console.WriteLine($"el factorial del numero {numero} es: {fact2}");

            Console.ReadKey();
        }
    }
}
