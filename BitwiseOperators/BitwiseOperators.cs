using System;

namespace BitwiseOperators
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            int store = a;
            a = b;
            b = store;
            Console.WriteLine(a + " " + b);
        }
    }
}
