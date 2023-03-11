using ExamplesLibrary.Types;
using ExamplesLibrary.Types.Conversions;
using ExamplesLibrary.Selections;
using ExamplesLibrary.Iterations;
using ExamplesLibrary.DataStructures;
using ExamplesLibrary.Types.Structures;
using ExamplesLibrary.Types.Classes;
using ExamplesLibrary.Files;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallExampleTypes();
            //CallExampleTypeConversions();
            //CallExampleSelections();
            //CallExampleIterations();
            //CallExampleDataStructures();
            //CallExampleTypeStructures();
            //CallExampleTypeClasses();
            CallExampleFiles();
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

        private static void CallExampleSelections()
        {
            ExampleIf.ConditionIsTrue();
            ExampleIfElse.ConditionIsFalse();
            ExampleIfElseIf.OtherConditionIsTrue();
        }

        private static void CallExampleIterations()
        {
            ExampleFor.Loop();
            ExampleForEach.Loop();
            ExampleWhile.Loop();
            ExampleDoWhile.Loop();
        }

        private static void CallExampleDataStructures()
        {
            ExampleArray.Show();
            ExampleList.Show();
            ExampleDictionary.Show();
            ExampleHashTable.Show();
            ExampleStack.Show();
            ExampleQueue.Show();
        }

        private static void CallExampleTypeStructures()
        {
            ExampleStruct.Call();
        }

        private static void CallExampleTypeClasses()
        {
            ExampleClass human = new ExampleClass();

            human.GetPosition();

            human.Walk(4, 5);

            human.GetPosition();

            human.Attack();

            ExampleClass dog = new ExampleClass("Dog", 4, 5);

            dog.GetPosition();

            dog.Walk(5, 8);

            dog.Attack();

            dog.Eat();

            dog.Drink();

            dog.Sleep();
        }

        public static void CallExampleFiles()
        {
            ExampleFileHandler.ReadFile();
        }
    }
}
