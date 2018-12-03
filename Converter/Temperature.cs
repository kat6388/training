namespace Converter
{
    class Temperature
    {
        //C
        public double FromСtoF(double C)
        {
            double F = (C * 9/5)+32;
            return F;
        }
        public double FromСtoK(double C)
        {
            double K = C + 273.15;
            return K;
        }
        //F
        public double FromFtoC(double F)
        {
            double C = (F - 32)* 5/9;
            return C;
        }
        public double FromFtoK(double F)
        {
            double K = ((F - 32) * 5 / 9) + 273.15;
            return K;
        }
        //K
        public double FromKtoC(double K)
        {
            double C = K - 273.15;
            return C;
        }
        public double FromKtoF(double K)
        {
            double F = ((K - 273.15)*9/5)+32;
            return F;
        }
    }
}
