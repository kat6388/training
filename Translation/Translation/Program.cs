using System;

namespace Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press string to translate:");
            string toTranslate = Console.ReadLine();
            Console.WriteLine("Initial string:" + " " + toTranslate);

            if ((toTranslate[0] > 64 && toTranslate[0] < 91) || (toTranslate[0] > 96 && toTranslate[0] <123))
            {
                Console.WriteLine("Translated string:" + " " + EnToRu.Translate(toTranslate));
            }

            else
            {
                Console.WriteLine("Translated string:" + " " + RuToEn.Translate(toTranslate));

            }
        }
    }
}
