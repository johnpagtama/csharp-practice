using System;
using System.Globalization;

namespace ExamplesLibrary.Types
{
    public class ExampleUInt
    {
        public static void ShowMinimumValue() 
        {
            uint uIntMin = uint.MinValue;

            Console.WriteLine($"Show uint minimum value: {uIntMin}");
        }

        public static void ShowMaximumValue()
        {
            uint uIntMax = uint.MaxValue;

            Console.WriteLine($"Show uint maximum value: {String.Format(CultureInfo.InvariantCulture, "{0:#,##0}", uIntMax)}");
        }
    }
}
