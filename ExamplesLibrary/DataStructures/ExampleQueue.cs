using System;
using System.Collections.Generic;

namespace ExamplesLibrary.DataStructures
{
    public class ExampleQueue
    {
        public static void Show()
        {
            Queue<int> tickets = new Queue<int>();

            Console.WriteLine("Queue: ");

            for (int i = 0; i < 5; i++)
            {
                tickets.Enqueue(i);
            }

            foreach (var ticket in tickets)
            {
                Console.WriteLine($"{ticket}");
            }
        }
    }
}
