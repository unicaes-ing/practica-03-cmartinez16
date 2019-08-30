using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Ejercicio7
    {
        static void Main(string[] args)
        {
            int origen, destino = 0;
            decimal conversion, cantidad;
            Console.WriteLine("Conversor de unidades de masa");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Ingrese la unidad de origen segun el numero que corresponda");
            Console.WriteLine(" [1] Onza");
            Console.WriteLine(" [2] Libra");
            Console.WriteLine(" [3] Gramo");
            Console.WriteLine(" [4] Tonelada");
            origen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la unidad de destino segun el numero que corresponda");
            destino = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de unidades a convertir");
            cantidad = Convert.ToDecimal(Console.ReadLine());
            switch (origen)
            {
                case 1:
                    if (destino == 1)
                    {
                        Console.WriteLine("Ha ingresado la misma unidad de origen");
                    }
                    else
                    {
                        if (destino == 2)
                        {
                            Console.WriteLine("Ha elegido convertir onzas a libras");
                            conversion = cantidad / 0.0625m;
                        }
                        else
                        {
                            if (destino == 3)
                            {
                                Console.WriteLine("Ha elegido convertir onzas a gramos");
                                conversion = cantidad * 28.35m;
                            }
                            else
                            {
                                Console.WriteLine("Ha elegido convertir onzas a toneladas");
                                conversion = cantidad / 32000m;
                            }
                        }
                    }
                    break;
            }
        }
    }
}
