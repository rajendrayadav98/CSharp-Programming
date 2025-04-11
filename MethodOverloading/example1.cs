// Write a C# program to implement a class called AreaCalculator that uses method overloading to calculate the area of different geometric shapes:-

// Use method overloading to define three versions of the method CalculateArea():

// method:-
// return type:-int 
// method name:-CalculateArea(int side)
// A square, where the area is calculated as side * side.

// return type:-int 
// method name:-CalculateArea(int length,int width)
// A rectangle, where the area is calculated as length * width.


// return type:-Double 
// method name:-CalculateArea(double radius)
// A circle, where the area is calculated as π * radius * radius.

// Then, in the Main method:

// Create an instance of AreaCalculator.

// Call all three overloaded methods and display the results.

// Output:-
// Area of Square (side = 5): 25
// Area of Rectangle (5 * 10): 50
// Area of Circle (radius = 3): 28.2743338823081
// ====================================================================================
using System;

namespace RajendraConsoleApp.Day23
{
    public class AreaCalculator
    {
        public int CalculateArea(int side)
        {
            return side * side;
        }
        public int CalculateArea(int height,int width)
        {
            return height * width;
        }
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        public class AreaCalculator1
        {
            static void Main(string[] args)
            {
                AreaCalculator areaCalculator = new AreaCalculator();
                Console.WriteLine($"Area of Square: {areaCalculator.CalculateArea(5)}");
                Console.WriteLine($"Area of Rectange: {areaCalculator.CalculateArea(5, 10)}");
                Console.WriteLine($"Area of Circle: {areaCalculator.CalculateArea(3.0)}");

            }
        }
    }
}