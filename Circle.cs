using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class RadiousOfCircle
    {
        static void Main()
        {
            Console.WriteLine("Enter the radious :");
            int r=Convert.ToInt32(Console.ReadLine());
            double areaofcircle = 3.14 * r * r;
            double perimeter = 2 * 3.14 * r;
            Console.WriteLine("Area of circle: " + areaofcircle);
            Console.WriteLine("Perimeter: "+perimeter);
        }
    }
}
