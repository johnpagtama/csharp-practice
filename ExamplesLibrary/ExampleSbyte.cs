using System;

namespace ExamplesLibrary
{
    public class ExampleSByte
    {
        public static void ShowSByteMinimumValue()
        {
            sbyte sByteMin = sbyte.MinValue;

            Console.WriteLine($"Show sbyte minimum value: {sByteMin}");
        }

        public static void ShowSByteMaximumValue()
        {
            sbyte sByteMax = sbyte.MaxValue;

            Console.WriteLine($"Show sbyte maximum value: {sByteMax}");
        }
    }
}
