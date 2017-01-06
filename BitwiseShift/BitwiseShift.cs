using System;

namespace BitwiseShift
{
    class BitwiseShift
    {
        static void Main()
        {
            //int number = 17;
            //int mask = 1 << 4;
            //Console.WriteLine((number & mask) >> 4);

            //int n = 14;
            //Console.WriteLine((n >> 4) & 1);

            int n = 17;
            Console.WriteLine(n & ~(1 << 4));
        }
    }
}
