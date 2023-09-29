using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales
{
    internal class Ejemplo3
    {
        /*
        Hacer un programa que lea dos numeros y determine cual es el 
        mayor de los dos y validar si son iguales.
        Imprimir el resultado
        */
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0; // short int16 long int64
            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine($"el numero mayor es: {num1}");
            }else if(num2 > num1)
            {
                Console.WriteLine(string.Format("el numero mayor es: {0}", num2));
            }
            else
            {
                Console.WriteLine(string.Concat("los numeros ", num1, " y ", num2, " son iguales"));
            }

            Console.ReadKey();
        }
    }
}
