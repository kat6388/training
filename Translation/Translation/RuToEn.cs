namespace Translation
{
    class RuToEn
    {
      public static string Translate(string ru)
        {

            string upper = ru.ToUpper();
            string translated = string.Empty;

            for (int i = 0; i < upper.Length; i++)
            {
                string value = string.Empty;
                if (AddToDictionary.GenerateRusDict().TryGetValue(upper[i].ToString(), out value))
                {
                    translated += value;
                }
                else
                {
                    translated += upper[i];
                }
            }
            return translated;
       }
    }
}
