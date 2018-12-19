using System;

namespace ConverterDelegates
{
    public class WeightConverter : Converter

    {
        public override double Convert()
        {
            double result = 0.0;

            if (From == "Pnd" && To == "Gr")
            {
                result = FromPndToGr(Value);
            }

            if (From == "Pnd" && To == "Pd")
            {
                result = FromPndToPd(Value);
            }

            if (From == "Gr" && To == "Pnd")
            {
                result = FromGrToPnd(Value);
            }

            if (From == "Gr" && To == "Pd")
            {
                result = FromGrToPd(Value);
            }

            if (From == "Pd" && To == "Gr")
            {
                result = FromPdToGr(Value);
            }

            if (From == "Pd" && To == "Pnd")
            {
                result = FromPdToPnd(Value);
            }
            Console.WriteLine(result);
            return result;
        }

        public double FromPndToGr(double Pnd)
        {
            double Gr = Pnd * 453.592;
            return Gr;
        }
        public double FromPndToPd(double Pnd)
        {
            double Pd = Pnd / 36.113;
            return Pd;
        }
        //Gr
        public double FromGrToPnd(double Gr)
        {
            double Pnd = Gr / 453.592;
            return Pnd;
        }
        public double FromGrToPd(double Gr)
        {
            double Pd = Gr / 16380.687;
            return Pd;
        }
        //Pd
        public double FromPdToGr(double Pd)
        {
            double Gr = Pd * 16380.687;
            return Gr;
        }
        public double FromPdToPnd(double Pd)
        {
            double Pnd = Pd * 36.113;
            return Pnd;
        }
    }
}