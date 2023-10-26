using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class Ejemplo2Arrays
    {
        static void Main(string[] args)
        {
            //hacer un programa que almacene en un array con tamaño 6 las notas de los
            //estudiantes del grado once, debe mostrar el promedio del grupo y a cada estudiante
            //determinar si aprobo o no aprobo (aprueba de 3 en adelante)

            double suma = 0, promedio = 0;
            double[] notas = new double[6];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese la nota del estudiante #"+(i+1));
                notas[i] = Convert.ToDouble(Console.ReadLine());
                suma += notas[i];
                if (notas[i] >= 3)
                {
                    Console.WriteLine($"El estudiante #{i+1} aprobo la materia.");
                }
                else
                {
                    Console.WriteLine($"El estudiante #{i + 1} no aprobo la materia.");
                }
                Console.ReadKey();
            }
            Console.WriteLine("Notas de los estudiantes");
            Array.ForEach(notas, x => Console.Write(x+"|"));
            Console.WriteLine("");
            promedio = suma / notas.Length;
            Console.WriteLine("el promedio del grado Once es: " + Math.Round(promedio, 1));
            Console.ReadKey();
        }
    }
}
