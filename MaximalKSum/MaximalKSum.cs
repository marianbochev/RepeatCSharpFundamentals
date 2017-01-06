using System;
using System.Linq;
namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int maxNumber = 0;
            int sum = 0;
            int nextNumber = 0;
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i <= k; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    nextNumber = numbers[j];
                    if (numbers[j] > maxNumber)
                    {
                        maxNumber = numbers[j];
                    }
                }
                sum += maxNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
