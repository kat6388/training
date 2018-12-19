using System.Collections.Generic;

namespace ConverterDelegates
{
    class Validation
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
    }
}

