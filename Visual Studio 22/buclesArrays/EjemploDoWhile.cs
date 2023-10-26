using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class EjemploDoWhile
    {
        static void Main(string[] args)
        {
            //Hacer un programa que lea una vlace del usuario y valide
            //si es correcta y mostrar un mensaje de bienvenido al sistema,
            //de lo contrario si lo intenta 3 veces se bloqueara la clave.

            int claveCorrecta = 2356, claveUsuario = 0, intentos = 0;

            do
            {
                Console.WriteLine("ingrese la clave: ");
                claveUsuario = int.Parse(Console.ReadLine());
                intentos++;

            } while (claveUsuario != claveCorrecta && intentos <= 2); //clvaes son iguales y intentos 3

            if (claveCorrecta == claveUsuario)
            {
                Console.WriteLine("Bienvenido al sistema");
            }
            else
            {
                Console.WriteLine("Error: intentos fallidos, usuario bloqueado23");
            }

            Console.ReadKey();
        }
    }
}
