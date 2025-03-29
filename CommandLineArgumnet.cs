using System;
class AddParams 
{
  static void Main(string[] args) 
  {
    double Sum = 0;
    foreach(string str in args) 
    {	
      Sum = Sum + double.Parse(str);
    }
    Console.WriteLine("Sum of given {0} no's is: {1}", args.Length, Sum);
				Or
    Console.WriteLine($"Sum of given {args.Length} no's is: {Sum}");
  }
}
