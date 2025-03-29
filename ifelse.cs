using System;
class IfDemo
{
  static void Main()
  {
    Console.Write("Enter 1st number: ");
    double d1 = double.Parse(Console.ReadLine());
    Console.Write("Enter 2nd number: ");
    double d2 = double.Parse(Console.ReadLine());

    if(d1 > d2)
      Console.WriteLine("1st number is greater than 2nd number.");
    else if(d1 < d2)
      Console.WriteLine("2nd number is greater than 1st number.");
    else
      Console.WriteLine("Both the given numbers are equal.");
  }
}
