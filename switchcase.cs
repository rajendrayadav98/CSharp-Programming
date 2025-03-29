using System;
class SwitchDemo 
{
  static void Main() 
  {
    Console.Write("Enter Student Id. (1-3): ");
    int Id = int.Parse(Console.ReadLine());
    switch(Id)
    {
      case 1:
        Console.WriteLine("Student 1");
        break;
      case 2:
        Console.WriteLine("Student 2");
        break;
      case 3:
        Console.WriteLine("Student 3");
        break;
      default:
        Console.WriteLine("No student exists with the given Id.");
        break;
    }
  }
}
