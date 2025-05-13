using System;

namespace InfoSci
{
     class Program
    {
        

        static void Main(string[] args)
        {
            float a = 0;
            float b = 5;

            float[] h = {0.05F, 0.1F, 0.2F};

            float alpha = 1;

  

            for (int i = 0; i < h.Length; i++)
            {
                int N = (int)((b - a) / h[i]);

                Approximation.RungeKutta4(a, b, N, alpha, (t, y) => -y + t + 1);

                Console.WriteLine();
            }

            
        }



    }
}
