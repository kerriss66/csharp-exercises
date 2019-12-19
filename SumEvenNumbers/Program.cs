using System;
using System.Collections.Generic;

namespace SumEvenNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Initialize our nums list with 10 int values
            List<int> nums = new List<int>() { 1, 5, 8, 11, 12, 4, 13, 41 };

            // Call SumEvenNumbers method, passing in nums list
            // Accept return value from SumEvenNumbers in to sum variable
            int sum = SumEvenNumbers(nums);
            Console.WriteLine("Sum " + sum);
        }

        // Declare our SumEvenNumbers method, with a list parameter
        // SumEvenNumbers will return a value of type int
        public static int SumEvenNumbers(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    sum += list[i];
                }
            }
            return sum;
        }
    }
}