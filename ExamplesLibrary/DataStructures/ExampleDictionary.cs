using System;
using System.Collections.Generic;

namespace ExamplesLibrary.DataStructures
{
    public class ExampleDictionary
    {
        public static void Show()
        {
            Dictionary<int, string> persons = new Dictionary<int, string>();

            Console.WriteLine($"Dictionary: ");

            for (int i = 0; i < 5; i++)
            {
                persons.Add(i, $"person {i}");
            }

            foreach (var person in persons)
            {
                Console.WriteLine($"Key: {person.Key} Value: {person.Value}");
            }
        }
    }
}
