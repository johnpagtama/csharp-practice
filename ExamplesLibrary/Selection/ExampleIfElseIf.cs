using System;

namespace ExamplesLibrary.Selection
{
    public class ExampleIfElseIf
    {
        public static void OtherConditionIsTrue()
        {
            int num = 2;

            if (num % 3 == 0)
            {
                Console.WriteLine("String won't be displayed");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("First condition is false but second condition is true");
            }
            else
            {
                Console.WriteLine("String won't be displayed");
            }
        }
    }
}
