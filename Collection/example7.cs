using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
