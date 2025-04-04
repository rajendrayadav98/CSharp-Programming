using System;
using System.Runtime.Serialization;

namespace RajendraConsoleApp.CSharp11
{
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes more noise.");
        }
    }
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dogs barks.");
        }
    }
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Sound();
            Dog d = new Dog();
            d.Sound();
            
            
        }
    }
}