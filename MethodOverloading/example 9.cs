// Create a class called Shape with a method named Draw() that prints:
// "Drawing a shape"
// Create a class Circle that inherits from Shape and overrides the Draw() method to print:
// "Drawing a circle"
// Create another class named Test, create an object of Circle, and call the Draw() method.

using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Test
{
    static void Main(string[] args)
    {
        Circle c = new Circle();
        c.Draw();
    }
}
