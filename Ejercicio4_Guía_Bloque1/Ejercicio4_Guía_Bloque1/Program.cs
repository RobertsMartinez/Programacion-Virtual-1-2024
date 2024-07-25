using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Guía_Bloque1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            int divisor = 1, contador = 0;

            while (divisor <= numero)
           {
                if (numero % divisor == 0)

                {
                    contador++;
                }
                divisor++;
           }
            if (contador == 2)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
            Console.ReadKey();




        }
    }
}
