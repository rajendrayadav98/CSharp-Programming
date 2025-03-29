using System;
class TDArray 
{
  static void Main() 
  {
    int x = 0; int[,] arr = new int[4, 5];

    //Accessing values of TD Array by using foreach loop
    foreach(int i in arr)
      Console.Write(i + " ");
    Console.WriteLine();

    //Assigning values to TD Array by using nested for loop
    for(int i=0;i<arr.GetLength(0);i++) 
    {
      for(int j=0;j<arr.GetLength(1);j++) {
        x += 5; arr[i,j] = x;
      }
    }

    //Accessing values of TD Array by using nested for loop
    for(int i=0;i<arr.GetLength(0);i++) 
    {
      for(int j=0;j<arr.GetLength(1);j++)
        Console.Write(arr[i,j] + " ");
      Console.WriteLine();
    }
  }
}
