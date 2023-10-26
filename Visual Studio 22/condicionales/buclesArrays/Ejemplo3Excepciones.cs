using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class Ejemplo3Excepciones
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 0, 3, 12, 10, 5 }; // 6 posiciones del 0 al 5
            try
            {
                int valor = numeros[7];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Se sigue ejecutando el código");
            Console.ReadKey();
        }
    }
}
