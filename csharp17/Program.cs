using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp17
{
    public delegate void Temporizador(object sender, TimerEventArgs e);

    class Program
    {
        static void Main(string[] args)
        {
            Temporizador eventos = new Temporizador(OnReloj);
            eventos += new Temporizador(OnReloj2);

            Timer temporizador = new Timer() { Reloj = eventos  };

            temporizador.Señal();

        }

        static void OnReloj(object sender, TimerEventArgs e)
        {
            Console.WriteLine("Se generó una señal de reloj - {0}", e.Contador);
        }

        static void OnReloj2(object sender, TimerEventArgs e)
        {
            Console.WriteLine("Escribí en el archivo");
        }
    }
}
