using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace csharp5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList figuras = new ArrayList();

            string seguir = "s";
            string opc;

            do
            {
                Console.Write(" 'c'- Circulo / 'u' - Cuadrado :");
                opc = Console.ReadLine();
                
                if (opc == "c")
                {
                    figuras.Add(new Circulo());
                }
                else if (opc == "u")
                {
                    figuras.Add(new Cuadrado());
                }

                Console.Write("Quieres seguir? s-Si / n-No");
                seguir = Console.ReadLine();
            } while (seguir == "s");

            Console.WriteLine("Se crearon {0} instancias", Figura.instancias);
        }
    }

    abstract class Figura
    {
        public static int instancias = 0;

        public Figura()
        {
            instancias++;
        }
        
        public abstract void Dibuja();

        public void Rellena()
        {
        }
    }

    class Circulo : Figura
    {
        public override void Dibuja()
        {
            Console.WriteLine("Soy un círculo");
        }
    }

    partial class Cuadrado : Figura
    {
        public override void Dibuja()
        {
            Console.WriteLine("Soy un cuadrado");
        }

    }

}
