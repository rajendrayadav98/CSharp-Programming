using System;

namespace RajendraConsoleApp.OperatorOverloading
{
    internal class MatrixS
    {
        int a,b,c,d;
        public MatrixS(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override string ToString()
        {
            return a+" "+b+" \n"+ c+" "+d+"\n";
        }
        public static MatrixS operator -(MatrixS obj1, MatrixS obj2)
        {
            MatrixS obj = new MatrixS(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }
        static void Main(string[] args)
        {
            MatrixS matrix1 = new MatrixS(50,40,30,20);
            MatrixS matrix2 = new MatrixS(30, 30, 20, 10);
            MatrixS matrix3;
            matrix3 = matrix1 - matrix2;
            Console.WriteLine(matrix3);
            Console.ReadLine();
        }
        
    }
}
