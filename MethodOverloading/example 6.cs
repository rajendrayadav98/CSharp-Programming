using System;

class Point
{
    public int X, Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Overload the + operator
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }

    static void Main()
    {
        Point p1 = new Point(2, 3);
        Point p2 = new Point(4, 5);
        Point result = p1 + p2;

        p1.Display();
        p2.Display();
        result.Display();
    }
}
