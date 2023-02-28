using System;

namespace ExamplesLibrary
{
    public class ExampleFloat
    {
        public static void ShowMinimumValue()
        {
            float floatMin = float.MinValue;

            Console.WriteLine($"Show float minimum value: {floatMin}");
        }

        public static void ShowMaximumValue()
        {
            float floatMax = float.MaxValue;

            Console.WriteLine($"Show float maximum value: {floatMax}");
        }
    }
}
