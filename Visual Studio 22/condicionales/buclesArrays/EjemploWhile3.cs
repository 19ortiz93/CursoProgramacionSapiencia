using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class EjemploWhile3
    {
        static void Main(string[] args)
        {
            //hacer un programa que lea tres notas de un estudiante
            //imprima si aprobo o no aprobo la nota (3 en adelante para aprovar)

            int contador = 1;
            double nota, suma = 0, promedio = 0;
            string estudiante;
            Console.WriteLine("Ingrese el nombre del estudiante");
            estudiante = Console.ReadLine();
            while (contador <= 3)
            {
                Console.WriteLine($"Ingrese la nota #{contador} del estudiante {estudiante}");
                nota = double.Parse(Console.ReadLine());
                suma += nota; // acumuladora
                contador++;
            }
            //promedio = suma / contador - 1;
            promedio = Math.Round(suma / 3, 1);
            if (promedio >= 3)
            {
                Console.WriteLine($"El estudiante {estudiante} aprobo el curso en {promedio}");
            }
            else
            {
                Console.WriteLine($"El estudiante {estudiante} no aprobo el curso en {promedio}");
            }
            Console.ReadKey();
        }
    }
}
