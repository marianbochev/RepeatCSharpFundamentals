﻿using System;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int k = i;
                k++;
                for (int j =k; j <= n; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
