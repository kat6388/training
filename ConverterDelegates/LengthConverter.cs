using System;

namespace ConverterDelegates
{
    class LengthConverter : Converter
    {
        public override double Convert()
        {

            double result = 0.0;

            if (From == "Ft" && To == "M")
            {
               result = FromFtToM(Value);
            }

            else if (From == "M" && To == "Ft")
            {
                result = FromMToFt(Value);
            }

            Console.WriteLine(result);
            return result;
        }
        private double FromFtToM(double feet)
        {
            double metre = feet * 0.3048;
            return metre;
        }
        private double FromMToFt(double metre)
        {
            double feet = metre * 3.28084;
            return feet;
        }
    }
}