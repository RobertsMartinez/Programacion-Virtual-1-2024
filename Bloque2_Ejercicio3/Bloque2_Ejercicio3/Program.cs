namespace Bloque2_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Venta> ventas = new List<Venta>
        {
            new Venta { Cliente = "Cliente1", Producto = "Producto2", Cantidad = 3, Fecha = new DateTime(2024, 5, 6) },
            new Venta { Cliente = "Cliente2", Producto = "Producto4", Cantidad = 5, Fecha = new DateTime(2024, 7, 9) },
            new Venta { Cliente = "Cliente3", Producto = "Producto5", Cantidad = 1, Fecha = new DateTime(2024, 4, 8) },
            new Venta { Cliente = "Cliente4", Producto = "Producto8", Cantidad = 4, Fecha = new DateTime(2024, 2, 1) },
            new Venta { Cliente = "Cliente5", Producto = "Producto3", Cantidad = 7, Fecha = new DateTime(2024, 10, 6) },
            new Venta { Cliente = "Cliente6", Producto = "Producto9", Cantidad = 2, Fecha = new DateTime(2024, 9, 10) }
        };

            // Cantidad de ventas por cliente
            var ventasPorCliente = from venta in ventas
                                   group venta by venta.Cliente into g
                                   select new { Cliente = g.Key, TotalVentas = g.Sum(v => v.Cantidad) };

            Console.WriteLine("Cantidad de ventas por cliente: ");
            foreach (var resultado in ventasPorCliente)
            {
                Console.WriteLine($"{resultado.Cliente}: {resultado.TotalVentas} unidades");
            }

            // La cantidad total por producto
            var ventasPorProducto = from venta in ventas
                                    group venta by venta.Producto into g
                                    select new { Producto = g.Key, TotalVentas = g.Sum(v => v.Cantidad) };

            Console.WriteLine("\nCantidad de ventas por producto: ");
            foreach (var resultado in ventasPorProducto)
            {
                Console.WriteLine($"{resultado.Producto}: {resultado.TotalVentas} unidades");
            }

            // Determina el día con más ventas
            var diaConMasVentas = (from venta in ventas
                                   group venta by venta.Fecha into g
                                   orderby g.Sum(v => v.Cantidad) descending
                                   select g.Key).First();

            Console.WriteLine($"\nDía con mayor ventas: {diaConMasVentas.ToShortDateString()}");

            Console.ReadLine();
        }
    }

    class Venta
    {
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
    }

