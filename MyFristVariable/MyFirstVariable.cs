using System;

namespace MyFristVariable
{
    class MyFirstVariable
    {
        static void Main()
        {
            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;
            int age = 15;
            Console.WriteLine(today);
            Console.WriteLine(now);
            Console.WriteLine(age);
            decimal maxValue = decimal.MaxValue;
            long maxValue1 = long.MaxValue;
            Console.WriteLine(maxValue);
            Console.WriteLine(maxValue1);
            float vlaue = 10.5f;
            Console.WriteLine(vlaue);
            double doublePI = Math.PI;
            Console.WriteLine(doublePI);
            float floatPI = (float)Math.PI;
            Console.WriteLine(floatPI);
        }
    }
}
