using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclesArrays
{
    internal class Ejemplo3Arrays
    {
        static void Main(string[] args)
        {
            //Hacer un programa que realice uan venta de productos alamacenado en un array, y en
            //otro array alamcenar su precio, debe calcular la venta total del cliente teniendo
            // en cuenta que se le apliacara un descuento del 10% si la venta es mayor a 
            // 500000 de lo contrario el descuenta sera 0%.

            string[] productos = { "Camisa", "Jean", "Tenis", "Bolso" };
            double[] precios = { 48000D, 140000D, 255000D, 125000D };
            Int32[] cantidades = { 2, 1, 1, 2 };
            double subTotal = 0D, totalPagar = 0D, descuento = 0D, valorDes = 0D;
            string cliente;

            Console.WriteLine("Ingrese el nombre del cliente: ");
            cliente = Console.ReadLine();

            //ciclo para iterar arrays
            for (int i = 0; i < productos.Length; i++)
            {
                subTotal += precios[i] * cantidades[i];
            }
            if(subTotal > 500000D)
            {
                descuento = 10D / 100D; //0.1
            }
            valorDes = subTotal * descuento;
            totalPagar = subTotal - valorDes;
            Console.Clear();
            Console.WriteLine("VENTA DE ROPA");
            Console.WriteLine("Cliente: " + cliente);
            Console.WriteLine("Detalles de la venta");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Prod. | Precio | Cantidad ");
            for (int i = 0; i < productos.Length;i++)
            {
                Console.WriteLine($"{productos[i]}\t{precios[i]}\t{cantidades[i]}");
            }
            Console.WriteLine("SubTotal: \t" + subTotal);
            Console.WriteLine("Valor descuento: \t" + valorDes);
            Console.WriteLine("Total a pagar: \t" + totalPagar);
            Console.WriteLine("Gracias por su compra");
            
            Console.ReadKey();
        }
    }
}
