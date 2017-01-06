using System;

namespace SomeChars
{
    class SomeChars
    {
        static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());
            Console.WriteLine(symbol);
            Console.WriteLine((int)(symbol));

            char symbolPlusFive = (char)(symbol + 5);
            Console.WriteLine(symbolPlusFive);
        }
    }
}
