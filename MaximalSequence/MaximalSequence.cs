using System;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int maxSeq = 1;
            int sequence = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] -= numbers[i + 1])
                {
                    sequence++;
                }
                else if (numbers[i] != numbers[i + 1])
                {
                   
                    if (maxSeq < sequence)
                    {
                        maxSeq = sequence;
                    }
                    sequence = 1;
                }
            }
            Console.WriteLine(Math.Max(sequence,maxSeq));
        }
    }
}
