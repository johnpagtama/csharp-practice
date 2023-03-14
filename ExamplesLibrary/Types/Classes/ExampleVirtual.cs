using System;

namespace ExamplesLibrary.Types.Classes
{
    public abstract class ExampleVirtual
    {
        public double Temperature { get; set; }

        public virtual double Convert()
        {
            return Temperature * 9 / 5 + 32;
        }
    }

    public class Fahrenheit : ExampleVirtual
    {
        public Fahrenheit()
        {
            Temperature = 0.0;
        }

        public Fahrenheit(double temperature)
        {
            Temperature = temperature;
        }


        public override double Convert()
        {
            return (Temperature - 32) * 5 / 9;
        }
    }

    public class Celsius : ExampleVirtual
    {
        public Celsius()
        {
            Temperature = 0.0;
        }

        public Celsius(double temperature)
        {
            Temperature = temperature;
        }

        public override double Convert()
        {
            return base.Convert();
        }
    }
}
