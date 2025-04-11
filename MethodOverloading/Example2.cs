using System;

namespace RajendraConsoleApp.Day23
{
    public class VolumeCalculator1
    {
        public int CalculateVolume(int side)
        {
            return side * side * side;
        }

        public int CalculateVolume(int length, int width, int height)
        {
            return length * width * height;
        }

        public double CalculateVolume(double radius, double height)
        {
            return Math.PI * radius * radius * height;
        }
    }

    internal class VolumeCalculator
    {
        static void Main(string[] args)
        {
            VolumeCalculator1 obj = new VolumeCalculator1();

            Console.WriteLine($"Volume of Cube (side = 3): {obj.CalculateVolume(3)}");
            Console.WriteLine($"Volume of Cuboid (3 * 4 * 5): {obj.CalculateVolume(3, 4, 5)}");
            Console.WriteLine($"Volume of Cylinder (radius = 2.5, height = 10): {obj.CalculateVolume(2.5, 10)}");

            Console.ReadLine();
        }
    }
}
