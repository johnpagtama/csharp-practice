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

        public static void ConvertToBoolean()
        {
            List<bool> exampleTypes = new List<bool>
            {
                Convert.ToBoolean(byte.MaxValue),
                Convert.ToBoolean(Convert.ToInt32(char.MaxValue)),
                Convert.ToBoolean(decimal.MaxValue),
                Convert.ToBoolean(double.MaxValue),
                Convert.ToBoolean(float.MaxValue),
                Convert.ToBoolean(int.MaxValue),
                Convert.ToBoolean(nint.MaxValue),
                Convert.ToBoolean(long.MaxValue),
                Convert.ToBoolean(sbyte.MaxValue),
                Convert.ToBoolean(short.MaxValue),
                Convert.ToBoolean(uint.MaxValue),
                Convert.ToBoolean(nuint.MaxValue),
                Convert.ToBoolean(ulong.MaxValue),
                Convert.ToBoolean(ushort.MaxValue)
            };

            foreach (bool exampleType in exampleTypes)
            {
                Console.WriteLine($"{exampleType} is of type: {exampleType.GetType()}");
            }
        }
    }
}
