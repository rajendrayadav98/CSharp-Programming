using System;
using System.Reflection;

namespace RajendraConsoleApp.Day_20
{
    public abstract class Iphone
    {
        public abstract void DisplayFeatures();
        public class Iphone15 : Iphone
        {
         public string Model, OS, Camera;
            public Iphone15()
            {
                Model = "iPhone 15";
                OS = "iOS 17";
                Camera = "48 MP Main Camera";
            }
            public override void DisplayFeatures()
            {
                Console.WriteLine($"Model name: {Model}\n OS: {OS}\n Camera: {Camera}");
            }
        }
        internal class Test
        {
            static void Main(string[] args)
            {
                Iphone15 I = new Iphone15();

                I.DisplayFeatures();
                Console.ReadLine();
            }
        }
    }
}
