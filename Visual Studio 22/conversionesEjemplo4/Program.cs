using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversionesEjemplo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 
                Hacer un programa que el un valor en pesos colombianos y convierta a 
                dolares, euros y yenes
                Imprimir los resultados
             */

            double pesos, euros, dolares, yenes;
            Console.WriteLine("Ingrese el valor en pesos colombianos: ");
            pesos = Convert.ToDouble(Console.ReadLine());

            dolares = pesos / 3895.66D;
            euros = pesos / 4170.54D;
            yenes = pesos / 26.38D;

            Console.WriteLine("Dolares: " + dolares);
            Console.WriteLine($"Euros: {euros}");
            Console.WriteLine(string.Format($"Yenes {0}", Math.Round(yenes, 2)));

            Console.ReadKey();
        }
    }
}
