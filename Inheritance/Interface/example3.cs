// Create an interface "IProduct" having the following methods:-

// string GetBrand()
// string GetPrice()
// string GetQuality()


// Create another interface "IOnlineShopping" having the following methods:-

// void AppName(string name)
// void AddCart()
// void Checkout()


// Create a class with name "Laptop" implement both interfaces:-

// Instance variable:
// string brand 
// double price
// string quality 

// Generate the Parameterized Constructor

// implement all the methods from interfaces
// write the logics for those methods


// Create another class with name "Book" implement both interfaces:-

// Instance variable:
// string title
// double price
// string quality 

// generate Parameterized Constructor

// implement all the methods from interfaces
// write the logics for those methods


// Create another class with name "Test" write main method in that and create object for both Laptop and Book classes

// print all the data of the products.


// Excepted Output:
// --------------------
// Laptop Details:Brand: HP
// Price: $1200
// Quality: High
// Online Shopping App Name: FlipKart
// Item added to the cart.
// Checkout completed.


// Book Details:Title: Agnipankh
// Price: $1500
// Quality: Medium
// Online Shopping App Name: Amazon
// Item added to the cart.
// Checkout completed.
// Sol:

using System;
namespace RajendraConsoleApp.Day_21
{
public interface IProduct
{
string GetBrand();
string GetPrice();
string GetQuality();
}
public interface IOnlineShoping
{
void AppName(string name);
void AddCart();
void Checkout();

}
public class Laptop:IProduct, IOnlineShoping
{
string brand;
double price;
string quality;
public Laptop(string brand, double price, string quality)
{
this.brand = brand;
this.price = price;
this.quality = quality;
}
public string GetBrand()
{
return brand;
}
public string GetPrice()
{
return price.ToString();
}
public string GetQuality()
{
return quality;
}
public void AppName(string name)
{
Console.WriteLine("Online shoping App: "+name);
}
public void AddCart()
{
Console.WriteLine("Item added to the cart");
}
public void Checkout()
{
Console.WriteLine("Cheakout completed");
}
}
public class Book : IProduct, IOnlineShoping
{
string title;
double price;
string quality;
public Book(string title, double price, string quality)
{
this.title = title;
this.price = price;
this.quality = quality;
}
public string GetBrand()
{
           
return title;
}
public string GetPrice()
{
           
return price.ToString();
}
public string GetQuality()
{
           
return quality;
}
public void AppName(string name)
{
Console.WriteLine("Online shoping App: " + name);
}
public void AddCart()
{
Console.WriteLine("Item added to the cart");
}
public void Checkout()
{
Console.WriteLine("Cheakout completed");
}
}
internal class Class4
{
static void Main(string[] args)
{
Laptop l = new Laptop("Lenevo", 20000, "good");
Console.WriteLine("Leptop Details: ");
Console.WriteLine("Brand: "+l.GetBrand());
Console.WriteLine("Price: "+l.GetPrice());
Console.WriteLine("Quality: "+l.GetQuality());
l.AppName("Amazon");
l.AddCart();
l.Checkout();
Console.WriteLine("--------------------------------------");
Book b = new Book("Godan", 200, "Good");
Console.WriteLine("Book Details:");
Console.WriteLine("Title: "+b.GetBrand());
Console.WriteLine("Price: "+b.GetPrice());
Console.WriteLine("Quality: "+b.GetQuality());
b.AppName("Flipcart");
b.AddCart();
b.Checkout();
Console.ReadLine();
}
}
}