using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Guia_Bloque1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de la variable a utilizar
            int numero;
            //Inicio del ciclo while hasta que el usuario lo interrumpa
            while (true)
            {
                Console.Write("Ingrese un número entre 1 y 10 (0 para salir): ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break;
                }
                else
                {
                    //Inicio del ciclo for
                    Console.WriteLine($"Tabla de multiplicar del {numero}:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{numero} x {i} = {numero * i}");
                    }
                }
            }

        }



    }
}
    

