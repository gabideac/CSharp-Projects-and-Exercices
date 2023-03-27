using System;

namespace WordsCorrection
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string words = CorrectWordsInput().ToLower();
            string machingWords = CheckMachingWords(text, words);
            string[][] shortendArrays = GetShortendArrays(machingWords, text, words);
            string[] textArray = shortendArrays[0];
            string[] wordsArray = shortendArrays[1];
            for (int i = 0; i < textArray.Length; i++)
            {
                string difLetter = DiferentLetter(textArray[i], wordsArray);
                string invertedLetter = InvertedLetters(textArray[i], wordsArray);
                string moreLetters = MoreLetters(textArray[i], wordsArray);
                string lessLettrs = LessLetters(textArray[i], wordsArray);
                string result = difLetter + invertedLetter + moreLetters + lessLettrs;

                Console.WriteLine(result == "" ? textArray[i] + ": (nu sunt sugestii)" : textArray[i] + ": " + result);
            }

            Console.ReadLine();
        }

        static string CorrectWordsInput()
        {
            int wordsNr = Convert.ToInt32(Console.ReadLine());
            string words = "";
            for (int i = 0; i < wordsNr; i++)
            {
                words += Console.ReadLine() + " ";
            }

            return words;
        }

        static string CheckMachingWords(string text, string words)
        {
            text = text.ToLower();
            string[] textArr = text.Split(" ");
            string machingWords = "";
            for (int j = 0; j < textArr.Length; j++)
            {
                if (words.Contains(textArr[j] + " "))
                {
                    machingWords += textArr[j] + " ";
                }
            }

            string[] machWordsArr = machingWords.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (machWordsArr.Length == textArr.Length)
            {
                Console.WriteLine("Text corect!");
            }

            return machingWords;
        }

        static string[][] GetShortendArrays(string machingWords, string text, string words)
        {
            string[][] shortendArray = new string[2][];
            string[] machWordsArr = machingWords.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string[] textArr = text.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string[] wordsArr = words.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string[] shortText = new string[textArr.Length - machWordsArr.Length];
            string[] remainingWords = new string[wordsArr.Length];
            int count = 0;
            for (int i = 0; i < textArr.Length; i++)
            {
                if (!machingWords.Contains(textArr[i] + " "))
                {
                    shortText[count] = textArr[i];
                    count++;
                }
            }

            shortendArray[0] = shortText;
            shortendArray[1] = wordsArr;
            return shortendArray;
        }

        static string DiferentLetter(string word, string[] wordsArray)
        {
            string difLetter = "";
            int score = 0;
            for (int i = 0; i < wordsArray.Length; i++)
            {
                for (int j = 0; j < wordsArray[i].Length; j++)
                {
                    if (word.Length != wordsArray[i].Length)
                    {
                        break;
                    }

                    if (word[j] == wordsArray[i][j])
                        {
                            score++;
                        }
                }

                if (score == wordsArray[i].Length - 1 && word.Length == wordsArray[i].Length)
                {
                    difLetter += wordsArray[i] + " ";
                }

                score = 0;
            }

            return difLetter;
        }

        static string InvertedLetters(string word, string[] wordsArray)
        {
            string invertedLetter = "";
            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (word.Length == wordsArray[i].Length)
                {
                    char[] letterdWord = word.ToCharArray();
                    Array.Sort(letterdWord);
                    char[] letterdCorrectWord = wordsArray[i].ToCharArray();
                    Array.Sort(letterdCorrectWord);
                    string newWord = string.Concat(letterdWord);
                    string newCorrectWord = string.Concat(letterdCorrectWord);
                    if (newWord == newCorrectWord)
                    {
                        invertedLetter += wordsArray[i] + " ";
                    }
                }
            }

            return invertedLetter;
        }

        static string MoreLetters(string word, string[] wordsArray)
        {
            string moreLetters = "";
            bool missingLetter = false;
            for (int i = 0; i < wordsArray.Length; i++)
            {
                missingLetter = false;
                if (word.Length + 1 == wordsArray[i].Length)
                {
                    missingLetter = MissingLetter(word, wordsArray[i]);
                }

                if (missingLetter)
                {
                    moreLetters += wordsArray[i] + " ";
                }
            }

            return moreLetters;
        }

        static string LessLetters(string word, string[] wordsArray)
        {
            string lessLetters = "";
            bool missingLetter = false;
            for (int i = 0; i < wordsArray.Length; i++)
            {
                missingLetter = false;
                if (word.Length == wordsArray[i].Length + 1)
                {
                    missingLetter = MissingLetter(wordsArray[i], word);
                }

                if (missingLetter)
                {
                    lessLetters += wordsArray[i] + " ";
                }
            }

            return lessLetters;
        }

        static bool MissingLetter(string wordShort, string wordLong)
        {
            int indexShort = 0;
            int indexLong = 0;
            int score = 0;
            for (int i = 0; i < wordShort.Length; i++)
            {
                if (wordLong.Contains(wordShort[i]))
                {
                    score++;
                }
            }

            if (score == wordShort.Length)
            {
                for (int j = 0; j < wordShort.Length; j++)
                {
                    if (indexShort == indexLong && wordShort[indexShort] != wordLong[indexLong])
                    {
                        indexLong++;
                    }

                    if (wordShort[indexShort] == wordLong[indexLong])
                    {
                        indexShort++;
                        indexLong++;
                    }
                }
            }

            return indexShort == wordShort.Length;
        }
    }
}
