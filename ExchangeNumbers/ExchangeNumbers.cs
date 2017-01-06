using System;

namespace ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double greaterNumber = Math.Max(a, b);
            if (greaterNumber == a)
            {
                Console.WriteLine("{0} {1}",b,a);
            }
            else
            {
                Console.WriteLine("{0} {1}",a,b);
            }
        }
    }
}
