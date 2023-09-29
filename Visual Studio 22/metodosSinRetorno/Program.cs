using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosSinRetorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //llamado del metodo
            // Sin parametros
            MostrarMensaje();
            Sumar();
            // Con parametros
            Restar(23, 10); // Directa -> Datos quemados
            //parametros ingresados por el usuario
            Console.WriteLine("Ingrese el primer número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num2 = int.Parse(Console.ReadLine());
            Restar(num1, num2);
            Console.ReadKey();
        }
        // cierre principal
        // cierre principal
        //metodos sin retorno con parametros
        static void Restar(int num1, int num2)
        {
            int resta = num1 - num2;
            Console.WriteLine($"La resta es: {resta}");
        }
        //metodos sin retorno
        static void MostrarMensaje()
        {
            //bloque de codigo
            Console.WriteLine("Bienvenidos al curso");
        }
        static void Sumar()
        {
            //bloque de codigo
            int n1 = 10, n2 = 30;
            Console.WriteLine("La suma es: " + (n2 + n1));
        }
    }
}
