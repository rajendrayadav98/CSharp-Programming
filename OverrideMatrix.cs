using System;

namespace MatrixPolymorphismExample
{
    // Matrix class
    public class Matrix
    {
        int a, b, c, d;

        // Constructor to initialize matrix values
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        // Overriding ToString method to print matrix in 2x2 format
        public override string ToString()
        {
            return $"{a} {b}\n{c} {d}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Matrix class
            Matrix matrix = new Matrix(1, 2, 3, 4);

            // Passing the matrix instance to Console.WriteLine, which internally calls ToString()
            Console.WriteLine(matrix);

            Console.ReadLine();
        }
    }
}
