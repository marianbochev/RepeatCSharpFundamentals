using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            BigInteger nFactoriel = 1;
            BigInteger kFactoriel = 1;
            for (long i = 1, j = 1; i <= n || j <= k; i++, j++)
            {
                if (n >= i)
                {
                    nFactoriel *= i;
                }
                if (k >= j)
                {
                    kFactoriel *= j;
                }
            }
            Console.WriteLine(nFactoriel/kFactoriel);
        }
    }
}
