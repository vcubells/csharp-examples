using System;
using System.Collections;

namespace csharp6
{   
    class Almacen
    {
        private ArrayList productos = new ArrayList();
        private string[] documentos = new string[10];

        public Producto this[int index]
        {
            get { return (productos[index] as Producto); }
            set { productos[index] = value; }

        }

        //public string this[int index]
        //{
        //    get { return documentos[index]; }
        //    set
        //    {
        //        if (index < 10)
        //        {
        //            documentos[index] = value;
        //        }
        //        else
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //    }
        //}

        public void InsertarProducto(Producto p)
        {
            productos.Add(p);
        }

        //public Producto ObtenerProducto(int posicion)
        //{
        //    return (productos[posicion] as Producto);
        //}

        //public void ActualizaProducto(Producto p, int posicion)
        //{
        //    productos[posicion] = p;
        //}

        public void Inventario()
        {
            Console.WriteLine("Inventario vacio");
        }

        public void Inventario(int index)
        {
            Console.WriteLine("Elemento en {0} = {1}", index, this[index]);
        }

        public void Inventario(int index, Producto p)
        {
            this[index] = p;
        }

        //public override string ToString()
        //{
        //    string todos = "";

        //    foreach (Producto p in productos)
        //    {
        //        todos += p;
        //    }

        //    return todos;
        //}

    }
}
