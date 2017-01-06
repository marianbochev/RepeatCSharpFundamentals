using System;


namespace Circle
{
    class Circle
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = (2 * Math.PI) * radius;
            double area = Math.PI * Math.Pow(radius,2);
            Console.WriteLine("{0:f2} {1:f2}",perimeter,area);
        }
    }
}
