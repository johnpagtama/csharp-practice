namespace ExamplesLibrary.Types.Classes
{
    public abstract class ExampleAbstractShape
    {
        public abstract int GetPerimeter();
    }

    public class ExampleRectangle : ExampleAbstractShape
    {
        private int Length { get; set; }

        private int Width { get; set; }

        public ExampleRectangle()
        {
            Length = 0;
            Width = 0;
        }

        public ExampleRectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public override int GetPerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
