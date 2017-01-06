using System;

namespace WhileLoop
{
    class WhileLoop
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber = 1;
            while (currentNumber <= n)
            {
                sum += currentNumber;
                currentNumber++;
            }
            Console.WriteLine(sum);
        }
    }
}
