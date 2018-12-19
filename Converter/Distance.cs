namespace Converter
{
    class Distance
    {
       public double FromFtToM (double feet)
        {
            double metre = feet * 0.3048;
            return metre;
        }
        public double FromMToFt(double metre)
        {
            double feet = metre * 3.28084;
            return feet;
        }
    }
}
