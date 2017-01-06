using System;

namespace CSharpFundamentalsExam
{
    class Startup
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;
            int secondDigit = (number / 10) % 10;
            int firstdigit = (number / 100) % 10;
            if (lastDigit == 0)
            {
                Console.WriteLine("{0:f2}",firstdigit*secondDigit);
            }
            else if(lastDigit>0 && lastDigit <= 5)
            {
                Console.WriteLine("{0:f2}",firstdigit*secondDigit/(double)lastDigit);
            }
            else
            {
                Console.WriteLine("{0:f2}",(firstdigit+secondDigit)*lastDigit);
            }
        }
    }
}
