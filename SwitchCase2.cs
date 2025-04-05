using System;
class SwitchDemo
{
static void Main()
{
Console.Write(&quot;Enter Student Id. (1-3): &quot;);
int Id = int.Parse(Console.ReadLine());
switch(Id)
{
case 1:
Console.WriteLine(&quot;Student 1&quot;);
break;
case 2:
Console.WriteLine(&quot;Student 2&quot;);
break;
case 3:
Console.WriteLine(&quot;Student 3&quot;);
break;
default:
Console.WriteLine(&quot;No student exists with the given Id.&quot;);
break;
}
}
}