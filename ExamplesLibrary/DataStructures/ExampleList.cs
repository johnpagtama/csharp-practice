using System;
using System.Collections.Generic;

namespace ExamplesLibrary.DataStructures
{
    public class ExampleList
    {
        public static void Show()
        {
            List<int> values = new List<int>();

            Console.Write($"List values: ");

            for (int i = 0; i < 5; i++)
            {
                values.Add(i + 1);
            }

            foreach (var value in values)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine("");
        }
    }
}
