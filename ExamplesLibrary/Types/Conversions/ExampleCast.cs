using System;

namespace ExamplesLibrary.Types.Conversions
{
    public class ExampleCast
    {
        public static void CastToInt()
        {
            double exampleDouble = 3.14;
            float exampleFloat = 2.3f;
            long exampleLong = 1L;

            Console.WriteLine($"{exampleDouble.GetType()} {exampleDouble} is now of type {((int)exampleDouble).GetType()}\n{exampleFloat.GetType()} {exampleFloat} is now of type {((int)exampleFloat).GetType()}\n{exampleLong.GetType()} {exampleLong} is now of type {((int)exampleLong).GetType()}\n");
        }
    }
}
