namespace OOPSProject
{
class Emp
{
public int? Id;
public string? Name, Job;
public double? Salary;
public bool? Status;
}
class UserDefinedTypes
{
public Emp GetEmpDetails(int Id)
{
Emp emp = new Emp();
emp.Id = Id;
emp.Name = &quot;Raju&quot;;
emp.Job = &quot;Manager&quot;;
emp.Salary = 50000.00;
emp.Status = true;
return emp;
}
static void Main()
{
UserDefinedTypes udt = new UserDefinedTypes();
Emp obj = udt.GetEmpDetails(1001);
Console.WriteLine(obj.Id + &quot; &quot; + obj.Name + &quot; &quot; + obj.Job + &quot; &quot; + obj.Salary + &quot; &quot; + obj.Status);
Console.ReadLine();
}
}
}