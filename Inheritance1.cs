using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.Inheritance
{
    internal class Vehicle
    {
        public int speed;
        public string fuel;

        public Vehicle(int speed, string fuel)
        {
            this.speed = speed;
            this.fuel = fuel;
        }
    }
     class Car:Vehicle
    {
        public string carType;
        public Car(int speed,string fuel,string carType):base(speed,fuel)
        {
            this.carType = carType;
        }
        public void ShowCarDetails()
        {
            Console.WriteLine("Car Type: "+carType);
            Console.WriteLine("fuel: "+fuel);
            Console.WriteLine("Speed: "+speed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(60,"Grand Vitara","Petrol");
            c.ShowCarDetails();
            Console.ReadLine();
        }
    }
    
}
