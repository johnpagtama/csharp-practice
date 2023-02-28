using System;
using System.Globalization;

namespace ExamplesLibrary
{
    public class ExampleULong
    {
        public static void ShowUnsignedLongMinimumValue()
        {
            ulong uLongMin = ulong.MinValue;

            Console.WriteLine($"Show ulong minimum value: {uLongMin}");
        }

        public static void ShowUnsignedLongMaximumValue()
        {
            ulong uLongMax = ulong.MaxValue;

            Console.WriteLine($"Show ulong maximum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", uLongMax)}");
        }
    }
}
