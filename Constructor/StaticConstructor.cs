using System;
 class Sample
 {
 int a;
 static int b;
 public Sample()
 {
 a =100;
 }
 static Sample()
 {
 b =100;
 }
 public void Display()
 {
 Console.Write(a + "\t");
 a++;
 Console.WriteLine(b);
 b++;
 }
class Program
{
Console.WriteLine(" a\t b\n------------");
Sample S1 = new Sample();
 S1.Display();
 Sample S2 = new Sample();
 S2.Display();
 Sample S3 = new Sample();
 S3.Display();
 Console.ReadLine();
}