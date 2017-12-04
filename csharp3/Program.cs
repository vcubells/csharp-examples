using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Cada caracter en una linea";

            foreach (char s in cadena)
            {
                Console.WriteLine(s);
            }

            // Usando un for
            for (int i = 0; i < cadena.Length; ++i)
            {
                if (cadena[i] == 't') continue;
                Console.WriteLine(cadena[i]);

            }

            unchecked
            {
                int numero = 1000000 * 1000000;
                Console.WriteLine(numero);
            }

            // Trabajo con un archivo
            using (FileStream f = File.Open("creado.txt", FileMode.Open))
            {
               
            }
      
        }
    }
}
