using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.CSharp11
{
    internal class SampleExp1
    {
        public static int a;
        public static int b;
         static SampleExp1()
        {
            a = 100;

            b = 2000;
        }
        static void Main(string[] args)
        {
            SampleExp1 obj=new SampleExp1 ();
            Console.WriteLine(SampleExp1.a);
            Console.WriteLine(SampleExp1.b);
        }
    }
}
