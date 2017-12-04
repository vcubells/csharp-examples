using System;

namespace csharp6
{
    class Producto
    {
        private string descripcion;
        private float precio;
        private int cantidad;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public float Precio
        {
            get { return precio; }
            set {
                if (value < 0)
                {
                    precio = 0;
                }
                else
                {
                    precio = value;
                }
            }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Producto()
            //: this("Sin definir", 0f, 0)
        {
            Descripcion = "Sin definir";
            Precio = 0f;
            Cantidad = 0;
        }

        //public Producto(string descripcion, float precio, int cantidad)
        //{
        //    Descripcion = descripcion;
        //    Precio = precio;
        //    Cantidad = cantidad;
        //}

        public override string ToString()
        {
            return descripcion + ", " + precio + ", " + cantidad;
        }

        // Sobrecarga del operador suma
        public static float operator +(Producto uno, Producto otro)
        {
            return uno.Precio + otro.Precio;
        }

        public static bool operator <(Producto uno, Producto otro)
        {
            return uno.Precio < otro.Precio;
        }

        public static bool operator >(Producto uno, Producto otro)
        {
            return uno.Precio > otro.Precio;
        }

        public static bool operator ==(Producto uno, Producto otro)
        {
            return (uno.Descripcion == otro.Descripcion &&
                     uno.Precio == otro.Precio &&
                     uno.Cantidad == otro.Cantidad);
        }

        public static bool operator !=(Producto uno, Producto otro)
        {
            return !(uno == otro);
        }

    }
}
