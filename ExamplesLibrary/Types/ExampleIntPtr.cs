using System;
using System.Globalization;

namespace ExamplesLibrary.Types
{
    public class ExampleIntPtr
    {
        public static void ShowMinimumValue()
        {
            nint nIntMin = nint.MinValue;

            Console.WriteLine($"Show nint minimum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", nIntMin)}");
        }

        public static void ShowMaximumValue()
        {
            nint nIntMax = nint.MaxValue;

            Console.WriteLine($"Show nint maximum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", nIntMax)}");
        }
    }
}
