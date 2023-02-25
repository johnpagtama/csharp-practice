using System;

namespace ExamplesLibrary
{
    public class ExampleSbyte
    {
        public static void ShowSbyteMinimumValue()
        {
            sbyte sbyteMin = sbyte.MinValue;

            Console.WriteLine($"Show sbyte minimum value: {sbyteMin}");
        }

        public static void ShowSbyteMaximumValue()
        {
            sbyte sbyteMax = sbyte.MaxValue;

            Console.WriteLine($"Show sbyte maximum value: {sbyteMax}");
        }
    }
}
