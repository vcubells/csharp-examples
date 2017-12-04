using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp10
{
    class OutOfRangeException : ApplicationException
    {
        public OutOfRangeException(int inferior, int superior)
            : base("El límite inferior " + inferior + " no puede ser mayor que el superior " + superior)
        {
        }
    }
}
