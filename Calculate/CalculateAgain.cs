using System;

namespace Calculate
{
    class Calculate
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            //S=1+n!/x^n
            int nFactoriel = 1;
            double S = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactoriel *= i;
                S += nFactoriel / (double)(Math.Pow(x, i));
            }
            Console.WriteLine(S);

        }
    }
}
