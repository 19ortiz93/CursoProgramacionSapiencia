using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class Ejemplo1Arrays
    {
        static void Main(string[] args)
        {

            //Declarar Arrays tipo  [] nombre tamaño
            int[] edades = new int[5];
            string[] estudiantes = new string[5];
            edades[0] = 22;
            edades[1] = 18;
            edades[2] = 25;
            edades[3] = 20;
            edades[4] = 35;
            Console.WriteLine(edades[4] + " años");
            estudiantes[0] = "Juanito";
            estudiantes[1] = "Pepito";
            estudiantes[2] = "Pedrito";
            estudiantes[3] = "Anita";
            estudiantes[4] = "Pablito";
            Console.WriteLine(estudiantes[3]);
            double[] notas = { 2.3, 3.2, 4.5, 4.8, 2.0 };
            string[] cursos = { "C#", "JavaScript", "Java", "HTML", "CSS", "Python" };
            Console.WriteLine("Cantidad de cusos: " + cursos.Length);
            //metodos de Arrays
            Array.Sort(edades); //ordena los elemento ascendentemente
            Array.ForEach(edades, dato => Console.Write(dato + " "));
            // Espresiones lambda
            Console.WriteLine("");
            Array.Reverse(edades);
            Array.ForEach(edades, dato => Console.Write(dato + " "));
            //copiar un array
            Console.WriteLine("");
            double[] copyNotas = new double[notas.Length];
            Array.Copy(notas, copyNotas, notas.Length);
            Array.ForEach(copyNotas, dato => Console.Write(dato + " "));
            Console.WriteLine("");
            int posicCursos = Array.IndexOf(cursos, "C#");
            if (posicCursos == -1)
            {
                Console.WriteLine("No existe el curso");
            }
            else
            {
                Console.WriteLine("Posición del curso: " + posicCursos);
            }
            //exists boolean true false
            bool edad18 = Array.Exists(edades, i => i == 18);
            Console.WriteLine("Edad encontrada: " + edad18);
            // TrueForAll
            bool menoresEdad = Array.TrueForAll(edades, i => i < 18);
            Console.WriteLine("Todos menores de edad: " + menoresEdad);
            //Iteración de Arrays
            // foreach para cada   --  for para
            foreach (var curso in cursos)
            {
                Console.WriteLine(curso);
            }



            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine(estudiantes[i]);
            }



            Console.ReadKey();
        }
    }
}
