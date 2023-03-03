using System;

namespace ExamplesLibrary.Types.Conversions
{
    public class ExampleParse
    {
        public static void ParseToInt()
        {
            string numericalString = "12";

            Console.WriteLine($"{numericalString.GetType()} {numericalString} is now {Int32.Parse(numericalString).GetType()} {Int32.Parse(numericalString)}");
        }
    }
}
