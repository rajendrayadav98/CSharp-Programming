using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict["name"] = "Amit";
        dict["city"] = "Delhi";

        foreach (var kv in dict)
        {
            Console.WriteLine(kv.Key + ": " + kv.Value);
        }
    }
}
