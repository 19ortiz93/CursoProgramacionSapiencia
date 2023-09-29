using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comentario en linea
            /*
                comentarios en
                multiples
                variables
             */
            // variables
            int edad = 23;
            double peso = 65.5D; //La D al final ayuda a interpletar que es un double
            float estatura = 1.70F; // la F al final ayuda a interpretar que es un float
            string nombreCompleto = "Pepo Perez";
            int anio = 2023; // year o en vez de ñ usar ni
            string accion = "estudiar";
            bool esEstudiante = true;
            // declaracion de multiples variables en una linea cuando son del mismo tipo
            float nota1 = 0, nota2 = 0, nota3 = 0;
            nota1 = nota2 = nota3 = 0.1F;
            // declaracion implicita var
            var curso = "C#";
            /* Reglas: camelCase, coherente, evitar la ñ y tildes,
               no colocar espacios, no anteponer un numero,
               no colocar guion medio -
            */
            int n1 = 20;
            int n2 = 4;
            //string n2 = "4";
            Console.WriteLine("Suma =" + (n1 + n2)); // imprimir en consola
            Console.WriteLine("Resta =" + (n1 - n2));
            Console.WriteLine("Multiplicacion =" + (n1 * n2));
            Console.WriteLine("Division =" + (n1 / n2));
            Console.WriteLine("Modulo =" + (n1 % n2));
            // incremento y decremento
            int increm = 10;
            int decrem = 8;
            increm++; increm += 1; increm = increm + 1;
            decrem--; decrem -= 1; decrem = decrem - 1;
            Console.WriteLine(increm + " " + decrem);
            const float IVA = 0.19F; //las constantes siempre van en mayuscula
            Console.WriteLine("Iva del: " + (IVA * 100) + "%");
            // interpolacion de cadenas
            Console.WriteLine($"El estudiante {nombreCompleto} tiene {edad} años");
            //string.concat()
            Console.WriteLine(string.Concat(peso, " ", estatura));
            //string.Format()
            Console.WriteLine(string.Format("El curso de {0} se dictara el año {1}", curso, anio));
            
            //operadores lógicos "Y" && - "O" || - No !
            bool esPracticante = true;
            bool tieneSubsidio = false;
            Console.WriteLine(esPracticante && tieneSubsidio);
            Console.WriteLine(esPracticante || tieneSubsidio);
            Console.WriteLine(!esEstudiante && !esPracticante);
            Console.WriteLine(esEstudiante &&  !tieneSubsidio);
            //operadores relacionales == != < > <= >=
            int n3 = 5, n4 = 8;
            Console.WriteLine(n3 == n4);
            Console.WriteLine(n3 != n4);
            Console.WriteLine(n3 > n4);
            Console.WriteLine(n3 < n4);
            Console.WriteLine(n3 < n4 && !(n3 > n4));
            Console.WriteLine((n1 != n4) ||!(n3 < n2) && (n1 > n3));


            Console.ReadKey(); // leer tecla
        }
    }
}