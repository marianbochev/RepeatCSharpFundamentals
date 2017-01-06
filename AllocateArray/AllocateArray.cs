using System;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[n];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = i;
                arrayOfNumbers[i] *= 5;
                Console.WriteLine(arrayOfNumbers[i]);
            }
        }
    }
}
