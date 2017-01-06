using System;

namespace MMSA
{
    class MMSA
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal minNumber = decimal.MaxValue;
            decimal maxNumber = decimal.MinValue;
            decimal sumOfNumbers = 0;
            decimal average = 0m;
            for (int i = 0; i <n; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());
                if (minNumber > numbers)
                {
                    minNumber = numbers;
                }
                else if(maxNumber<numbers)
                {
                    maxNumber = numbers;
                }
                sumOfNumbers += numbers;
                average = (decimal)sumOfNumbers / n;
            }
            Console.WriteLine("min={0:f2}",minNumber);
            Console.WriteLine("max={0:f2}",maxNumber);
            Console.WriteLine("sum={0:f2}",sumOfNumbers);
            Console.WriteLine("avg={0:f2}",average);
        }
    }
}
