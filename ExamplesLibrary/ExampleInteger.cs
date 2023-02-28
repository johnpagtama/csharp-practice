using System;
using System.Globalization;

namespace ExamplesLibrary
{
    public class ExampleInteger
    {
        public static void ShowIntegerMinimumValue()
        {
            int intMin = int.MinValue;

            Console.WriteLine($"Show integer minimum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", intMin)}");
        }

        public static void ShowIntegerMaximumValue()
        {
            int intMax = int.MaxValue;

            Console.WriteLine($"Show integer maximum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", intMax)}");
        }
    }
}
