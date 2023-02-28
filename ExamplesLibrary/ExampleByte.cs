using System;

namespace ExamplesLibrary
{
    public class ExampleByte
    {
        public static void ShowMinimumValue()
        {
            byte byteMin = byte.MinValue;

            Console.WriteLine($"Show byte minimum value: {byteMin}");
        }

        public static void ShowMaximumValue()
        {
            byte byteMax = byte.MaxValue;

            Console.WriteLine($"Show byte maximum value: {byteMax}");
        }
    }
}
