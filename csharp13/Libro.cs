using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp13
{
    class Libro : IComparable<Libro>, IEquatable<Libro>
    {
        private string isbn;
        private int paginas;

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public int Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }

        public override string ToString()
        {
            return Isbn + "(" + Paginas + " páginas)";
        }

        public int CompareTo(Libro otro)
        {
            return Paginas.CompareTo(otro.Paginas);
        }

        public bool Equals(Libro otro)
        {
            return Isbn.Equals(otro.Isbn) && Paginas.Equals(otro.Paginas);
        }
    }
}
