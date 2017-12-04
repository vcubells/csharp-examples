using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp15
{
    class Program
    {
        public delegate int Operacion(int a, int b);

        static void Main(string[] args)
        {

            Operacion delegado = null;

            Console.WriteLine("Entre un número: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entre otro número: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Menu \n ----------------------------");
            Console.WriteLine("Para sumar seleccione la tecla +");
            Console.WriteLine("Para restar seleccione la tecla -");
            Console.WriteLine("Para multiplicar seleccione la tecla *");
            Console.WriteLine("Para dividir seleccione la tecla /");

            char operador = (char)Console.Read();

            switch (operador)
            {
                case '+':
                    //resultado = suma(a, b);
                    delegado = new Operacion(suma);
                    break;
                case '-':
                    //resultado = resta(a, b);
                    delegado = new Operacion(resta);
                    break;
                case '*':
                    //resultado = multiplica(a, b);
                    delegado = new Operacion(multiplica);
                    break;
                case '/':
                    //resultado = divide(a, b);
                    delegado = new Operacion(divide);
                    break;
            }

            RealizarOperacion(a, b, operador, delegado);
            

        }

        static void RealizarOperacion(int a, int b, char op, Operacion operacion)
        {
            Console.WriteLine(" {0} {1} {2} = {3}", a, op, b, operacion(a,b));
        }

        static int suma(int a, int b)
        {
            return a + b;
        }

        static int resta(int a, int b)
        {
            return a - b;
        }

        static int multiplica(int a, int b)
        {
            return a * b;
        }

        static int divide(int a, int b)
        {
            return a / b;
        }
    }
}
