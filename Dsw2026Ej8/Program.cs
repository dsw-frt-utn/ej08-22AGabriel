namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------
            // ------------------   Ejercicio 1   --------------------
            // -------------------------------------------------------
            /*  
            ProductHelper helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto(123456789, "Teclado Gamer", 45000.50m);

            Console.WriteLine(etiqueta);
            */
            // -------------------------------------------------------
            // ------------------   Ejercicio 2   --------------------
            // -------------------------------------------------------
            /*
            Problema2 problema2 = new Problema2();

            string resultado1 = problema2.CrearResumenVenta(1234, "Mouse Inalámbrico", 2, 15000.50m);
            Console.WriteLine(resultado1);

            //Prueba con cantidad menor o igual a 0
            string resultado2 = problema2.CrearResumenVenta(1234, "Mouse Inalámbrico", -1, 15000.50m);
            Console.WriteLine(resultado2);
            */
            // -------------------------------------------------------
            // ------------------   Ejercicio 3   --------------------
            // -------------------------------------------------------
            /*
            Product producto = new Product();
            producto.Description = "Mouse Original";

            Problema3 problema3 = new Problema3();

            int numeroOriginal = 5;
            string resultado = problema3.CompararCopias(numeroOriginal, producto);

            Console.WriteLine(resultado);
            */
            // -------------------------------------------------------
            // ------------------   Ejercicio 4   --------------------
            // -------------------------------------------------------
            /*
            Problema4 problema = new Problema4();

            Console.WriteLine(problema.CalcularPromedio(10, 8, 6));

            Console.WriteLine(problema.CalcularPromedio(null, -10, 7));

            Console.WriteLine(problema.CalcularPromedio(null, null, null));
            */
            // -------------------------------------------------------
            // ------------------   Ejercicio 5   --------------------
            // -------------------------------------------------------
            Problema5 problema = new Problema5();

            RetailSale ventaMenor = new RetailSale();
            ventaMenor.Subtotal = 1000m;
            decimal totalMenor = problema.ObtenerImporteFinal(ventaMenor);
            Console.WriteLine("Total minorista: " + totalMenor);

            WholesaleSale ventaMayor = new WholesaleSale();
            ventaMayor.Subtotal = 1000m;
            decimal totalMayor = problema.ObtenerImporteFinal(ventaMayor);
            Console.WriteLine("Total mayorista: " + totalMayor);
        }
    }
}
