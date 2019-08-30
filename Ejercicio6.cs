using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            double descuento = 0, d1 = 0.12, d2 = 0.15, d3 = 0.20 , d4 = 0;
            double total = 0, monto;
            Console.WriteLine("Ingrese el monto de la compra del cliente");
            monto = Convert.ToDouble(Console.ReadLine());
            if (monto >= 100.01 && monto <= 200.00)
            {
                Console.WriteLine("El descuento es del 12%");
                descuento = monto * d1;
            }
            else
            {
                if (monto >= 200.01 && monto <= 500.00)
                {
                    Console.WriteLine("El descuento es del 15%");
                    descuento = monto * d2;
                }
                else
                {
                    if (monto >= 500.01)
                    {
                        Console.WriteLine("El descuento es del 20%");
                        descuento = monto * d3;
                    }
                    else
                    {
                        Console.WriteLine("No hay descuentos disponibles");
                        descuento = monto * d4;
                    }
                }
                total = monto - descuento;
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Su descuento es de: ${0}", descuento);
                Console.WriteLine("El total a pagar es de: ${0}", total);
                Console.ReadKey();

            }
        }
    }
}
