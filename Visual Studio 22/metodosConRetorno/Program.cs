using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosConRetorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //llamado a las funciones
            Console.WriteLine(mostrarMensaje());

            string mensaje = mostrarMensaje();
            Console.WriteLine(mensaje + " v1");
            Console.WriteLine(multiplicar());
            double division = multiplicar() / 3D;
            Console.WriteLine(division);
            //retorno con parametros
            Console.WriteLine(dividir(10, 3));
            //entradas de usuario
            Console.WriteLine("Ingrese el primer numero:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("la división es: " + dividir(num1, num2));

            Console.ReadKey();
        }
        //metodo con parametros
        static double dividir(double n1, double n2)
        {
            return n1 / n2; //dato
        }

        //metodos con rerotno
        static string mostrarMensaje()
        {
            return "Hola Mundo";
        }

        static double multiplicar()
        {
            int n1 = 10, n2 = 7;
            double mul = n1 * n2;//variable local
            return mul;//variable res = 70
        }
    }
}
