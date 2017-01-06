using System;

namespace PrimeCheckerWithWhile
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int devisor = 2;
            string isPrime = "is Prime";
            if (n > 1)
            {
                while (devisor < Math.Sqrt(n))
                {
                    if (n % devisor == 0)
                    {
                        isPrime = "is not prime";
                        break;
                    }
                    devisor++;
                }
            }
            Console.WriteLine(isPrime);
        }
    }
}
