namespace ConverterMLW
{
    class LengthConverter: Converter
    {
        public override double Convert(string from, string to, double value)
        {
            double result = 0.0;

            if (from == "Ft" && to == "M")
            {
                result = FromFtToM(value);
            }

           else if (from == "M" && to == "Ft")
            {
                result = FromMToFt(value);
            }

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
