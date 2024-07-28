using System;
using System.Linq;
using System.Collections.Generic;


namespace Bloque2_Ejercicio1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numeros = Enumerable.Range(1, 100);

            
            var numerosPrimos = from n in numeros
                                where EsPrimo(n)
                                select n;

            // Mostrar los números primos
            Console.WriteLine("Números primos entre 1 y 100:");
            foreach (var primo in numerosPrimos)
            {
                Console.WriteLine(primo);
            }

            Console.ReadLine();
        }

        // Determinar si un número es primo
        static bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;



        }
    }
}
