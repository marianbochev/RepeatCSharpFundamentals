using System;
using System.Numerics;
namespace TrailingZeroInNFactoriel
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            int sumOfZeros = 0;
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            BigInteger cutLastDigit = factoriel;
            while (cutLastDigit!=0)
            {
                BigInteger getLastDigit = cutLastDigit % 10;
                if (getLastDigit == 0)
                {
                    sumOfZeros++;
                }
                else
                {
                    break;
                }
                cutLastDigit /= 10;
            }
            Console.WriteLine(sumOfZeros);
        }
    }
}