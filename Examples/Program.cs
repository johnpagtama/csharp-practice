using ExamplesLibrary.Types;
using ExamplesLibrary.Types.Conversions;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            CallExampleTypes();
            ExampleConvert.ConvertToString();
            ExampleConvert.ConvertToBoolean();
        }

        private static void CallExampleTypes()
        {
            ExampleBoolean.ShowTrue();

            ExampleBoolean.ShowFalse();

            ExampleByte.ShowMinimumValue();

            ExampleByte.ShowMaximumValue();

            ExampleChar.ShowMinimumValue();

            ExampleChar.ShowMaximumValue();

            ExampleDecimal.ShowMinimumValue();

            ExampleDecimal.ShowMaximumValue();

            ExampleDouble.ShowMinimumValue();

            ExampleDouble.ShowMaximumValue();

            ExampleFloat.ShowMinimumValue();

            ExampleFloat.ShowMaximumValue();

            ExampleInteger.ShowMinimumValue();

            ExampleInteger.ShowMaximumValue();

            ExampleIntPtr.ShowMinimumValue();

            ExampleIntPtr.ShowMaximumValue();

            ExampleLong.ShowMinimumValue();

            ExampleLong.ShowMaximumValue();

            ExampleSByte.ShowMinimumValue();

            ExampleSByte.ShowMaximumValue();

            ExampleShort.ShowMinimumValue();

            ExampleShort.ShowMaximumValue();

            ExampleUInt.ShowMinimumValue();

            ExampleUInt.ShowMaximumValue();

            ExampleUIntPtr.ShowMinimumValue();

            ExampleUIntPtr.ShowMaximumValue();

            ExampleULong.ShowMinimumValue();

            ExampleULong.ShowMaximumValue();

            ExampleUShort.ShowMinimumValue();

            ExampleUShort.ShowMaximumValue();
        }
    }
}
