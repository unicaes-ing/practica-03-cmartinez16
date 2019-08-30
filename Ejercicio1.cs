using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            int hora;
            int segundos, minutos;
            Console.WriteLine("Ingrese la hora");
            hora = Convert.ToInt32(Console.ReadLine());
            if (hora > 0)
            {
                segundos = hora * 3600;
                minutos = hora * 60;
                Console.WriteLine("Hora ingresada: {0}", hora);
                Console.WriteLine("Valor en minutos: {0}", minutos);
                Console.WriteLine("Valor en segundos: {0}", segundos);
            }
            else
            {
                Console.WriteLine("Hora ingresada invalida");
            }
            Console.ReadKey();
        }
    }
}
