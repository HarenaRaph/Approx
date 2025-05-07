using System;

namespace InfoSci
{
    public class Resolution
    {
        public void Euler(float tInitial, float tFinal, int N, float y0, Func<float, float, float> yPrim)
        {

            //Step 1
            float h = (tFinal - tInitial) / N;
            float t = tInitial;
            float w = y0;

            Console.WriteLine($"t0: {t} y0: {w}");

            //Step 2
            for (int i = 1; i <= N; i++) {

                //Step 3
                w += h * yPrim(t, w);
                t = tInitial + i * h;

                //Step 4
                Console.WriteLine($"t{i + 1}: {t} y{i + 1}: {w}");
            }
        }

        public void PointMilieu(float tInitial, float tFinal, int N, float y0, Func<float, float, float> yPrim)
        {
            //Step 1
            float h = (tFinal - tInitial) / N;
            float t = tInitial;
            float w = y0;

            Console.WriteLine($"t0: {t} y0: {w}");

            //Step 2
            for (int i = 1; i <= N; i++)
            {

                //Step 3
                w +=  h * yPrim(t + (h/2) , w + (h/2) * yPrim( t, w));
                t = tInitial + i * h;

                //Step 4
                Console.WriteLine($"t{i + 1}: {t} y{i + 1}: {w}");
            }
        }

        public void RungeKutta4(float tInitial, float tFinal, int N, float y0, Func<float, float, float> yPrim)
        {

            //Step 1
            float h = (tFinal - tInitial) / N;
            float t = tInitial;
            float w = y0;

            Console.WriteLine($"t0: {t} y0: {w}");

            //Step 2
            for (int i = 1; i <= N; i++)
            {

                //Step 3
                float k1 = h * yPrim(t, w);

                float k2 = h * yPrim(t + (h / 2), w + (k1 / 2));

                float k3 = h * yPrim(t + (h / 2), w + (k2 / 2));

                float k4 = h * yPrim(t + h, w + k3);

                //Step 4
                w += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                t = tInitial + i * h;

                //Step 5
                Console.WriteLine($"t{i + 1}: {t} y{i + 1}: {w}");
            }
        }
    }
}
