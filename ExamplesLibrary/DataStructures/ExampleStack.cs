using System;
using System.Collections.Generic;

namespace ExamplesLibrary.DataStructures
{
    public class ExampleStack
    {
        public static void Show()
        {
            Stack<int> cards = new Stack<int>();

            Console.WriteLine("Stack: ");

            for (int i = 0; i < 5; i++)
            {
                cards.Push(i);
            }

            foreach (var card in cards)
            {
                Console.WriteLine($"{card} ");
            }
        }
    }
}
