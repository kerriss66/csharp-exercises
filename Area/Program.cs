using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");

            string input = Console.ReadLine();
            
            float radius = float.Parse(input);
           
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("The area of the circle is " + area);

        }
    }
}
