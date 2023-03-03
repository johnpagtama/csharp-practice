using System;

namespace ExamplesLibrary.Types.Conversions
{
    public class ExampleTryParse
    {
        public static void TryParseToInt()
        {
            string numericalString = "12";

            if (Int32.TryParse(numericalString, out int parsed))
            {
                Console.WriteLine($"{numericalString.GetType()} {numericalString} is now a {parsed.GetType()} {parsed}");
            }
            else
            {
                Console.WriteLine($"{numericalString.GetType()} {numericalString} cannot be parsed into a valid {parsed.GetType()}");
            }
        }
    }
}
