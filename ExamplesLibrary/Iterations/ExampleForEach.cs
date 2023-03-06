using System;

namespace ExamplesLibrary.Iterations
{
    public class ExampleForEach
    {
        public static void Loop()
        {
            string values = "0 1 2 3 4";

            foreach (var value in values.Split(' '))
            {
                Console.WriteLine($"Foreach loop iteration: {value}");
            }
        }
    }
}
