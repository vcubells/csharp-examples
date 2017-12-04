using System;

namespace csharp16
{

    class Ordenamiento<T>
    {
        /* Ordenamiento */

        public delegate bool Compara(T a, T b);
        public delegate void AlgoritmoOrdenamiento(T[] n, Compara orden);

        
        public Ordenamiento(T[] n, AlgoritmoOrdenamiento algoritmo, Compara orden)
        {
            algoritmo(n, orden);
        }

        public static bool Mayor(int a, int b)
        {
            return a > b;
        }

        public static bool Menor(int  a, int b)
        {
            return a < b;
        }

        public static bool Mayor(float a, float b)
        {
            return a > b;
        }

        public static bool Menor(float a, float b)
        {
            return a < b;
        }

        public static bool Mayor(char a, char b)
        {
            return a > b;
        }

        public static bool Menor(char a, char b)
        {
            return a < b;
        }

        static void swap(ref T a, ref T b)
        {
            T temp;

            temp = a;
            a = b;
            b = temp;
        }

        public static void Burbuja(T[] numeros, Compara orden)
        {
            for (int i = 0; i < numeros.Length; ++i)
            {
                for (int j = 0; j < numeros.Length - 1; ++j)
                {
                    if ( orden(numeros[j + 1], numeros[j]))
                    {
                        swap(ref numeros[j + 1], ref numeros[j]);
                    }
                }
            }
        }

        public static void QuickSort(T[] numeros, Compara orden)
        {
            Console.WriteLine("Estoy utilizando QuickSort");
        }

        public static void MergeSort(T[] numeros, Compara orden)
        {
            Console.WriteLine("Estoy utilizando MergeSort");
        }

        public static void HeapSort(T[] numeros, Compara orden)
        {
            Console.WriteLine("Estoy utilizando HeapSort");
        }

        public static void SelectionSort(T[] numeros, Compara orden)
        {
            Console.WriteLine("Estoy utilizando SelectionSort");
        }

    }
}
