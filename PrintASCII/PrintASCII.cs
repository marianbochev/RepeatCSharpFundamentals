using System;

namespace PrintASCII
{
    class PrintASCII
    {
        static void Main()
        {
            for (int i = 33; i <= 126; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}
