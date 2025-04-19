// Create a delegate with name AreaCalculator return type void with 2 parameters double p1 and double p2.

// Create a class with name Area in this 


// Write 3 methods
// Method 1:
// ----------
// method name: CalculateSquareArea
// return type: void
// Parameters: 2(double sideLength,double _)
// Access modifier:public
// Write logic to calculate the area


// method name: CalculateRectangleArea
// return type: void
// Parameters: 2(double length, double width)
// Access modifier:public
// Write logic to calculate the area


// method name: CalculateCircleArea
// return type: void
// Parameters: 2(double radius, double _)
// Access modifier:public
// Write logic to calculate the area




// Create another class test
// create object for Area class and also create object for delegate 
// pass the methods for delegate and print the area of those

using System;
{
    public delegate void AreaCalculator(double p1, double p2);
    public class Area
    {
        public void CalculateSquareArea(double sideLength, double _)
        {
             double Area = sideLength * sideLength;
            Console.WriteLine("Area of square: " + Area);
        }
        public void CalculateRectangeArea(double lenght,double width)
        {
            double Area = lenght * width;
            Console.WriteLine("Area of Rectangle: "+Area);
        }
        public void CalculateCircleArea(double radius, double _)
        {
            double Area = Math.PI*(radius * radius);
            Console.WriteLine("Area of Circle: "+Area);
        }
    }
    internal class Test
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            AreaCalculator a = area.CalculateSquareArea;
            a(10, 0);
            AreaCalculator b = area.CalculateRectangeArea;
            b(3, 5);
            AreaCalculator c = area.CalculateCircleArea;
            c(10, 0);
            Console.ReadLine();
        }
    }
}