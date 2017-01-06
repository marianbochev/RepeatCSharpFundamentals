using System;

namespace DevideBy7And5
{
    class DevideBy7And5
    {
        static void Main()
        {
            int numberToCheck = int.Parse(Console.ReadLine());

            if (numberToCheck % 7 == 0 && numberToCheck % 5 == 0)
            {
                Console.WriteLine("true " + numberToCheck);
            }
            else
            {
                Console.WriteLine("false " + numberToCheck);
            }
        }
    }
}
