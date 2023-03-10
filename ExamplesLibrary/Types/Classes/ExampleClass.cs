using System;

namespace ExamplesLibrary.Types.Classes
{
    public class ExampleClass : ExampleParentClass, IExampleInterface
    {
        private int X { get; set; }
        private int Y { get; set; }

        public ExampleClass()
        {

            Species = "N/A";
            X = 0;
            Y = 0;
        }

        public ExampleClass(string species, int x, int y)
        {
            Species = species;
            X = x;
            Y = y;
        }

        public void GetPosition()
        {
            Console.WriteLine($"Position: ({X}, {Y})");
        }

        public void Walk(int x, int y)
        {
            X = x;
            Y = y;

            Console.WriteLine($"{Species} begins walking");
        }

        public void Attack()
        {
            Console.WriteLine($"{Species} begins attacking");
        }
    }
}
