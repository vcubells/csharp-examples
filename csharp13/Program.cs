using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> biblioteca = new List<Libro>();

            biblioteca.Add(new Libro() { Paginas = 250, Isbn = "ABC2345" });
            biblioteca.Add(new Libro() { Paginas = 450, Isbn = "ZXY897" });
            biblioteca.Add(new Libro() { Paginas = 100, Isbn = "JKL123" });

            biblioteca.Sort();

            foreach (Libro libro in biblioteca)
            {
                Console.WriteLine(libro);
            }

            Libro buscar = biblioteca[2];

            if (buscar.Equals(new Libro() { Paginas = 100, Isbn = "JKL123" }))
            {
                Console.WriteLine("Son iguales");
            }

            int index = biblioteca.BinarySearch(buscar);
            if (index >= 0)
            {
                Console.WriteLine("El libro {0} se encuentra en la posición {1}", buscar, index);
            }
            else
            {
                Console.WriteLine("El libro {0} no se encuentra", buscar);
            }

        }
    }
}
