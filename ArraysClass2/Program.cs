using System;

namespace ArraysClass2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // int[]
            // string[]
            // bool[]
            // double[]
            // int[] other = new int[6];

            int[] nums = { 1, 1, 2, 3, 5, 8 };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}