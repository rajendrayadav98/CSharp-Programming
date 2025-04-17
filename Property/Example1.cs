// Create a class Car (Business Logic Class)
// Instance Variables:
// private string Make 
// private string Model 
// private int Year 
// genereate properties for the above variables.
// create your own method for printing the car details.
// Create a class Main (Executable Logic Class) which contains main method to print Car
// class details and pass the values through properties.

using System;

namespace RajendraConsoleApp.Day_24_Properties_
{
internal class Car
{
private string Make;
private string Model;
private int Year;
public string _Make
{ get
{ 
return Make;
}
set
{
Make = value;
}
}
public string _Model
{
get
{
return Model;
}
set
{
Model = value;
}
}
public int _Year
{
get
{
return Year;
}
set
{
_Year = value;
}
}
public void Show()
{
Console.WriteLine("Make: "+Make);
Console.WriteLine("Model: " + Model);
Console.WriteLine("Year: " + Year);
}
static void Main(string[] args)
{
Car car = new Car();
car.Make = "BMW";
car.Model = "x6";
car.Year = 2025;
car.Show();
}

}
}