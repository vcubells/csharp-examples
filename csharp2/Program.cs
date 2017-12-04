using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre un número: ");
            string cadena = Console.ReadLine();

            int numero = Int32.Parse(cadena);

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Entraste un uno");
                    break;
                case 2:
                    Console.WriteLine("Entraste un dos");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Entraste un 3 o un 4");
                    break;
                default:
                    Console.WriteLine("Entraste un número diferente de 1, 2, 3 o 4");
                    break;

            }

        }
    }
}
