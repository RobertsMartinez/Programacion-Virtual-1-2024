using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_Guia_Bloque1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de las variables a usar
            int num1, num2, num3, num4;
            double promedio;
            //Se pide al usuario que ingrese los datos
            
           
                Console.WriteLine("Ingrese un numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un numero: ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un numero: ");
                num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un numero: ");
                num4 = int.Parse(Console.ReadLine());

            promedio = Convert.ToDouble(num1+num2+num3+num4) / 4;
            Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);
            Console.ReadKey();

        }
    }
}
