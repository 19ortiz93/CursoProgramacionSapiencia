using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversionEjemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que lea dos numeros por consola e imprima
            //la suma y la division
            int num1, num2;
            Console.WriteLine("ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("la suma es " + (num1 + num2));
            Console.WriteLine($"la suma es { (double)num1 / (double)num2}");

            Console.ReadKey();
        }
    }
}
