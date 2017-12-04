using System;

namespace csharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizR = {
                                 {2, 3, 4},
                                 {5, 6, 7}
                             };

            int[][] matrizE = new int[2][];

            matrizE[0] = new int[10];
            matrizE[1] = new int[3];

            int f = 1, c;

            foreach (int[] fila in matrizE)
            {
                c = 1;

                foreach (int n in fila)
                {
                    Console.WriteLine("[{0}][{1}] = {2}", f, c, n);
                    c++;
                }

                f++;
                Console.WriteLine();

            }


        }
    }
}
