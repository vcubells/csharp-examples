using System;

namespace csharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto pan = new Producto() { Descripcion = "Pan", Precio = 1.20f };

            Console.WriteLine(pan);

            Producto tortilla = new Producto() { Descripcion = "Tortilla", Precio = 11.50f, Cantidad = 2 };

            Console.WriteLine(tortilla);

            Almacen almacen = new Almacen();

            almacen.InsertarProducto(pan);

            Console.WriteLine("El producto 1 es : {0}", almacen[0]);

            //almacen.ActualizaProducto(tortilla, 0);

            //Console.WriteLine("El producto 1 es : {0}", almacen.ObtenerProducto(0));

            almacen[0] = tortilla;
            Console.WriteLine("El producto 1 es : {0}", almacen[0]);

            almacen.Inventario();
            almacen.Inventario(0);
            almacen.Inventario(0, pan);

            Console.WriteLine("Pan + Tortilla = {0}", pan + tortilla);

            string cmp = pan < tortilla ? "Pan es mas barato" : "Tortilla es mas barata";

            Console.WriteLine(cmp);

            if (pan == tortilla) // Producto.==(pan, tortilla)
            {
                Console.WriteLine("Pan == Tortilla");
            }
            else
            {
                Console.WriteLine("Pan != Tortilla");
            }

            // Imprimir todo el almacen
            almacen.InsertarProducto(new Producto());
            Console.WriteLine(almacen);

        }
    }
}
