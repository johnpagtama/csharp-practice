using System;

namespace ExamplesLibrary
{
    public class ExampleSByte
    {
        public static void ShowMinimumValue()
        {
            sbyte sByteMin = sbyte.MinValue;

            Console.WriteLine($"Show sbyte minimum value: {sByteMin}");
        }

        public static void ShowMaximumValue()
        {
            sbyte sByteMax = sbyte.MaxValue;

            Console.WriteLine($"Show sbyte maximum value: {sByteMax}");
        }
    }
}
