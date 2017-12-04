using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace csharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Documento[] biblioteca = new Documento[5];
            
            biblioteca[0] = new Documento("Cien años de soledad");
            biblioteca[1] = new Libro();
            biblioteca[2] = new Tesis();
            biblioteca[3] = new Libreto();
            biblioteca[4] = new Folleto();

            Tesis t = new Tesis();
            Console.WriteLine(t.Titulo);

            biblioteca[3] = null;
 

            t.Titulo = "cadena";

            foreach (Documento d in biblioteca)
            {
                if (d != null)
                    Console.WriteLine(d.ToString());
            }
            
            
        }
    }

    class Documento
    {
        private string title = "Sin titulo";


        public string Titulo
        {
            get { return title; }
            set { title = value; }
        }

        public Documento() : this ("La guerra de los mundos")
        {    
        }

        public Documento(string s)
        {
            this.Titulo = s;
        }

        public override string ToString()
        {
            return Titulo;
        }
    }

    class Tesis : Documento
    {
        private string asesor = "Sin asesor";

        public string Asesor
        {
            get { return asesor; }
            set { asesor = value; }
        }

        public override string ToString()
        {
            return Titulo;
        }
    }

    class Libro : Documento
    {
        // Atributos miembro o campos
        private string isbn = "6373839";

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public Libro()
            : base("Startup of you")
        {
        }

        public override string ToString()
        {
            return Titulo;
        }

    }

    sealed class Folleto : Documento
    {
        public override string ToString()
        {
            return "Soy un folleto";
        }
    }

    class Libreto : Libro
    {
    }
}
