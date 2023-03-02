using System;
using System.Collections.Generic;

namespace ExamplesLibrary.Types.Conversions
{
    public class ExampleConvert
    {
        public static void ConvertToString()
        {
            List<string> exampleTypes = new List<string>
            {
                Convert.ToString(true),
                Convert.ToString(byte.MaxValue),
                Convert.ToString($"U+{Convert.ToInt32(char.MaxValue):x4}"),
                Convert.ToString(decimal.MaxValue),
                Convert.ToString(double.MaxValue),
                Convert.ToString(float.MaxValue),
                Convert.ToString(int.MaxValue),
                Convert.ToString(nint.MaxValue),
                Convert.ToString(long.MaxValue),
                Convert.ToString(sbyte.MaxValue),
                Convert.ToString(short.MaxValue),
                Convert.ToString(uint.MaxValue),
                Convert.ToString(nuint.MaxValue),
                Convert.ToString(ulong.MaxValue),
                Convert.ToString(ushort.MaxValue)
            };

            foreach (string exampleType in exampleTypes)
            {
                Console.WriteLine($"{exampleType} is of type {exampleType.GetType()}");
            }
        }
    }
}
