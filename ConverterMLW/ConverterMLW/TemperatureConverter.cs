namespace ConverterMLW
{
    public class TemperatureConverter : Converter
    {
        public override double Convert(string from, string to, double value)
        {
            double result = 0.0;

            if (from == "F" && to == "K")
            {
                result =  FromFtoK(value);
            }
            if (from == "F" && to == "C")
            {
                result = FromFtoC(value);
            }

            if (from == "K" && to == "F")
            {
                result = FromKtoF(value);
            }
            if (from == "K" && to == "C")
            {
                result = FromKtoC(value);
            }
            if (from == "C" && to == "F")
            {
                result = FromCtoF(value);
            }
            if (from == "C" && to == "K")
            {
                result = FromCtoK(value);
            }
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
           
















        
        
        
        
        
        
        
        
        
        
        
  
        
        
        
        
    