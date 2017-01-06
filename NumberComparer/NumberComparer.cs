using System;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            //first way,with ternary operator
            Console.WriteLine(a>b? a:b);
            //second way with Math.Max;
            Console.WriteLine(Math.Max(a,b));
        }
    }
}
