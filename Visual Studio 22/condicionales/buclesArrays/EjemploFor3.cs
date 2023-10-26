using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class EjemploFor3
    {
        static void Main(string[] args)
        {
            // Crear un programa que imprima los números del -50 al 0 y
            // los números del 2 al 100 pero de 2 en 2 (2,4,6,8 ....100).
            /*for (int i = -50; i <= 0; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 2; i <= 100; i += 2) { 
                Console.WriteLine(i);  
            }*/
            //segunda forma
            for (int i = -50; i <= 100; i++)
            {
                if (i <= 0) // impares i % 2 == -1
                {
                    Console.WriteLine(i);
                }
                else if (i >= 2 && i % 2 == 0) // 2 al 100 pares
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
