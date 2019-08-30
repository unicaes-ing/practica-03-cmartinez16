using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El orden ascendente es: {0} , {1} , {2}", num3, num2, num1);
                }
                else
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("El orden ascendente es: {0} , {1} , {2}", num2, num3, num1);
                    }
                    else
                    {
                        Console.WriteLine("El orden ascendente es: {0} , {1} , {2}", num2, num1, num3);
                    }
                }
            }
            else
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El orden ascendente es: {0} , {1} , {2}", num3, num1, num2);
                }
                else
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("El orden ascendente es: {0} , {1} , {2}", num1, num3, num2);
                    }
                    else
                    {
                        Console.WriteLine("El orden ascendente es: {0} , {1} , {2}", num1, num2, num3);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

