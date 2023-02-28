using System;
using System.Globalization;

namespace ExamplesLibrary
{
    public class ExampleNInt
    {
        public static void ShowNIntMinimumValue()
        {
            nint nIntMin = nint.MinValue;

            Console.WriteLine($"Show nint minimum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", nIntMin)}");
        }

        public static void ShowNIntMaximumValue()
        {
            nint nIntMax = nint.MaxValue;

            Console.WriteLine($"Show nint maximum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", nIntMax)}");
        }
    }
}
