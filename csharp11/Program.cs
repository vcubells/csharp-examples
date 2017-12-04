using System;
using System.Collections;
using System.Collections.Generic;

namespace csharp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== ArrayList =======");

            ArrayList lista = new ArrayList(2);

            lista.Add(1);
            lista.Add(-56);
            lista.Add("tres");

            lista.Insert(0, "diez");

            //lista.Clear();

            foreach (object o in lista)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("====== Pila =======");

            Stack pila = new Stack(lista);

            pila.Push(100);

            foreach (object o in pila)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine(" Saqué el elemento: {0}", pila.Pop());
            Console.WriteLine("Ahora tengo {0} elementos", pila.Count);

            Console.WriteLine("====== Cola =======");

            Queue cola = new Queue(lista);

            foreach (object o in cola)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine(" Saqué el elemento: {0}", cola.Dequeue());
            Console.WriteLine("Ahora tengo {0} elementos", cola.Count);

            Console.WriteLine("====== Hashtable =======");

            Hashtable hash = new Hashtable();

            hash["uno"] = "Primero";
            hash["cinco"] = "Último";
            hash["dos"] = 2;

            Console.WriteLine("El elemento con llave {0} es {1}", "dos", hash["dos"]);

            foreach (string key in hash.Keys)
            {
                Console.WriteLine("{0} => {1}", key, hash[key]);
            }

        }
    }
}
