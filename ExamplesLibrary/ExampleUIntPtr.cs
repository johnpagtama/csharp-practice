using System;
using System.Globalization;

namespace ExamplesLibrary
{
    public class ExampleUIntPtr
    {
        public static void ShowMinimumValue()
        {
            nuint nuintMin = nuint.MinValue;

            Console.WriteLine($"Show nuint minimum value: {nuintMin}");
        }

        public static void ShowMaximumValue()
        {
            nuint nuintMax = nuint.MaxValue;

            Console.WriteLine($"Show nuint maximum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", nuintMax)}");
        }
    }
}
