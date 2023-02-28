using System;

namespace ExamplesLibrary
{
    public class ExampleLong
    {
        public static void ShowLongMinimumValue()
        {
            long longMin = long.MinValue;

            Console.WriteLine($"Show long minimum value: {longMin}");
        }

        public static void ShowLongMaximumValue()
        {
            long longMax = long.MaxValue;

            Console.WriteLine($"Show long maximum value: {longMax}");
        }
    }
}
