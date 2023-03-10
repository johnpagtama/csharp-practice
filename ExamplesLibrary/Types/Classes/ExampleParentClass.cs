using System;

namespace ExamplesLibrary.Types.Classes
{
    public class ExampleParentClass
    {
        protected string Species { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Species} begins eating");
        }

        public void Drink()
        {
            Console.WriteLine($"{Species} begins drinking");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Species} begins sleeping");
        }
    }
}
