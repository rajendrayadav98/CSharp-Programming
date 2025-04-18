// Create a class Circle
// Instance Variables:
// private double _radius;

// Create a Parameterised Constructor to initialize the _radius value
// Create a Read only Property for Area to Calculate area of a Circle and to return that value

// Create a class Main (Executable Logic Class) which contains main method to print Area
// class details and pass the values through Constructor.

using System;

namespace RajendraConsoleApp.Day_24_Properties_
{
    internal class Circle
    {
        private double _radius;
        public Circle(double radius)
        {
            this._radius = radius;
        }
        public double Area
        {
            get {  return Math.PI * _radius*_radius; }
        }
        static void Main(string[] args)
        {
            Circle c = new Circle(10);
            
            Console.WriteLine("Area of circle = "+c.Area);
            Console.ReadLine();
        }
    }
}