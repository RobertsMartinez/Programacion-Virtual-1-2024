using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio3_Guia_Bloque1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de las variables a utilizar
            int numerous;
            int sum = 0;
            //Inicio del ciclo while
            while (true)
            {
                Console.Write("Ingrese un número positivo (Si desea salir precione 0): ");
                numerous = int.Parse(Console.ReadLine());

                if (numerous <= 0)
                {
                    //Fin del ciclo while mendiante condicional
                    break;
                }
                //suma de los numeros ingresados
                sum += numerous;
                Console.WriteLine($"Total sumado hasta el momento: {sum}");
            }
        }
    }
}
