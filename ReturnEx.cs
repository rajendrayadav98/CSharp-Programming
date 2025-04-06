using System;
class Table
{

static void Main()
{

Console.Clear();

Console.Write(&quot;Enter an un-signed integer value: &quot;);
bool Status = uint.TryParse(Console.ReadLine(), out uint x);
if (Status == false)
{
Console.WriteLine(&quot;Please enter un-signed integer&#39;s only.&quot;);
return;
}
if (x == 0 || x == 1)
{
Console.WriteLine(&quot;Please enter a number greater than 1.&quot;);
return;
}
Console.WriteLine();
for (int i=1;i&lt;=10;i++)
{
Console.WriteLine($&quot;{x} * {i} = {x*i}&quot;);
}

} //End of the method

}