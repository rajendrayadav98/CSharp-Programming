using System;
namespace RajendraConsoleApp.Day_20
{
public abstract class Employee
{
public string name;
public string companyname;
public double salary;
public Employee(string name, string companyname, double salary)
{
this.name = name;
this.companyname = companyname;
this.salary = salary;
}
public abstract string Details();
public abstract double CalculateBonus();
}
public class Manager : Employee
{
public Manager(string name,string companyname,double salary):base(name,companyname,salary) 

}
public override string Details()
{
return $"Name: {name}\n Company Name: {companyname}\n Salary: {salary}";
}
public override double CalculateBonus()
{
double Bonus = 0.1 * salary;
return Bonus+salary;
}

}
public class Developer : Employee
{
public int workexperience;
public Developer(string name,string companyname,double salary,int workexperience):base(name,companyname,salary) 
{
this.name =name;
this.companyname= companyname;
this.salary=salary;
this.workexperience = workexperience;
}
public override string Details()
{
return ($"Name: {name}\n Company name: {companyname}\n Salary: {salary}\n Work Experience: {workexperience}");
}
public override double CalculateBonus()
{
return workexperience > 5 ? salary*0.15:salary*0.1;
}
}
internal class Program
{
static void Main(string[] args)
{
Manager m = new Manager("Raj", "NIT", 20000);
Console.WriteLine(m.Details());
Console.WriteLine($"Bonus:{m.CalculateBonus()}");
Console.WriteLine();
Developer d = new Developer("Raj", "NIT", 21000, 6);
Console.WriteLine(d.Details());
Console.WriteLine($"Bonus: {d.CalculateBonus()}");
Console.ReadLine();
}
}
}