using System;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine((number>>3)&1);
        }
    }
}
