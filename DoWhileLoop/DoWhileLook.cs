using System;
using System.Numerics;

namespace DoWhileLoop
{
    class DoWhileLook
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger sum = 1;
            BigInteger counter = 1;
            do
            {
                sum *= counter;
                counter++;
            } while (counter <=n);
            Console.WriteLine(sum);
        }
    }
}
