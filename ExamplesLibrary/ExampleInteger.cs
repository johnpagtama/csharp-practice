using System;
using System.Globalization;

namespace ExamplesLibrary.Types
{
    public class ExampleInteger
    {
        public static void ShowMinimumValue()
        {
            int intMin = int.MinValue;

            Console.WriteLine($"Show integer minimum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", intMin)}");
        }

        public static void ShowMaximumValue()
        {
            int intMax = int.MaxValue;

            Console.WriteLine($"Show integer maximum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", intMax)}");
        }
    }
}
