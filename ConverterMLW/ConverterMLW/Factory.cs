using System;

namespace Converter
{
   static class Factory
    {
           public static ConverterMLW.Converter GetConverter(string from)
        {
            if (from=="M" || from == "Ft")
            {
                return new ConverterMLW.LengthConverter();
            }
            if (from == "Pnd" || from == "Gr"|| from =="Pd")
            {
                return new ConverterMLW.WeightConverter();
            }

            if (from == "K" || from == "F"|| from == "C")
            {
                return new ConverterMLW.TemperatureConverter();
            }
            else throw new Exception("Invalid converters");
        }
    }
}
