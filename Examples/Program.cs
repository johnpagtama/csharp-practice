﻿using ExamplesLibrary.Types;
using ExamplesLibrary.Types.Conversions;
using ExamplesLibrary.Selections;
using ExamplesLibrary.Iterations;
using ExamplesLibrary.DataStructures;
using ExamplesLibrary.Types.Structures;
using ExamplesLibrary.Types.Classes;

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
            CallExampleTypeClasses();
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
            ExampleClass player1 = new ExampleClass();

            player1.GetPosition();

            player1.Walk(4, 5);

            player1.GetPosition();

            player1.Attack();

            ExampleClass player2 = new ExampleClass(4, 5);

            player2.GetPosition();
        }
    }
}
