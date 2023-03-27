using System;

namespace PasswordComplexity
{
    public struct PasswordRequirements
    {
        public int LowerCaseLetters;
        public int UpperCaseLetters;
        public int Digits;
        public int Symbols;
        public bool AllowSimilarCharacters;
        public bool AllowAmbiguousCharacters;

        public PasswordRequirements(int lowerCaseLetters, int upperCaseLetters, int digits, int symbols, bool allowSimilarCharacters, bool allowAmbiguousCharacters)
        {
            this.LowerCaseLetters = lowerCaseLetters;
            this.UpperCaseLetters = upperCaseLetters;
            this.Digits = digits;
            this.Symbols = symbols;
            this.AllowSimilarCharacters = allowSimilarCharacters;
            this.AllowAmbiguousCharacters = allowAmbiguousCharacters;
        }
    }

    public class Program
    {
        public static bool CheckPassword(PasswordRequirements conditions, string input)
        {
            PasswordRequirements inputPassword = CountCharacters(input);

            if (inputPassword.LowerCaseLetters < conditions.LowerCaseLetters)
            {
                return false;
            }

            if (inputPassword.UpperCaseLetters < conditions.UpperCaseLetters)
            {
                return false;
            }

            if (inputPassword.Digits < conditions.Digits)
            {
                return false;
            }

            if (inputPassword.Symbols < conditions.Symbols)
            {
                return false;
            }

            if (!CheckAmbiguousOrSimilarCharacters(input, conditions.AllowSimilarCharacters, "similar"))
            {
                return false;
            }

            if (!CheckAmbiguousOrSimilarCharacters(input, conditions.AllowAmbiguousCharacters, "ambiguous"))
            {
                return false;
            }

            return true;
        }

        static void Main()
        {
            string inputPassword = Console.ReadLine();
            PasswordRequirements conditions = Conditions(
                Convert.ToInt32(Console.ReadLine()),
                Convert.ToInt32(Console.ReadLine()),
                Convert.ToInt32(Console.ReadLine()),
                Convert.ToInt32(Console.ReadLine()),
                Convert.ToBoolean(Console.ReadLine()),
                Convert.ToBoolean(Console.ReadLine()));
            Console.WriteLine(CheckPassword(conditions, inputPassword));
            Console.ReadLine();
        }

        static PasswordRequirements CountCharacters(string inputPassword)
        {
            char[] password = inputPassword.ToCharArray();
            PasswordRequirements result = new PasswordRequirements();
            int countLowerCaseLetters = 0;
            int countUpperCaseLetters = 0;
            int countDigits = 0;
            int countSymbols = 0;
            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (inputPassword[i] >= '0' && inputPassword[i] <= '9')
                {
                    countDigits++;
                }
                else if (inputPassword[i] >= 'A' && inputPassword[i] <= 'Z')
                {
                    countUpperCaseLetters++;
                }
                else if (inputPassword[i] >= 'a' && inputPassword[i] <= 'z')
                {
                    countLowerCaseLetters++;
                }
                else
                {
                    countSymbols++;
                }
            }

            result.LowerCaseLetters = countLowerCaseLetters;
            result.UpperCaseLetters = countUpperCaseLetters;
            result.Digits = countDigits;
            result.Symbols = countSymbols;
            return result;
        }

        static PasswordRequirements Conditions(int lowerCase, int upperCase, int digits, int symbols, bool allowSimilarCharacters, bool allowAmbiguousCharcaters)
        {
            PasswordRequirements conditions = new PasswordRequirements();
            conditions.LowerCaseLetters = lowerCase;
            conditions.UpperCaseLetters = upperCase;
            conditions.Digits = digits;
            conditions.Symbols = symbols;
            conditions.AllowSimilarCharacters = allowSimilarCharacters;
            conditions.AllowAmbiguousCharacters = allowAmbiguousCharcaters;
            return conditions;
        }

        static bool CheckAmbiguousOrSimilarCharacters(string input, bool condition, string type)
        {
            if (condition)
            {
                return true;
            }

            const string ambiguousCharacters = "{}[]()/\'\"~,;.<>" + @"\";
            const string similarCharacters = "lI1o0O";
            string typeCharacters = type == "similar" ? similarCharacters : ambiguousCharacters;
            for (int i = 0; i < input.Length; i++)
            {
                if (typeCharacters.Contains(input[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}