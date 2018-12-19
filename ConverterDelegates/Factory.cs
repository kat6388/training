using System;

namespace ConverterDelegates
{
    static class Factory
    {
        public static ConverterDelegates.Converter GetConverter(string from)
        {
            if (from == "M" || from == "Ft")
            {
                return new ConverterDelegates.LengthConverter();
            }
            if (from == "Pnd" || from == "Gr" || from == "Pd")
            {
                return new ConverterDelegates.WeightConverter();
            }
            if (from == "K" || from == "F" || from == "C")
            {
                return new ConverterDelegates.TemperatureConverter();
            }
            else throw new Exception("Invalid converters");
        }
    }
}