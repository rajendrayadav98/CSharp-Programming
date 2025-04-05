using System;
class AddNums
{
static void Main()
{
Console.Clear();
Console.Write(&quot;Enter 1st number: &quot;);
string s1 = Console.ReadLine();
double d1 = Convert.ToDouble(s1);
Console.Write(&quot;Enter 2nd number: &quot;);
string s2 = Console.ReadLine();
double d2 = double.Parse(s2);
double d3 = d1 + d2;
Console.WriteLine(&quot;Sum of &quot; + d1 + &quot; &amp; &quot; + d2 + &quot; is: &quot; + d3);
Console.WriteLine(&quot;Sum of {0} &amp; {1} is: {2}&quot;, d1, d2, d3);
Console.WriteLine($&quot;Sum of {d1} &amp; {d2} is: {d3}&quot;);
}
}