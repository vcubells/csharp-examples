using System;

namespace csharp16
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numeros = { 20, 65, 3, 16, 8, 90 };

            
            Ordenamiento<int>.AlgoritmoOrdenamiento algoritmo = new Ordenamiento<int>.AlgoritmoOrdenamiento(Ordenamiento<int>.Burbuja);
             algoritmo += new Ordenamiento<int>.AlgoritmoOrdenamiento(Ordenamiento<int>.MergeSort);
             algoritmo += new Ordenamiento<int>.AlgoritmoOrdenamiento(Ordenamiento<int>.HeapSort);

            Ordenamiento<int> ordenaEnteros = new Ordenamiento<int>(numeros, 
                algoritmo,
                new Ordenamiento<int>.Compara(Ordenamiento<int>.Menor)
                );

            foreach (int e in numeros)
            {
                Console.Write("\t {0}", e);
            }

            Console.WriteLine("\n ----- Flotantes ------ \n");

            float[] flotantes = { 1.5f, 89.9f, 3.67f, 16.56f };

            Ordenamiento<float> ordenaFlotantes = new Ordenamiento<float>(
                flotantes,
                new Ordenamiento<float>.AlgoritmoOrdenamiento(Ordenamiento<float>.Burbuja),
                new Ordenamiento<float>.Compara(Ordenamiento<float>.Mayor)
                );

            foreach (float e in flotantes)
            {
                Console.Write("\t {0}", e);
            }

            Console.WriteLine("\n ----- Caracteres ------ \n");

            char[] cadena = { 'd', 'a', 'z', 'o' };

            Ordenamiento<char> ordenaCars = new Ordenamiento<char>(
                cadena,
                new Ordenamiento<char>.AlgoritmoOrdenamiento(Ordenamiento<char>.Burbuja),
                new Ordenamiento<char>.Compara(Ordenamiento<char>.Menor)
                );

            foreach (char e in cadena)
            {
                Console.Write("\t {0}", e);
            }

            
           /* Ordenamiento(numeros, 
                algoritmo, 
                new Compara(Menor)
                );
            */

          /*  Ordenamiento(numeros,
                new AlgoritmoOrdenamiento(MergeSort),
                new Compara(Menor)
                );

            Ordenamiento(numeros,
                new AlgoritmoOrdenamiento(HeapSort),
                new Compara(Menor)
                );
            */

            /* Imprimir el arreglo */
         /*   foreach (int e in numeros)
            {
                Console.Write("\t {0}", e);
            }
            */
            Console.WriteLine();
        }


        
        
    }
}
