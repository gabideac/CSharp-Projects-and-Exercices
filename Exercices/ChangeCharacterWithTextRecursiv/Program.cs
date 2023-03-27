9using System;

namespace ChangeCharacterWithTextRecursiv
{
    class Program
    {
        public static string ChangeText(string originalText, char charToChange, string text)
        {
            string result = "";
            int count = 0;
            ChangeRecursive(ref result, ref count, originalText, charToChange, text);
            return result;
        }

        public static string ChangeRecursive(ref string result, ref int count, string originalText, char charToChange, string text)
        {
            if (count == originalText.Length)
            {
                return result + originalText[count - 1];
            }

            if (originalText[count] == charToChange)
            {
                result += text;
            }
            else
            {
                result += originalText[count];
            }

            count++;
            return ChangeRecursive(ref result, ref count, originalText, charToChange, text);
        }

        static void Main()
        {
          Console.WriteLine(ChangeText(Console.ReadLine(), Convert.ToChar(Console.ReadLine()), Console.ReadLine()));
        }
    }
}
