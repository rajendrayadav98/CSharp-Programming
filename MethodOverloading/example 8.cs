// Create an interface "ISmartDevice" with 2 methods:

// Method name: TurnOn
// Return type: void

// Method name: TurnOff
// Return type: void

// Create an abstract class Appliance:-

// Instance variables:
// Name (string)

// Brand (string)

// PowerUsage (int)

// Constructor:

// Parameterized constructor to initialize all instance variables

// Abstract method:

// Operate() — return type void

// Virtual method:

// DisplaySpecs() — print Name, Brand, and PowerUsage

// Create a class SmartFridge that inherits from Appliance and implements ISmartDevice:-

// Additional variable:

// Temperature (double)

// Constructor: Initializes all variables including temperature

// Override methods:

// TurnOn() → print “SmartFridge is now cooling.”

// TurnOff() → print “SmartFridge is turned off.”

// Operate() → print “Maintaining temperature at X°C”

// DisplaySpecs() → include temperature info too

// Create a class SmartWashingMachine that inherits from Appliance and implements ISmartDevice

// Additional variable:

// CurrentCycle (string)

// Constructor: Initializes all variables including cycle

// Override methods:

// TurnOn() → print “Washing machine started.”

// TurnOff() → print “Washing machine is off.”

// Operate() → print “Running [CurrentCycle] cycle.”

// DisplaySpecs() → include cycle info too

// Create a class SmartHomeTest with a Main method:-

// Create objects for SmartFridge and SmartWashingMachine

// Call their respective TurnOn, Operate, TurnOff, and DisplaySpecs methods


using System;
using RajendraConsoleApp.Test;

namespace RajendraConsoleApp.Test
{
    public interface ISmartDevice
    {
        void TurnOn();
        void TurnOff();
    }
    public abstract class Appliance
    {
        public string Name;
        public string Brand;
        public int PowerUsage;
        public Appliance(string Name, string Brand, int PowerUsage)
        {
            this.Name = Name;
            this.Brand = Brand;
            this.PowerUsage = PowerUsage;
        }
        public abstract void Operator();
        public virtual void DisplaySpec()
        {
            Console.WriteLine("Appliance Info");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"PowerUsage: {Name}");
        }
    }
    class SmartFridge : Appliance, ISmartDevice
    {
        public double temperature;
        public SmartFridge(string Name, string Brand, int PowerUsage, double temperature) : base(Name, Brand, PowerUsage)
        {
            temperature = temperature;
        }

        public void TurnOn()
        {
            Console.WriteLine("SmartFridge is now cooling.");
        }

        public void TurnOff()
        {
            Console.WriteLine("SmartFridge is turned off.");
        }

        public override void Operator()
        {
            Console.WriteLine($"Maintaining temperature at {temperature}°C.");
        }

        public override void DisplaySpec()
        {
            base.DisplaySpec();
            Console.WriteLine($"Temperature Setting: {temperature}°C");
        }
    }
    class SmartWashingMachine : Appliance, ISmartDevice
    {
        public string CurrentCycle;

        public SmartWashingMachine(string name, string brand, int powerUsage, string currentCycle)
            : base(name, brand, powerUsage)
        {
            CurrentCycle = currentCycle;
        }

        public void TurnOn()
        {
            Console.WriteLine("Washing machine started.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Washing machine is off.");
        }

        public override void Operator()
        {
            Console.WriteLine($"Running {CurrentCycle} cycle.");
        }

        public override void DisplaySpec()
        {
            base.DisplaySpec();
            Console.WriteLine($"Current Cycle: {CurrentCycle}");
        }
    }
    internal class TestB
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------SmartFridge---------");
            SmartFridge f = new SmartFridge("SmartCool 4000", "CoolTech", 20, 3.0);
            f.TurnOn();
            f.Operator();
            f.DisplaySpec();
            f.TurnOff();
            Console.WriteLine("-------Smart Washing Machine--------");
            SmartWashingMachine s = new SmartWashingMachine("WashingMaster", "LG", 150, "QuickWash");
            s.TurnOn();
            s.Operator();
            s.DisplaySpec();
            s.TurnOff();
        }
    }
}

