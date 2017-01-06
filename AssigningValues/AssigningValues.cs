using System;

namespace AssigningValues
{
    class AssigningValues
    {
        static void Main()
        {
            long myLong = 32132132l;
            long anotherLong = new long();
            Console.WriteLine(myLong);
            Console.WriteLine(anotherLong);

            uint someUint = 12321321u;
            string multilineString = @"C:\Windows\system32";
            Console.WriteLine(multilineString);
        }
    }
}
