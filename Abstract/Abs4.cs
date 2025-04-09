// Create an abstract class "ElectronicDevice" with Following Members:

// Instance Variables:-
// string Model

// double Price

// generate a Parameterised Constructor

// Abstract method:

// void DisplaySpecs()

// Create an interface "IWarranty" with:-
// void ShowWarrantyInfo();

// Create a class "Smartphone" that:
// Inherits from ElectronicDevice and IWarranty

// Instance Variable:- string OperatingSystem

// generate Parameterised Constructor

// Overrides and implements all required methods.

// In a Main() method:
// Create objects of  "Smartphone" 
// Call DisplaySpecs() and ShowWarrantyInfo() 

// Output:-

// Smartphone Details:
// Model: Galaxy S23
// Price: 999.99
// OS: Android
// Warranty: 1 year manufacturer warranty

// Sol:
using System;
namespace RajendraConsoleApp.Day22
{
public abstract class ElectronicDevice
{
public string model;
public double price;
public ElectronicDevice(string model, double price)
{
this.model = model;
this.price = price;
}
public abstract void DisplaySpec();
}
public interface Iwaranty1
{
void ShowWarrantyInfo();      
}
internal class SmartPhone : ElectronicDevice, Iwaranty1
{
string OperatingSystem;
public SmartPhone(string operatingSystem, string model, double price):base(model, price) 
{
OperatingSystem = operatingSystem;
}
public override void DisplaySpec()
{
Console.WriteLine($"Model: {model}\n Price: {price}");
}
public void ShowWarrantyInfo()
{
Console.WriteLine("Warrant: 1 year manufacture warranty.");
}
static void Main(string[] args)
{
SmartPhone s = new SmartPhone("Android","Galaxy S23",999.9);
Console.WriteLine("SmartPhone Details:");
s.DisplaySpec();
s.ShowWarrantyInfo();
Console.ReadLine();
}
}
}