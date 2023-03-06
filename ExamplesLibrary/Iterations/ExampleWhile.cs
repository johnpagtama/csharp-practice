using System;

namespace ExamplesLibrary.Iterations
{
    public class ExampleWhile
    {
        public static void Loop()
        {
            int counter = 0;

            while (counter < 5)
            {
                Console.WriteLine($"While loop iteration: {counter}");

                counter++;
            }
        }
    }
}
