using System;

namespace ExamplesLibrary.DataStructures
{
    public class ExampleArray
    {
        public static void Show()
        {
            int[] values = new int[5];

            Console.Write($"Array Values: ");

            for (int i = 0; i < 5; i++)
            {
                values[i] = i + 1;
            }

            foreach (var value in values)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine("");
        }
    }
}
