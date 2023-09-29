using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* hacer un programa que lea el sueldo de un empleado
               si el sueldo es menor o igual a dos SMLV se le aumentara
               el auxilio de transporte
               Imprimir el sueldo final.
            */
            const double AUX = 140000D, DOS_SMLV = 2320000D;
            double sueldoBase, aumento = 0D, sueldoFinal;
            Console.WriteLine("Ingrese el sueldo base del empleado: ");
            sueldoBase = Convert.ToDouble(Console.ReadLine());

            if (sueldoBase <= DOS_SMLV)
            {
                aumento = AUX;
            }

            sueldoFinal = sueldoBase + aumento;
            Console.WriteLine("el sueldo del empleado es: " + sueldoFinal);
            Console.ReadKey();
        }
    }
}
