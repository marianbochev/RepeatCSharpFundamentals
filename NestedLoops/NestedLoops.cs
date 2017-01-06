using System;

namespace NestedLoops
{
    class NestedLoops
    {
        static void Main()
        {
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string isPrime = "true";
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
