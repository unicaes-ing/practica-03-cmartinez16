using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            string nombre = "" ;
            int numero;
            Console.WriteLine("Ingrese el numero");
            numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    nombre = "Uno" ;
                        break;
                case 2:
                    nombre = "Dos";
                    break;
                case 3:
                    nombre = "Tres";
                    break;
                case 4:
                    nombre = "Cuatro";
                    break;
                case 5:
                    nombre = "Cinco";
                    break;
                case 6:
                    nombre = "Seis";
                    break;
                case 7:
                    nombre = "Siete";
                    break;
                case 8:
                    nombre = "Ocho";
                    break;
                case 9:
                    nombre = "Nueve";
                    break;
                case 10:
                    nombre = "Diez";
                    break;
                default:
                    Console.WriteLine("El numero ingresado no esta en el rango 1-10");
                    break;
            }
            Console.WriteLine("El numero {0} se escribe: {1}", numero, nombre);
            Console.ReadKey();
        }
    }
}
