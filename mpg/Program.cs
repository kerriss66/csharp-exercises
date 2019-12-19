using System;

namespace mpg

{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double miles;
            double gallons;
            double mpg;

            Console.WriteLine("Enter miles driven: ");
            miles = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter gallons used: ");
            gallons = double.Parse(Console.ReadLine());

            mpg = miles/gallons;

            Console.WriteLine("Your miles per gallon is " + mpg);
        }
    }
}
