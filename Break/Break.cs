using System;

namespace Break
{
    class Break
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int sum = 1;
            while (counter<=n)
            {
                sum *= counter;
                counter++;
            }
            Console.WriteLine(sum);
        }
    }
}
