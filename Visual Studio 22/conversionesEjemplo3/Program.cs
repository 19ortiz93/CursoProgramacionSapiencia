using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversionesEjemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa de las tres notas de un estudiante
            //e imprima su promedio final

            double nota1, nota2, nota3, notaFinal;
            string estudiante;

            Console.WriteLine("Ingrese el nombre del estudiante:");
            estudiante = Console.ReadLine();

            Console.WriteLine("Ingrese las tres notas de " + estudiante);
            nota1 = double.Parse(Console.ReadLine());
            nota2 = Convert.ToDouble(Console.ReadLine());
            nota3 = Convert.ToDouble(Console.ReadLine());

            notaFinal = Math.Round((nota1 + nota2 + nota3) / 3D, 1);

            Console.WriteLine($"El estudiante {estudiante} tiene la nota final de {notaFinal}");

            Console.ReadKey();

            /* ejercicio
               Hacer un programa que el un valor en pesos 
               colombianos y convertira a dolares, euros y yenes
             */
        }
    }
}
