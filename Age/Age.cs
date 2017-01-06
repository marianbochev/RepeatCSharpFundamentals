using System;

namespace Age
{
    class Age
    {
        static void Main()
        {
            string inputDate = Console.ReadLine();
            DateTime bornDate = Convert.ToDateTime(inputDate);
            DateTime currentDate = DateTime.Now;

            int currentYear = currentDate.Year - bornDate.Year;
            int currentMonth = currentDate.Month - bornDate.Month;
            int currentDay = currentDate.Day - bornDate.Day;

            int currentAge = 0;

            if (currentYear >= 0 && currentMonth >= 0 && currentDay >= 0)
            {
                Console.WriteLine(currentAge = currentYear);
                Console.WriteLine(currentAge + 10);
            }
            else
            {
                Console.WriteLine(currentAge = currentYear - 1);
                Console.WriteLine(currentAge + 10);
            }

        }
    }
}
