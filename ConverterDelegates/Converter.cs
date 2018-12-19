namespace ConverterDelegates
{
    public abstract class Converter
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Value { get; set; }
        public abstract double Convert();
    }
}
