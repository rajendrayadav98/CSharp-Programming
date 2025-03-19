using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
         int r, sum = 0;
            Console.WriteLine("Enter any number");
            int n=Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                r = n % 10;
                sum = (sum * 10 )+ r;
                n = n / 10;
            }
            Console.WriteLine("Reverse number: "+sum);
    }
}
