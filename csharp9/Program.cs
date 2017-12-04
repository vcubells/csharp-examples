using System;

namespace csharp9
{
    class Program
    {
        enum Numeros
        { 
            Uno, 
            Dos 
        };

        enum DiasSemana : byte
        {
            Lunes = 1,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado,
            Domingo
        }

        enum Tipos : byte
        {
            Ninguno = 0,
            Lectura = 2,
            Escritura = 4,
            Oculto = 8,
            LO = 10,
            Sistema = 16,
            Todos = 255
        }

        static void Main(string[] args)
        {
            //Console.Write("Entra un número: ");
            //Numeros valor = (Numeros)Int32.Parse(Console.ReadLine());

            //switch (valor)
            //{
            //    case Numeros.Uno:
            //        Console.WriteLine("Entraste un uno");
            //        break;
            //    case Numeros.Dos:
            //        Console.WriteLine("Entraste un dos");
            //        break;
            //}

            DiasSemana lunes = DiasSemana.Sabado;

            Console.WriteLine("El día {0} se representa con {1}", lunes, (int)lunes);

            Tipos modo = Tipos.Lectura | Tipos.Oculto | Tipos.Sistema;

            if ((modo & Tipos.Todos) == Tipos.Lectura)
            {
                Console.WriteLine("Solo está activo el bit de lectura");
            }
            else
            {
                Console.WriteLine("Hay más bits activos");
            }
        }
    }
}
