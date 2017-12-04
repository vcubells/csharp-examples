using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Rango linea = new Rango() { Superior = 100 };

            try
            {
                linea.Inferior = 20;
            }

            catch (OutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Siempre paso por aquí");
            }
        
        }
    }
}
