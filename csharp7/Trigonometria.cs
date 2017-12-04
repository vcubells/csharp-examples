using System;

namespace csharp7
{
     static class Trigonometria
    {
        /* Métodos */
        public static float GradosARadianes(float grados)
        {
            return (float)Math.PI * grados / 180;
        }

        public static float RadianesAGrados(float radianes)
        {
            return 180 * radianes / (float)Math.PI;
        }


        public static double seno(float radianes)
        {
            return Math.Sin(radianes);
        }

        public static double seno(double grados)
        {
            return Math.Sin(GradosARadianes((float)grados));
        }


        public static double coseno(float radianes)
        {
            return Math.Cos(radianes);
        }

        public static double coseno(double grados)
        {
            return Math.Cos(GradosARadianes((float)grados));
        }

        public static double tangente(float radianes)
        {
            return Math.Tan(radianes);
        }

        public static double tangente(double grados)
        {
            return Math.Tan(GradosARadianes((float)grados));
        }

        public static double cotangente(float radianes)
        {
            return 1 / Math.Tan(radianes);
        }

        public static double cotangente(double grados)
        {
            return 1 / Math.Tan(GradosARadianes((float)grados));
        }

    }
}
