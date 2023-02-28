using System;


namespace ExamplesLibrary
{
    public class ExampleUInt
    {
        public static void ShowUnsignedIntegerMinimumValue() 
        {
            uint uIntMin = uint.MinValue;

            Console.WriteLine($"Show uint minimum value: {uIntMin}");
        }

        public static void ShowUnsignedIntegerMaximumValue()
        {
            uint uIntMax = uint.MaxValue;

            Console.WriteLine($"Show uint maximum value: {uIntMax}");
        }
    }
}
