using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Random numero = new Random(DateTime.Now.Millisecond);
            int Aleatorio = numero.Next(100);
            Console.WriteLine("El numero generado es: {0} ", Aleatorio);
            if (Aleatorio % 2 == 0) 
            {
                Console.WriteLine("El numero generado es par");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("El numero generado es impar");
                Console.ReadKey();
            }
        }
    }
}
