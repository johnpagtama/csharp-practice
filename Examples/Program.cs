using System;
using System.Collections.Generic;
using ExamplesLibrary.Types;
using ExamplesLibrary.Types.Conversions;
using ExamplesLibrary.Selections;
using ExamplesLibrary.Iterations;
using ExamplesLibrary.DataStructures;
using ExamplesLibrary.Types.Structures;
using ExamplesLibrary.Types.Classes;
using ExamplesLibrary.Files;
using ExamplesLibrary.Delegates;

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
            //CallExampleFiles();
            //CallExampleDelegates();
            //CallExampleAbstractShape();
            CallExampleVirtual();
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

        private static void CallExampleFiles()
        {
            ExampleFileHandler.ReadFile();
        }

        private static void CallExampleDelegates()
        {
            ExampleDelegate exampleDelegate = new ExampleDelegate();

            ExampleDelegate exampleDelegate1 = new ExampleDelegate(new List<int>() { 1, 2, 3, 4, 5 });

            DisplaySquared(exampleDelegate, exampleDelegate1);

            static void DisplaySquared(ExampleDelegate exampleDelegate, ExampleDelegate exampleDelegate1)
            {
                foreach (var number in exampleDelegate.Calculate(Square))
                {
                    Console.WriteLine($"Default values squared: {number}");
                }

                foreach (var number in exampleDelegate1.Calculate(Square))
                {
                    Console.WriteLine($"Custom values squared: {number}");
                }
            }

            static List<int> Square(List<int> numbers)
            {
                List<int> squaredNumbers = new List<int>();

                foreach (var number in numbers)
                {
                    squaredNumbers.Add(number * number);
                }

                return squaredNumbers;
            }
        }

        private static void CallExampleAbstractShape()
        {
            ExampleRectangle exampleRectangle = new ExampleRectangle();

            Console.WriteLine($"Default perimeter: {exampleRectangle.GetPerimeter()}");

            ExampleRectangle exampleRectangle1 = new ExampleRectangle(3, 9);

            Console.WriteLine($"Custom perimeter: {exampleRectangle1.GetPerimeter()}");
        }

        private static void CallExampleVirtual()
        {
            Fahrenheit fahrenheit = new Fahrenheit();

            Console.WriteLine($"{fahrenheit.Temperature} F = {fahrenheit.Convert():0.00} C");

            Fahrenheit fahrenheit1 = new Fahrenheit(45.0);

            Console.WriteLine($"{fahrenheit1.Temperature} F = {fahrenheit1.Convert():0.00} C");

            Celsius celsius = new Celsius();

            Console.WriteLine($"{celsius.Temperature} C = {celsius.Convert():0.00} F");

            Celsius celsius1 = new Celsius(45.0);

            Console.WriteLine($"{celsius1.Temperature} C = {celsius1.Convert():0.00} F");
        }
    }
}
