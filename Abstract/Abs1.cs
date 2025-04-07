using System;
using System.Net.NetworkInformation;

namespace RajendraConsoleApp.Day_20
{
  
    internal abstract class Shape
    {
        public abstract double CalArea();
        
    }
    class Circle : Shape
    {
        public double Radius;
        const float pi = 3.14f;
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double CalArea()
        {
            return pi * (Radius * Radius);
        }
    }
    class Rectangle : Shape
    {
        public double width,height;
        public Rectangle(double width,double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double CalArea()
        {
            return width * height;
        }
    }
    internal class Vbn
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Console.WriteLine("Area of circle: "+c.CalArea());
            Rectangle r = new Rectangle(3,5);
            Console.WriteLine("Area of Rectange: "+r.CalArea());
            Console.ReadLine();
        }
    }
}
