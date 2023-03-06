using System;

namespace ExamplesLibrary.DataStructures
{
    public class ExampleArray
    {
        public static void Show()
        {
            int[] values = new int[5] { 1, 2, 3, 4, 5 };

            Console.Write($"Values: ");

            foreach (var value in values)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
