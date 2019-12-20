using System;
using System.Collections.Generic;


namespace Shapes
{
   public abstract class Shape
    {
        public const double ANGLE = 360.0;

        public string Name { get; set; }
        public int NumSides { get; set; }

        public Shape(string name, int sides)
        {
            Name = name;
            NumSides = sides;
        }

        public abstract double Area();
        public abstract double Perimeter();
        public abstract void Draw();
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(string name, double l, double w) : base(name, 4)
        {
            Length = l;
            Width = w;
        }

        public override double Area()
        {
            return Length * Width;
        }
        public override double Perimeter()
        {
            return 2 * Length + 2 * Width;
        }
        public override void Draw()
        {
            string str = "";

            str += "--------" + "\n |        |" +
            "\n---------";

            Console.WriteLine(str);
        }

        public double GetVertexAngle()
        {
            return ANGLE / NumSides;
        }
    }

    public class Square : Rectangle
    {
        public Square(string name, double sideLength) : base(name, sideLength, sideLength)
        { }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        private const double PI = Math.PI;

        public Circle(string name, double radius) : base(name, 0)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * PI * Radius;
        }

        public override void Draw()
        {
            Console.WriteLine("o");
        }

        public double Diameter()
        {
            return 2 * Radius;
        }

        public double Circumference()
        {
            return Perimeter();
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Shape circ = new Circle("Healing", 7);
            Shape rec = new Rectangle("Suzie", 10, 3);
            Shape sq = new Square("Debra", 6);

            List<Shape> shapes = new List<Shape>() { circ, rec, sq };

            foreach (Shape sh in shapes)
            {
                Console.WriteLine("Name: " + sh.Name);
                Console.WriteLine("Area: " + sh.Area());
                Console.WriteLine("Perimeter: " + sh.Perimeter());
                Console.WriteLine("Area: " + sh.Area());
                Console.WriteLine("Type: " + sh.GetType());
            }
            
        }
    }
}

 //           Rectangle r = new Rectangle("Suzie", 10, 3);
   //         Square sq = new Square("Debra", 6);
     //       Circle circ = new Circle("Healing", 7);

       //     Console.WriteLine("Area: " + r.Area());
         //   Console.WriteLine("Name: " + r.Name);
           // Console.WriteLine("Angle: " + r.GetVertexAngle());

//            Console.WriteLine("Area: " + sq.Area());
  //          Console.WriteLine("Name: " + sq.Name);
    //        Console.WriteLine("Angle: " + sq.GetVertexAngle());
      //      Console.WriteLine("Perimeter: " + sq.Perimeter());

        //    Console.WriteLine("Name: " + circ.Name);
          //  Console.WriteLine("Circumference: " + circ.Circumference());
            //Console.WriteLine("Area: " + circ.Area());
//            Console.WriteLine("Diameter: " + circ.Diameter());

  //      }
//    }

