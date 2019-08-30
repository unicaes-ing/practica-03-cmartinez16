using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int minutos;
            int zona;
            decimal costo = 0;
            Console.WriteLine("Ingrese la opcion de la zona donde se realizo la llamada");
            Console.WriteLine("1: Zona Occidental, 2: Zona Central, 3:Zona Oriental");
            zona = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de minutos que duro la llamada");
            minutos = Convert.ToInt32(Console.ReadLine());
            switch (zona)
            {
                case 1:
                    costo = 0.32m * minutos;
                    break;
                case 2:
                    costo = 0.25m * minutos;
                    break;
                case 3:
                    costo = 0.36m * minutos;
                    break;
                default:
                    Console.WriteLine("Transaccion invalida");
                    break;
            }
            Console.WriteLine(" El costo de su llamada es: $ {0}", costo);
            Console.ReadKey();

        }
    }
}
