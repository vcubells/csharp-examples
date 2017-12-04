using System;
using System.Collections.Generic;

namespace csharp12
{
    class Program
    {
        const int veces = 10000;

        static void Main(string[] args)
        {
             Dictionary<int, int> frecuencias = new Dictionary<int, int>();

            Random rand = new Random();

            int numero;

            for (int i = 0; i < veces; ++i)
            {
                numero = rand.Next(1, 11);
                if (frecuencias.ContainsKey(numero))
                {
                    frecuencias[numero]++;
                }
                else
                {
                    frecuencias[numero] = 1;
                }
            }

            /* Imprimir el histograma */
            foreach (int key in frecuencias.Keys)
            {
                Console.WriteLine("{0} se generó {1} veces", key, frecuencias[key]);
            }

        }
    }
}
