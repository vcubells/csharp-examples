using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp10
{
    class Rango
    {
        private int limiteInferior;
        private int limiteSuperior;

        public int Inferior
        {
            get { return limiteInferior; }
            set
            {
                if (value <= limiteSuperior)
                {
                    limiteInferior = value;
                }
                else
                {
                    throw new OutOfRangeException(value, limiteSuperior);
                }
            }
        }

        public int Superior
        {
            get { return limiteSuperior; }
            set
            {
                if (value >= limiteInferior)
                {
                    limiteSuperior = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
