using System;

namespace ExamplesLibrary
{
    public class ExampleShort
    {
        public static void ShowShortMinimumValue()
        {
            short shortMin = short.MinValue;

            Console.WriteLine($"Show short minimum value: {shortMin}");
        }

        public static void ShowShortMaximumValue()
        {
            short shortMax = short.MaxValue;

            Console.WriteLine($"Show short maximum value: {shortMax}");
        }
    }
}
