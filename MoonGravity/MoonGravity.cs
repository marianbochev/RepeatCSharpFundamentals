using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine());
            double moonGravity = 0.17;
            double moonWeight = weight * moonGravity;
            Console.WriteLine("{0:F3}",moonWeight);
        }
    }
}
