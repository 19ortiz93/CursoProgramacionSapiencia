using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales
{
    internal class Ejemplo4
    {
        /*
        Hacer un programa que realice las operaciones de suma,
        resta, multiplicacion y division, el usuario escoge la
        operación que deseee desde un menu de opciones.
        */
        static void Main(string[] args)
        {
            double num1 = 0D, num2 = 0D, resultado = 0D;
            string operacion = ""; //S R M D o + - * /
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el simbolo de la operación: ");
            Console.WriteLine("+ Suma");
            Console.WriteLine("- Resta");
            Console.WriteLine("* Multiplicación");
            Console.WriteLine("/ División");
            operacion = Console.ReadLine();

            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine("La suma es: " + resultado);
                    break;
                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine("La resta es: " + resultado);
                    break;
                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine("La multiplicación es: " + resultado);
                    break;
                case "/":
                    if (num2 == 0D)
                    {
                        Console.WriteLine("ERRROR: no se puede dividir por cero");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("La división es: " + resultado);
                    }
                    break;
                default:
                    Console.WriteLine("ERROR: simbolo no valido debes ingresar (+ - * /)");
                    break;
            }

            Console.ReadKey();
        }
    }
}
