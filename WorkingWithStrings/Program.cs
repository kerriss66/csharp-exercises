﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //tring myString = "What if I need a\nnew line?";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\\ drive";

            //string myString = string.Format"(1) = {0}", "first", "second");

            //string myString = string.Format("{0:C}", 123.45);

            //string myString = string.Format("(0:N)", 1234567890);
            //string myString = string.Format("Percentage: {0:P}", .123);

            //string myString = string.Format("Phone Number", {0:(###) ###-####}", 123456789012);

            //string myString = "  That summer we took threes across the board ";
            //myString = myString.Substring(6, 14);//myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);

            /*
            myString = string.Format("Length before: {0} -- Length after: {1}",
                myString.Length,
                myString.Trim().Length);
            */

            /*for (int i = 0; i < 100; i++)
            {
               myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
