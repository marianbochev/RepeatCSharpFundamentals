using System;
using System.Collections.Generic;
namespace Lists
{
    class Lists
    {
        static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            for (int i = 0; i < list.Count; i++)
            {
                list.Add(i++);
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
