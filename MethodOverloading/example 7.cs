// Create an interface ITransportation inside write 2 methods
//  Method name:Start
// return type:void 
// Method name:Stop
// return type:void 
// Create abstract class Vehicle 
// Instance variables:
// --------------------
// Brand string
// Model string
// Year int

// create a parametarised constructor.

// create a abstract method Drive.
// create a virtual method DisplayInfo (inside this method print Brand,Model,Year).

// Create a class Car inherit Vehicle and ITransportation inside the class override all the methods
// Drive,Start,Stop
// write Printing statements related for the above methods.


// Create a class Motorcycle inherit Vehicle and ITransportation inside the class override all the methods
// Drive,Start,Stop
// write Printing statements related for the above methods.

// Create another class with name Test inside write main method and create object for Car and Motorcycle and call the Start,Drive,Stop,DisplayInfo methods respectively.


using System;

namespace RajendraConsoleApp.Test
{
public interface ITranspotation
{
void Start();
void Stop();
}
public abstract class Vehicle
{
public string Brand;
public string Model;
public int Year;
public Vehicle(string Brand,string Model,int Year)
{
this.Brand = Brand;
this.Model = Model;
this.Year = Year;
}
public abstract void Drive();
public virtual void DisplayInfo()
{
Console.WriteLine($" Brand={Brand}\n Model= {Model}\n,Year={Year}");
}
}
public class Car :Vehicle,ITranspotation
{
public Car(string Brand, string Model, int Year) : base(Brand, Model, Year)
{
}

public void Start() {

Console.WriteLine("Engine start:");
}
public void Stop() {
Console.WriteLine("Engine stop");
        
}
public override void DisplayInfo()
{
Console.WriteLine($" Brand={Brand}\n Model= {Model}\n Year={Year}");
}

public override void Drive()
{
Console.WriteLine("Vechile is in driving mode");
}
        
}
public class MotorCycle :Vehicle,ITranspotation
{
public MotorCycle(string Brand, string Model, int Year) : base(Brand, Model, Year)
{
}

public void Start() {

Console.WriteLine("Engine start:");
}
public void Stop() {
Console.WriteLine("Engine stop");
        
}
public override void DisplayInfo()
{
Console.WriteLine($" Brand={Brand}\n Model= {Model}\n Year={Year}");
}

public override void Drive()
{
Console.WriteLine("Vechile is in driving mode");
}
        
}
class Test
{
static void Main(string[] args)
{
Car c = new Car("Audi", "B6", 2025);
c.Start();
c.Drive();
c.Stop();
c.DisplayInfo();    
        
MotorCycle m = new MotorCycle("Apache","S6",2020);
m.Start();
m.Drive();
m.Stop();
m.DisplayInfo();}
}
   
}