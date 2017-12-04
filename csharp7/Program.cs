using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double angulo = 45;
            float radianes = 0.785f;

            Console.WriteLine("Seno de {0} grados = {1}", angulo, Trigonometria.seno(angulo));
            Console.WriteLine("Seno de {0} radianes = {1}", radianes, Trigonometria.seno(radianes));

            Console.WriteLine("Coseno de {0} grados = {1}", angulo, Trigonometria.coseno(angulo));
            Console.WriteLine("Coseno de {0} radianes = {1}", radianes, Trigonometria.coseno(radianes));

            Console.WriteLine("Tangente de {0} grados = {1}", angulo, Trigonometria.tangente(angulo));
            Console.WriteLine("Tangente de {0} radianes = {1}", radianes, Trigonometria.tangente(radianes));

            Console.WriteLine("Cotangente de {0} grados = {1}", angulo, Trigonometria.cotangente(angulo));
            Console.WriteLine("SeCotangenteno de {0} radianes = {1}", radianes, Trigonometria.cotangente(radianes));


        }
    }
}
