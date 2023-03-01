using System;

namespace ExamplesLibrary.Types
{
    public class ExampleDouble
    {
        public static void ShowMinimumValue()
        {
            double doubleMin = double.MinValue;

            Console.WriteLine($"Show double minimum value: {doubleMin}");
        }

        public static void ShowMaximumValue()
        {
            double doubleMax = double.MaxValue;

            Console.WriteLine($"Show double maximum value: {doubleMax}");
        }
    }
}
