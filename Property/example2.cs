// Create a class OnlineOrder (Business Logic Class)
// Instance Variables:
// private int productId 
// private string productName 
// private string orderStatus 
// genereate properties for the above variables.
// create your own method for printing the order details.
// Create a class Main (Executable Logic Class) which contains main method to print OnlineOrder
// class details and pass the values through properties.

using System;
namespace RajendraConsoleApp.Day_24_Properties_
{
internal class OnlineOrder
{
private int productId;
private string productName;
private string orderStatus;
public int _productId
{
get
{
return _productId;
}
set
{
_productId = value; 
}
}
public string _productName
{
get
{
return _productName;
}
set
{
_productName = value;
}
}
public string _orderStatus
{
get
{
return _orderStatus;
}
set
{
_orderStatus = value;
}
}
public void Show()
{
Console.WriteLine("ProductId: "+productId);
Console.WriteLine("Product Name: "+productName);
Console.WriteLine("Order Status: "+orderStatus);
}
static void Main(string[] args)
{
OnlineOrder n = new OnlineOrder();
n.productId = 101;
n.productName = "Laptop";
n.orderStatus = "OK";
n.Show();
Console.ReadLine();
}
}
}