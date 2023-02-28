using System;
using System.Globalization;

namespace ExamplesLibrary
{
    public class ExampleLong
    {
        public static void ShowLongMinimumValue()
        {
            long longMin = long.MinValue;

            Console.WriteLine($"Show long minimum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", longMin)}");
        }

        public static void ShowLongMaximumValue()
        {
            long longMax = long.MaxValue;

            Console.WriteLine($"Show long maximum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", longMax)}");
        }
    }
}
