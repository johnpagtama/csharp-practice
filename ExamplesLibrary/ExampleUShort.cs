using System;
using System.Globalization;

namespace ExamplesLibrary
{
    public class ExampleUShort
    {
        public static void ShowUShortMinimumValue()
        {
            ushort uShortMin = ushort.MinValue;

            Console.WriteLine($"Show ushort minimum value: {uShortMin}");
        }

        public static void ShowUShortMaximumValue()
        {
            ushort uShortMax = ushort.MaxValue;

            Console.WriteLine($"Show ushort maximum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", uShortMax)}");
        }
    }
}
