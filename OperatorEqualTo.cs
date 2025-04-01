using System;

namespace RajendraConsoleApp.OperatorOverloading
{
    internal class MatrixE
    {
        int a, b, c, d;

        public MatrixE(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override string ToString()
        {
            return $"{a} {b}\n{c} {d}";
        }

        // Overloading == operator to compare two matrices
        public static bool operator ==(MatrixE obj1, MatrixE obj2)
        {
            // Handle nulls and reference equality
            if (ReferenceEquals(obj1, obj2)) return true;
            if (obj1 is null || obj2 is null) return false;

            // Compare the matrix elements
            return obj1.a == obj2.a && obj1.b == obj2.b && obj1.c == obj2.c && obj1.d == obj2.d;
        }

        // Overloading != operator to compare two matrices
        public static bool operator !=(MatrixE obj1, MatrixE obj2)
        {
            return !(obj1 == obj2); // Using the overloaded == operator
        }

        // Override Equals and GetHashCode for correct behavior of == and !=
        public override bool Equals(object obj)
        {
            if (obj is MatrixE matrix)
            {
                return this == matrix; // Use the overloaded == operator
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(a, b, c, d); // Return a unique hash code based on matrix elements
        }

        static void Main(string[] args)
        {
            // Create two matrices
            MatrixE matrix1 = new MatrixE(20, 10, 30, 40);
            MatrixE matrix2 = new MatrixE(10, 10, 30, 60);

            // Compare matrices using overloaded == operator
            if (matrix1 == matrix2)
            {
                Console.WriteLine("Matrices are equal.");
            }
            else
            {
                Console.WriteLine("Matrices are not equal.");
            }

            // Print matrix values
            Console.WriteLine("Matrix 1:");
            Console.WriteLine(matrix1);
            Console.WriteLine("Matrix 2:");
            Console.WriteLine(matrix2);

            Console.ReadLine();
        }
    }
}
