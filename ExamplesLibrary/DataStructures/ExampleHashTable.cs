using System;
using System.Collections;

namespace ExamplesLibrary.DataStructures
{
    public class ExampleHashTable
    {
        public static void Show()
        {
            Hashtable persons = new Hashtable();

            Console.WriteLine("Hashtable: ");

            for (int i = 0; i < 5; i++)
            {
                persons.Add(i, $"person {i}");
            }

            foreach (DictionaryEntry person in persons)
            {
                Console.WriteLine($"{person.Key}: {person.Value}");
            }
        }
    }
}
