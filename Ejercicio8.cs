using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Ejercicio8
    {
        static void Main(string[] args)
        {
            double compra, descuento = 0, total = 0;
            Random bolita = new Random(DateTime.Now.Millisecond);
            int color = bolita.Next(5);
            Console.WriteLine("Ingrese el valor de su compra: ");
            compra = Convert.ToDouble(Console.ReadLine());
            if (color == 1)
            {
                descuento = 0;
                total = compra;
                Console.WriteLine("El color de su bolita es blanco");
                Console.WriteLine("Su descuento es de: ${0}", descuento);
                Console.WriteLine("El total de su compra es de: ${0}", total);
                Console.ReadKey();
            }
            else
            {
                if (color == 2)
                {
                    descuento = 0.15 * compra;
                    total = compra - descuento;
                    Console.WriteLine("El color de su bolita es verde");
                    Console.WriteLine("Su descuento es de: ${0}", descuento);
                    Console.WriteLine("El total de su compra es de: ${0}", total);
                    Console.ReadKey();
                }
                else
                {
                    if (color == 3)
                    {
                        descuento = 0.18 * compra;
                        total = compra - descuento;
                        Console.WriteLine("El color de su bolita es amarillo");
                        Console.WriteLine("Su descuento es de: ${0}", descuento);
                        Console.WriteLine("El total de su compra es de: ${0}", total);
                        Console.ReadKey();
                    }
                    else
                    {
                        if (color == 4)
                        {
                            descuento = 0.20 * compra;
                            total = compra - descuento;
                            Console.WriteLine("El color de su bolita es azul");
                            Console.WriteLine("Su descuento es de: ${0}", descuento);
                            Console.WriteLine("El total de su compra es de: ${0}", total);
                            Console.ReadKey();
                        }
                        else
                        {
                            descuento = 0.25 * compra;
                            total = compra - descuento;
                            Console.WriteLine("El color de su bolita es rojo");
                            Console.WriteLine("Su descuento es de: ${0}", descuento);
                            Console.WriteLine("El total de su compra es de: ${0}", total);
                            Console.ReadKey();
                        }
                    }
                }
            }

        }

    }
}
