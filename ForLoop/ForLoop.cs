using System;

namespace ForLoop
{
    class ForLoop
    {
        static void Main()
        {
            //Calculator N^M

            //int pow = int.Parse(Console.ReadLine());
            //int number = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 0; i < pow; i++)
            //{
            //    result *= number;  
            //}
            //Console.WriteLine(result);

            int n = 50;
            for (int i = 0; i < n; i++)
            {
                if (i % 5 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
