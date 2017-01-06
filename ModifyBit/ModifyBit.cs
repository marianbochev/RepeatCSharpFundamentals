using System;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            byte p = byte.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());
            ulong mask;
            if (v == 0)
            {
                mask = (ulong) ~(1 << p);
                Console.WriteLine(n & mask);
            }
            else
            {
                mask = (ulong)1 << p;
                Console.WriteLine(n | mask);
            }
        }
    }
}
