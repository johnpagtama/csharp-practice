using System;
using System.Globalization;

namespace ExamplesLibrary.Types
{
    public class ExampleUShort
    {
        public static void ShowMinimumValue()
        {
            ushort uShortMin = ushort.MinValue;

            Console.WriteLine($"Show ushort minimum value: {uShortMin}");
        }

        public static void ShowMaximumValue()
        {
            ushort uShortMax = ushort.MaxValue;

            Console.WriteLine($"Show ushort maximum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", uShortMax)}");
        }
    }
}
