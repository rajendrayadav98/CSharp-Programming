using System;

namespace RajendraConsoleApp.OperatorOverloading
{
    internal class MatrixP
    {
        int a, b, c, d;
        
        public MatrixP(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override string ToString()
        {
            return a+ " "+b+" \n"+c+" "+d+"\n";
        }
        public static MatrixP operator + (MatrixP obj1, MatrixP obj2)
        {
            MatrixP obj =new MatrixP(obj1.a+obj2.a,obj1.b+obj2.b,obj1.c+obj2.c,obj1.d+obj2.d);
            return obj;
        }
        static void Main()
        {
            MatrixP matrix1 = new MatrixP(10, 20, 30, 40);
            MatrixP matrix2= new MatrixP(10, 20, 30, 40);
            MatrixP matrix3 = new MatrixP(15, 20, 25, 30);
            MatrixP matrix4 = new MatrixP(50, 60, 10, 35);
            MatrixP matrix5;
            matrix5=matrix1 + matrix2;
            MatrixP matrix6;
            matrix6 = matrix3 + matrix4;
            Console.WriteLine(matrix5);
            Console.WriteLine(matrix6);
            Console.ReadLine();

        }
    }
}
