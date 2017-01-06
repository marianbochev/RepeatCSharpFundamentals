using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int numberToCheck = int.Parse(Console.ReadLine());

            if (numberToCheck % 2 == 0)
            {
                Console.WriteLine("even " + numberToCheck);
            }
            else
            {
                Console.WriteLine("odd " + numberToCheck);
            }
        }
    }
}
