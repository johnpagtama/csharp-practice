using System;

namespace ExamplesLibrary.Types.Structures
{
    public class ExampleStruct
    {
        private readonly struct Coordinate
        {
            private int X { get; init; }
            private int Y { get; init; }

            public Coordinate(int x, int y)
            {
                X = x;

                Y = y;
            }

            public void Display()
            {
                Console.WriteLine($"({X}, {Y})");
            }
        }

        public static void Call()
        {
            Coordinate coordinate = new Coordinate();

            coordinate.Display();

            Coordinate coordinate1 = new Coordinate(10, 20);

            coordinate1.Display();
        }
    }
}
