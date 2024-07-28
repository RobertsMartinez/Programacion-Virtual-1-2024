namespace Bloque2_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se definen las notas 
            List<int> notas = new List<int> { 9, 5, 10, 7, 9, 10, 6, 9 };

            // Uso de LINQ para filtrar las notas sobresalientes
            var notas_sobresalientes = from nota in notas
                                      where nota >= 8
                                      select nota;

            // Se muestran las notas sobresalientes
            Console.WriteLine("Notas sobresalientes:");
            foreach (var nota in notas_sobresalientes)
            {
                Console.WriteLine(nota);
            }

            Console.ReadKey();
        }
    }
}
