using System;

namespace ExamplesLibrary.Types
{
    public class ExampleChar
    {
        public static void ShowMinimumValue()
        {
            int charMin = char.MinValue;

            Console.WriteLine($"Show char minimum value: U+{charMin:x4}");
        }

        public static void ShowMaximumValue()
        {
            int charMax = char.MaxValue;

            Console.WriteLine($"Show char maximum value: U+{charMax:x4}");
        }
    }
}
