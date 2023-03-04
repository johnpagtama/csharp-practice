using ExamplesLibrary.Types;
using ExamplesLibrary.Types.Conversions;
using ExamplesLibrary.Selection;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallExampleTypes();
            //CallExampleTypeConversions();
            CallExampleSelection();
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

        private static void CallExampleTypeConversions()
        {
            CallExampleConvert();
            CallExampleCast();
            CallExampleParse();
            CallExampleTryParse();
        }

        private static void CallExampleConvert()
        {
            ExampleConvert.ConvertToString();
            ExampleConvert.ConvertToBoolean();
        }

        private static void CallExampleCast()
        {
            ExampleCast.CastToInt();
        }

        private static void CallExampleParse()
        {
            ExampleParse.ParseToInt();
        }

        private static void CallExampleTryParse()
        {
            ExampleTryParse.TryParseToInt();
        }

        private static void CallExampleSelection()
        {
            ExampleIf.ConditionIsTrue();
            ExampleIfElse.ConditionIsFalse();
        }
    }
}
