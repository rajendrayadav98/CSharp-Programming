using System;

namespace test1
{
    internal class Test2
    {
        int id, price;
        string name;

    
        public Test2(int id, int price, string name)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        
        public void ProductDetails()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            
            Test2 t = new Test2(101, 2000, "Raj");
            t.ProductDetails();  
        }
    }
}
