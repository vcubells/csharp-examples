using System;

namespace csharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto p1 = new Punto() { X = 10, Y = 10 };

            Punto p2 = new Punto() { X = 20, Y = 20 };

            Punto altura = new Punto() { Z = 40 };

            Prisma baseRect;
            baseRect.puntoA = p1;
            baseRect.puntoB = p2;
            baseRect.altura = altura;

            Console.WriteLine("Punto A = {0}", p1);
            Console.WriteLine("Punto B = {0}", p2);

            Console.WriteLine("A + B = {0}", p1 + p2);
            p1 += p2;

            Console.WriteLine("Punto A = {0}", p1);

        }
    }
}
