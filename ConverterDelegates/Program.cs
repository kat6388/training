using System;

namespace ConverterDelegates
{
    class Program
    {
        public delegate double MyDelagate();
        public static event MyDelagate DoConversion;

        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Enter value to convert:");
                double valueToConvert = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter from:");
                string from = Console.ReadLine();
                Console.WriteLine("Enter to:");
                string to = Console.ReadLine();

                var valid = new Validation();
                bool validation = valid.IsUnitsValid(from, to);
                if (validation == true)
                {
                    Converter conv = Factory.GetConverter(from);
                    conv.From = from;
                    conv.To = to;
                    conv.Value = valueToConvert;
                    DoConversion += conv.Convert;
                    i++;
                }
                else Console.WriteLine("Invalid input");
            }
            while (i < 3);
            DoConversion();
        }
    }
}
   