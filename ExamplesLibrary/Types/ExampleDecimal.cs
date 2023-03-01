using System;
using System.Globalization;

namespace ExamplesLibrary.Types
{
    public class ExampleDecimal
    {
        public static void ShowMinimumValue()
        {
            decimal decimalMin = decimal.MinValue;

            Console.WriteLine($"Show decimal minimum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", decimalMin)}");
        }

        public static void ShowMaximumValue()
        {
            decimal decimalMax = decimal.MaxValue;

            Console.WriteLine($"Show decimal maximum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", decimalMax)}");
        }
    }
}
