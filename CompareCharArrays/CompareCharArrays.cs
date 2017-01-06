using System;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string str1 = Console.ReadLine();
            char[] firstArray = str.ToCharArray();
            char[] secondArray = str1.ToCharArray();
            if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("<");
            }
            else if (firstArray.Length>secondArray.Length)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}
