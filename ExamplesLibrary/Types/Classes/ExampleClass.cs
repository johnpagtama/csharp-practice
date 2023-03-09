using System;

namespace ExamplesLibrary.Types.Classes
{
    public class ExampleClass
    {
        private int X { get; set; }
        private int Y { get; set; }

        public ExampleClass()
        {
            X = 0;
            Y = 0;
        }

        public ExampleClass(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void GetPosition()
        {
            Console.WriteLine($"Position: ({X}, {Y})");
        }
    }
}
