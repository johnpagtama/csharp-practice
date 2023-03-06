using System;

namespace ExamplesLibrary.Selections
{
    public class ExampleIfElse
    {
        public static void ConditionIsFalse()
        {
            int num = 2;

            if (num % 2 != 0)
            {
                Console.WriteLine("String won't be displayed");
            }
            else
            {
                Console.WriteLine("Condition was false");
            }
        }
    }
}
