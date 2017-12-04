using System;
using System.Threading;

namespace csharp17
{
    public class TimerEventArgs : EventArgs
    {
        private int contador = 0;

        public int Contador
        {
            get { return contador; }
            set { contador = value; }
        }
    }
    
    class Timer
    {
        private event Temporizador reloj = null;

        public Temporizador Reloj
        {
            set { reloj = value; }
        }

        public void Señal()
        {
            for (int i = 0; i < 20; ++i)
            {
                Thread.Sleep(1000);
                reloj(this, new TimerEventArgs() { Contador = i + 1 });
            }
        }
    }
}
