namespace Translation
{
    class EnToRu
    {
      public static string Translate(string en)
       {

            string upper = en.ToUpper();
            string translated = string.Empty;

            for (int i = 0; i < upper.Length; i++)
            {
                string value = string.Empty;
                if (AddToDictionary.GenerateEnDict().TryGetValue(upper[i].ToString(), out value))
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
