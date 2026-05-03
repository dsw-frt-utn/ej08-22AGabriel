namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            /*  
            ProductHelper helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto(123456789, "Teclado Gamer", 45000.50m);

            Console.WriteLine(etiqueta);
            */

            // Ejercicio 2

            Problema2 problema2 = new Problema2();

            string resultado1 = problema2.CrearResumenVenta(1234, "Mouse Inalámbrico", 2, 15000.50m);
            Console.WriteLine(resultado1);

            //Prueba con cantidad menor o igual a 0
            string resultado2 = problema2.CrearResumenVenta(1234, "Mouse Inalámbrico", -1, 15000.50m);
            Console.WriteLine(resultado2);
        }
    }
}
