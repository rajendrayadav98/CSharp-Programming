using System;
class IfDemo
{
static void Main()
{
Console.Write(&quot;Enter 1st number: &quot;);
double d1 = double.Parse(Console.ReadLine());
Console.Write(&quot;Enter 2nd number: &quot;);
double d2 = double.Parse(Console.ReadLine());
if(d1 &gt; d2)
Console.WriteLine(&quot;1st number is greater than 2nd number.&quot;);
else if(d1 &lt; d2)
Console.WriteLine(&quot;2nd number is greater than 1st number.&quot;);
else
Console.WriteLine(&quot;Both the given numbers are equal.&quot;);
}
}