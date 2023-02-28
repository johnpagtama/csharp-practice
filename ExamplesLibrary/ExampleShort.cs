using System;
using System.Globalization;

namespace ExamplesLibrary
{
    public class ExampleShort
    {
        public static void ShowMinimumValue()
        {
            short shortMin = short.MinValue;

            Console.WriteLine($"Show short minimum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", shortMin)}");
        }

        public static void ShowMaximumValue()
        {
            short shortMax = short.MaxValue;

            Console.WriteLine($"Show short maximum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", shortMax)}");
        }
    }
}
