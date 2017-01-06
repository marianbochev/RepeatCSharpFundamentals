using System;

namespace SelectionSortArray
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine(string.Join("\n",numbers));
        }
    }
}
