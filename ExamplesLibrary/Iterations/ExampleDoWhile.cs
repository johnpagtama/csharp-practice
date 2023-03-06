using System;

namespace ExamplesLibrary.Iterations
{
    public class ExampleDoWhile
    {
        public static void Loop()
        {
            int counter = 0;

            do
            {
                Console.WriteLine($"Do while iteration: {counter}");

                counter++;
            } while (counter < 5);
        }
    }
}
