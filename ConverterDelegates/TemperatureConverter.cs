using System;

namespace ConverterDelegates
{
    public class TemperatureConverter : Converter
    {
        public override double Convert()
        {
            double result = 0.0;

            if (From == "F" && To == "K")
            {
                result = FromFtoK(Value);
            }
            if (From == "F" && To == "C")
            {
                result = FromFtoC(Value);
            }

            if (From == "K" && To == "F")
            {
                result = FromKtoF(Value);
            }
            if (From == "K" && To == "C")
            {
                result = FromKtoC(Value);
            }
            if (From == "C" && To == "F")
            {
                result = FromCtoF(Value);
            }
            if (From == "C" && To == "K")
            {
                result = FromCtoK(Value);
            }
            Console.WriteLine(result);
            return result;
        }

        private double FromCtoF(double C)
        {
            double F = (C * 9 / 5) + 32;
            return F;
        }

        private double FromCtoK(double C)
        {
            double K = C + 273.15;
            return K;
        }
        //F
        private double FromFtoC(double F)
        {
            double C = (F - 32) * 5 / 9;
            return C;
        }
        private double FromFtoK(double F)
        {
            double K = ((F - 32) * 5 / 9) + 273.15;
            return K;
        }
        //K
        private double FromKtoC(double K)
        {
            double C = K - 273.15;
            return C;
        }
        private double FromKtoF(double K)
        {
            double F = ((K - 273.15) * 9 / 5) + 32;
            return F;
        }
    }
}
