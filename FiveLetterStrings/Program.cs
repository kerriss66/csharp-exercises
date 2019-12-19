using System;
using System.Collections.Generic;

namespace FiveLetterStrings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> strings = new List<string>() { "no", "hello", "coffee", "green", "yes" };

            ShowFiveLetterStrings(strings);
        }


        public static void ShowFiveLetterStrings(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length == 5)
                {
                    Console.WriteLine(list[i]);
                }
            }

        }
    }
}