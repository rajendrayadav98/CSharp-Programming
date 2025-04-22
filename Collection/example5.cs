using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable ht = new Hashtable();
        ht["id"] = 101;
        ht["name"] = "Ravi";

        foreach (DictionaryEntry item in ht)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
