﻿using System;

namespace NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
