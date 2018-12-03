using System;
using System.Collections.Generic;

namespace Converter
{
    class Factory
    {
        private static List<string> _measurements = new List<string>()
        {
            "F","K", "C", "Gr","Pnd","Pd","M","Ft"
        };
        public bool IsUnitsValid(string from, string to)
        {
            if (_measurements.Contains(from) || _measurements.Contains(to))
            {
                return true;
            }
            return false;
        }

        public double Converted(double value, string from, string to)
        {
            var temperature = new Temperature();
            var weight = new Weight();
            var distance = new Distance();

            double result = 0.0;
            //Weight converters
            if ( from == "Gr" && to == "Pnd")
            {
                result = weight.FromGrToPnd(value);
                return result;
            }
            if (from == "Gr" && to == "Pd")
            {
                result = weight.FromGrToPd(value);
                return result;
            }
            if (from == "Pnd" && to == "Pd")
            {
                result = weight.FromPndToPd(value);
                return result;
            }
            if (from == "Pnd" && to == "Gr")
            {
                result = weight.FromPndToGr(value);
                return result;
            }
            if (from == "Pd" && to == "Pnd")
            {
                result = weight.FromPdToPnd(value);
                return result;
            }
            if (from == "Pd" && to == "Gr")
            {
                result = weight.FromPdToGr(value);
                return result;
            }
            // Distance converters

            if (from == "Ft" && to == "M")
            {
                result = distance.FromFtToM(value);
                return result;
            }
            if (from == "M" && to == "Ft")
            {
                result = distance.FromMToFt(value);
                return result;
            }
            //Temperature converters

            if (from == "F" && to == "K")
            {
                result = temperature.FromFtoK(value);
                return result; 
            }
            if (from == "F" && to == "C")
            {
                result = temperature.FromFtoC(value);
                return result;
            }

            if (from == "K" && to == "F")
            {
                result = temperature.FromKtoF(value);
                return result;
            }
            if (from == "K" && to == "C")
            {
                result = temperature.FromKtoC(value);
                return result;
            }
            if (from == "C" && to == "F")
            {
                result = temperature.FromСtoF(value);
                return result;
            }
            if (from == "C" && to == "K")
            {
                result = temperature.FromСtoK(value);
                return result;
            }

            else throw new Exception("Invalid converters");

            //return tempResult;
            Console.WriteLine(result);

        }
    }
}
