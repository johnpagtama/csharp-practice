using System;
using System.Collections.Generic;

namespace ExamplesLibrary.DataStructures
{
    public class ExampleList
    {
        public static void Show()
        {
            List<int> values = new List<int>();

            int count = 0;

            Console.Write($"List values: ");

            while (count < 5)
            {
                values.Add(count + 1);

                count++;
            }

            foreach (var value in values)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine("");
        }
    }
}
