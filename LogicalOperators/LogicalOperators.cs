using System;

namespace LogicalOperators
{
    class LogicalOperators
    {
        static void Main()
        {
            int b = 37;
            int a = 5;
            Console.WriteLine(!(a<b) && !(a>b));
        }
    }
}
