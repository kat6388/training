using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
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
                var converter = Factory.GetConverter(from);
                var result = converter.Convert(from, to, valueToConvert);
                Console.WriteLine(result);
            }
            else Console.WriteLine("Invalid input");
        }
    }
}
