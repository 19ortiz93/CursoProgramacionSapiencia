using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversionesEjemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que lea la edad de una persona
            //para determinar las pulsasiones por minuto
            //pulsasiones = (210 - edad) / 10

            int edad;
            double pulsaciones;

            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            pulsaciones = (210 - edad) / 10D;

            Console.WriteLine(string.Format("N° de pulsaciones por minuto: {0}", pulsaciones));

            Console.ReadKey();
        }
    }
}
