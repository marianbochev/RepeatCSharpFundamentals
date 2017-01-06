using System;

namespace NumbersFrom1ToNN
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.Write("{0} ",i);
            }
        }
    }
}
