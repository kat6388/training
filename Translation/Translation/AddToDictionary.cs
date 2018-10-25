using System.Collections.Generic;

namespace Translation
{
    class AddToDictionary
    {
        public static Dictionary<string, string> GenerateRusDict()
        {
            Dictionary<string, string> Rus = new Dictionary<string, string>();
            Rus.Add("А", "A");
            Rus.Add("Б", "B");
            Rus.Add("В", "V");
            Rus.Add("Г", "G");
            Rus.Add("Д", "D");
            Rus.Add("Е", "E");
            Rus.Add("Ё", "YO");
            Rus.Add("Ж", "ZH");
            Rus.Add("З", "Z");
            Rus.Add("И", "I");
            Rus.Add("К", "K");
            Rus.Add("Л", "L");
            Rus.Add("М", "M");
            Rus.Add("Н", "N");
            Rus.Add("О", "O");
            Rus.Add("П", "P");
            Rus.Add("Р", "R");
            Rus.Add("С", "S");
            Rus.Add("Т", "T");
            Rus.Add("У", "U");
            Rus.Add("Ф", "F");
            Rus.Add("Х", "KH");
            Rus.Add("Ц", "TS");
            Rus.Add("Ч", "CH");
            Rus.Add("Ш", "SH");
            Rus.Add("Щ", "SCH");
            Rus.Add("Ъ", "-");
            Rus.Add("Ы", "Y");
            Rus.Add("Ь", "-");
            Rus.Add("Э", "E");
            Rus.Add("Ю", "YU");
            Rus.Add("Я", "YA");

            return Rus;
        }

        public static Dictionary<string, string> GenerateEnDict()
        {
            Dictionary<string, string> En = new Dictionary<string, string>();
            En.Add("А", "A");
            En.Add("B", "Б");
            En.Add("V", "В");
            En.Add("G", "Г");
            En.Add("D", "Д");
            En.Add("Е", "E");
            En.Add("YO", "Ё");
            En.Add("ZH", "Ж");
            En.Add("Z", "З");
            En.Add("I", "И");
            En.Add("K", "К");
            En.Add("L", "Л");
            En.Add("M", "М");
            En.Add("N", "Н");
            En.Add("O", "О");
            En.Add("P", "П");
            En.Add("R", "Р");
            En.Add("S", "С");
            En.Add("T", "Т");
            En.Add("U", "У");
            En.Add("F", "Ф");
            En.Add("KH", "Х");
            En.Add("TS", "Ц");
            En.Add("CH", "Ч");
            En.Add("SH", "Ш");
            En.Add("SCH", "Щ");
            En.Add("Y", "Ы");
            En.Add("E", "Э");
            En.Add("YU", "Ю");
            En.Add("YA", "Я");

            return En;
        }
    }
}
