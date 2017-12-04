using System;

namespace csharp8
{
    struct Punto 
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + z;
        }

        public static Punto operator +(Punto uno, Punto otro)
        {
            uno.X += otro.X;
            uno.Y += otro.Y;
            uno.Z += otro.Z;

            return uno;
        }
    }

    struct Prisma
    {
        public Punto puntoA;
        public Punto puntoB;
        public Punto altura;
    }
}
