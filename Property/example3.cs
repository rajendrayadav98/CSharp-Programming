// Create a class Restaurant(Business Logic Class)
// Instance Variables:
// private int tableNumber 
// private string itemName 
// private double itemPrice 
// genereate properties for the above variables.
// create your own method for printing the Restaurant details.
// Create a class Main (Executable Logic Class) which contains main method to print Restaurant
// class details and pass the values through properties.
// Sol:

using System;

namespace RajendraConsoleApp.Day_24_Properties_
{
    internal class Restaurant
    {
        private int tableNumber;
        private string itemName;
        private double itemPrice;
        public int _tableNumber
        {
            get
            {
                return tableNumber;
            }
            set
            {
                tableNumber = value;
            }
            }
        public string _ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
            }
            }
        public double _ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set
            {
                itemPrice = value;
            }
            }
        public void Show()
        {
            Console.WriteLine("Table Number: "+tableNumber);
            Console.WriteLine("Item Name: "+itemName);
            Console.WriteLine("Item Price: "+itemPrice);
        }
        static void Main()
        {
            Restaurant r = new Restaurant();
            r.tableNumber = 101;
            r.itemName = "Masala Dosa";
            r.itemPrice = 34.52;
            r.Show();
            Console.ReadLine();
        }

} 
}