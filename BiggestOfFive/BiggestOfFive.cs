using System;

namespace BiggestOfFive
{
    class BiggestOfFive
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            double firstThree = Math.Max(Math.Max(a, b), c);
            Console.WriteLine(Math.Max(Math.Max(firstThree,d),e));
        }
    }
}
