using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte chico = 0;         // 8 bits, 1 byte   0-255
            sbyte uchico;        // -128 - 127
            short mediano = 0;       // 16 bits, 2 bytes 32738 - 32737
            ushort umediano;     //  0- 65535 
            int entero = 0;         // 32 bits, 4 bytes , -2,000 millones - 2,000 millones
            uint  uentero;             // 0 - 4,000 000 000
            long  grande = 0;        // 64 bits, 8 bytes > 9,000 000 000
            ulong ugrande;

            float flotante = 0.0f;     // 32 bits, 4 bytes, 7 u 8 dígitos
            double doble = 0.0;       // 64 bits, 8 bytes, 15 o 16 dígitos
            decimal dec = 0.0m;         // 128 bits, 16 bytes, 28 o 29 dígitos
           
            bool boleano = true;       // 8 bits, 1 byte (true, false)
            string cadena = "Texto";      // n caracteres,mutables  StringBuilder. No mutables String
            
            char caracter = 'C';      // 16 bits, 2 bytes. 

            Console.WriteLine("El tipo de chico es: {0}", chico.GetType());
            Console.WriteLine("El tipo de mediano es: {0}", mediano.GetType());
            Console.WriteLine("El tipo de entero es: {0}", entero.GetType());
            Console.WriteLine("El tipo de grande es: {0}", grande.GetType());
            Console.WriteLine("El tipo de flotante es: {0}", flotante.GetType());
            Console.WriteLine("El tipo de doble es: {0}", doble.GetType());
            Console.WriteLine("El tipo de dec es: {0}", dec.GetType());
            Console.WriteLine("El tipo de boleano es: {0}", boleano.GetType());
            Console.WriteLine("El tipo de caracter es: {0}", caracter.GetType());
            Console.WriteLine("El tipo de cadena es: {0}", cadena.GetType());

            // Boxing
            object o = flotante;
            Console.WriteLine("El objeto de tipo {0} tiene valor {1}", o.GetType(), o);

            // UnBoxing
           float otra = (float) o;
            Console.WriteLine("El objeto de tipo {0} tiene valor {1}", otra.GetType(), otra);


           // Operador is 
            string msg = (o is Int32) ? "La variable otra es un Int32" : "La variable otra NO es un Int32";

            Console.WriteLine(msg);


            // Operador as
            string ftoi;

            ftoi = o as string;

            string msg2 = ftoi ?? "o NO se puede convertir a string";

            Console.WriteLine(msg2);

            if (ftoi != null)
            {
                Console.WriteLine("o si se puede convertir a string");
            }
            else
            {
                Console.WriteLine("o NO se puede convertir a string");
            }

            


        
 
        }
    }
}
