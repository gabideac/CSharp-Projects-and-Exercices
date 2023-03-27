using System;

namespace NumbersToLetters
{
    class Program
    {
        static void Main()
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int lettersNr = GetNrOfLetters(inputNumber);
            string outputWord = ConstructWord(lettersNr, inputNumber);
            Console.WriteLine(outputWord);
            Console.ReadLine();
        }

        static string GetLetterFromNumber(int nr)
        {
            const string alphabet = "ZABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return Convert.ToString(alphabet[nr]);
        }

        static int GetNrOfLetters(int nr)
        {
            const int twentySeven = 27;
            const int sevenIsEnough = 7;
            double temp = 0;
            int i;
            for (i = 1; i < sevenIsEnough; i++)
            {
                temp = Math.Pow(twentySeven, i) - Math.Pow(twentySeven, i - 1);
                if (nr <= temp)
                {
                    break;
                }
            }

            return i;
        }

        static string ConstructWord(int wordLength, int nr)
        {
            const int twentySix = 26;
            string word = "";
            if (wordLength == 1)
            {
                word = GetLetterFromNumber(nr);
            }
            else
            {
                for (int j = wordLength - 1; j > 0; j--)
                {
                    int multiples = Convert.ToInt32(Math.Pow(twentySix, j));
                    int magicalNrs = nr / multiples;
                    nr = nr - multiples * magicalNrs;
                    if (nr % multiples == 0)
                    {
                        magicalNrs--;
                        nr = multiples;
                    }

                    word += GetLetterFromNumber(magicalNrs);
                    if (j == 1)
                    {
                        word += GetLetterFromNumber(nr);
                    }
                }
            }

            return word;
        }
    }
}
