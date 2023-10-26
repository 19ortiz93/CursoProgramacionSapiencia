using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class EjemploWhile1
    {
        static void Main(string[] args)
        {
            int contador = 1, acumulador = 0;
            while (contador <= 15)
            {
                Console.WriteLine(contador+" Cuso C# nivel 1");
                acumulador += contador;
                contador++;
            }
            Console.WriteLine("Valor real del contador para salir del ciclo: " + contador);
            Console.WriteLine("La suma del 1 al 15 es: " + acumulador);
            Console.ReadKey();
        }
    }
}
