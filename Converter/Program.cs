using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var fact = new Factory();
            bool validation = fact.IsUnitsValid(from, to);
            if (validation == true)
            {
                double result = fact.Converted(valueToConvert, from, to);
                Console.WriteLine(result);
            }
            else Console.WriteLine("Invalid input");
        }
    }
}
