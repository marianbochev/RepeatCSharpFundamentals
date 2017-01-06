using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string isPrime = "true";
            if (number > 1)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = "false";
                        break;
                    }
                }
            }
            else
            {
                isPrime = "false";
            }
            Console.WriteLine(isPrime);
        }
    }
}
