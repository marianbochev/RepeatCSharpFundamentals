using System;

namespace NThBit
{
    class NThBit
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            byte bit = byte.Parse(Console.ReadLine());
            Console.WriteLine((number >> bit) & 1);
        }
    }
}
