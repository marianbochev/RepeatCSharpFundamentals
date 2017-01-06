using System;
using System.Linq;

namespace OddOrEvenProduct
{
    class OddOrEvenProduct
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string strNumbers = Console.ReadLine();
            int[] intNumbers = strNumbers.Split(' ').Select(int.Parse).ToArray();
            int sumOfOddProduct = 1;
            int sumOfEvenProduct = 1;
            for (int i = 0; i <intNumbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumOfEvenProduct *= intNumbers[i];
                }
                else
                {
                    sumOfOddProduct *= intNumbers[i];
                }
            }
            if (sumOfEvenProduct == sumOfOddProduct)
            {
                Console.WriteLine("yes {0} ",sumOfEvenProduct);
            }
            else 
            {
                Console.WriteLine("no {0} {1}",sumOfOddProduct,sumOfEvenProduct);
            }
        }
    }
}
