using System;
using System.Collections.Generic;

namespace ExamplesLibrary.Delegates
{
    public class ExampleDelegate
    {
        public List<int> Numbers { get; set; }

        public ExampleDelegate()
        {
            Numbers = new List<int>() { 0, 0, 0, 0, 0};
        }

        public ExampleDelegate(List<int> numbers)
        {
            Numbers = numbers;
        }

        public delegate List<int> SquareNumbers(List<int> numbers);

        public List<int> Calculate(SquareNumbers squareNumbers)
        {
            return squareNumbers(Numbers);
        }
    }
}
