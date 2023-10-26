using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class EjemploWhile4
    {
        /*
        Realiza un programa en C#, que muestre un menú en pantalla 
        con las opciones:
                        1) Sumar
                        2) Restar
                        3) Multiplicar
                        4) Dividir
                        5) Salir
        El usuario debe seleccionar una opción. y a continuación,
        el programa deber solicitar el ingreso de 2 números enteros.
        Una vez ingresados los números, se deberá evaluar con un switch,
        realizando la operación correspondiente a la opción seleccionada.
        La ejecución debe realizarse una y otra vez,hasta que el usuario
        seleccione la opción # 5.
        */

        //variables globales
        static double numero1 = 0;
        static double numero2 = 0;
        //Metodo para solicitar los dos numeros

        private static void solicitarNumeros()
        {
            Console.WriteLine("Ingrese el primer número: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            numero2 = double.Parse(Console.ReadLine());
        }
        
        static void Main(string[] args)
        {
            int opcion = 0; bool entrar = true;
            //menu
            while (entrar == true) // entrar  !entrar
            {
                Console.WriteLine("Seleccione una opción de la lista (1 al 5)");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        solicitarNumeros();
                        Console.WriteLine("La suma es: " + (numero1 + numero2));
                        break;
                    case 2:
                        solicitarNumeros();
                        Console.WriteLine($"La resta es: {(numero1 - numero2)}");
                        break;
                    case 3:
                        solicitarNumeros();
                        Console.WriteLine($"La multiplicación es: {(numero1 * numero2)}");
                        break;
                    case 4:
                        //condicional validar el cero
                        solicitarNumeros();
                        if (numero2 == 0)
                        {
                            Console.WriteLine("Error: no se puede dividir entre cero");
                        }
                        else
                        {
                            Console.WriteLine($"La división es: {Math.Round(numero1 / numero2, 2)}");
                        }
                        break;
                    case 5:
                        entrar = false;
                        Console.WriteLine("Gracias por utilizar el programa");
                        break;
                    default:
                        Console.WriteLine("Opción no valida: Debe ingresar las opciones del menú");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
