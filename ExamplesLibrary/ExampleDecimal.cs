using System;

namespace ExamplesLibrary
{
    public class ExampleDecimal
    {
        public static void ShowMinimumValue()
        {
            decimal decimalMin = decimal.MinValue;

            Console.WriteLine($"Show decimal minimum value: {decimalMin}");
        }

        public static void ShowMaximumValue()
        {
            decimal decimalMax = decimal.MaxValue;

            Console.WriteLine($"Show decimal maximum value: {decimalMax}");
        }
    }
}
