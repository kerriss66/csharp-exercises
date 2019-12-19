using System;

namespace Rectangle

{
    class MainClass
    {
        public static void Main(string[] args) 
        {
            double width;
            double height;
            double area;

            Console.WriteLine("Enter a width: ");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a height: ");
            height = double.Parse(Console.ReadLine());

            area = width * height;

            Console.WriteLine("The area of the rectangle is " + area);
        }
    }
}
