using System;

namespace Interval
{
    class Interval
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = firstNumber+1; i < secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    sum += 1;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
