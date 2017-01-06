using System;

namespace GCD
{
    class GCD
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int startFrom = Math.Min(a, b);
            for (int i = startFrom; i > 0; i--)
            {
                if(a%i==0 && b % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
