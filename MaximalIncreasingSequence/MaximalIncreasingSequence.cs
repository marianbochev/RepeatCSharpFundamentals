using System;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sequence = 1;
            int maxSeq = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    sequence++;
                }
                else if (numbers[i] >= numbers[i + 1])
                {
                    if (maxSeq < sequence)
                    {
                        maxSeq = sequence;
                    }
                    sequence = 1;
                }
            }
            Console.WriteLine(Math.Max(maxSeq, sequence));
        }
    }
}
