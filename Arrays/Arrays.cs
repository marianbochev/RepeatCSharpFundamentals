using System;


namespace Arrays
{
    class Arrays
    {
        static void Main()
        {
            int[] arrayOfNumbers = { 1, 2, 3, 2, 1 };
            int lastIndex = arrayOfNumbers.Length - 1;
            bool simetric = true;
            for (int i = 0; i <= lastIndex; i++)
            {
                if (arrayOfNumbers[i] != arrayOfNumbers[lastIndex - i])
                {
                    simetric = false;
                    break;
                }
            }
            if (simetric)
            {
                Console.WriteLine("Array is simetric");
            }
            else
            {
                Console.WriteLine("Array is NOT simetric");
            }
        }
    }
}
