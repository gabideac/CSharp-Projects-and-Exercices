using System;

namespace Bingo
{
    class Program
    {
        static void Main()
        {
            int[] card = InputCard();
            int[] extractedNr = ExtractNumbers();
            int[] machingNrs = GetMatchingNumbers(card, extractedNr);
            string check = CheckIfBingo(card, machingNrs);
            Console.WriteLine(check);
            Console.ReadLine();
        }

        static int[] InputCard()
        {
            const int three = 3;
            const int nine = 9;
            int[] card = new int[9];
            string cardString = "";
            for (int i = 0; i < three; i++)
            {
                cardString += Console.ReadLine() + " ";
            }

            string[] tempArr = cardString.Split();
            for (int j = 0; j < nine; j++)
            {
                card[j] = Convert.ToInt32(tempArr[j]);
            }

            return card;
        }

        static int[] ExtractNumbers()
        {
            const int x = 15;
            int[] extracted = new int[15];
            for (int i = 0; i < x; i++)
            {
                extracted[i] = Convert.ToInt32(Console.ReadLine());
            }

            return extracted;
        }

        static string CheckIfBingo(int[] card, int[] machingNrs)
        {
            int count = 0;
            int[] topLine = new[] { card[0], card[1], card[2] };
            if (CheckLines(machingNrs, topLine))
            {
                count++;
            }

            int[] horizontalLine = new[] { card[3], card[4], card[5] };
            if (CheckLines(machingNrs, horizontalLine))
            {
                count++;
            }

            int[] bottomLine = new[] { card[6], card[7], card[8] };
            if (CheckLines(machingNrs, bottomLine))
            {
                count++;
            }

            int[] rightLine = new[] { card[0], card[3], card[6] };
            if (CheckLines(machingNrs, rightLine))
            {
                count++;
            }

            int[] verticalLine = new[] { card[1], card[4], card[7] };
            if (CheckLines(machingNrs, verticalLine))
            {
                count++;
            }

            int[] leftLine = new[] { card[2], card[5], card[8] };
            if (CheckLines(machingNrs, leftLine))
            {
                count++;
            }

            if (machingNrs.Length == card.Length)
            {
                return "bingo";
            }
            else if (count > 0 && count < card.Length)
            {
                return "linie";
            }
            else
            {
                return "nimic";
            }
        }

        static int[] GetMatchingNumbers(int[] card, int[] extractedNr)
        {
            _ = new[] { "" };
            string machingNumbersString = "";
            for (int i = 0; i < extractedNr.Length; i++)
            {
                for (int j = 0; j < card.Length; j++)
                {
                    if (card[j] == extractedNr[i])
                    {
                        machingNumbersString += extractedNr[i] + " ";
                    }
                }
            }

            string[] tempString = machingNumbersString.Split(" ");
            int[] machingNumbers = new int[tempString.Length - 1];
            for (int p = 0; p < tempString.Length - 1; p++)
            {
                machingNumbers[p] = Convert.ToInt32(tempString[p]);
            }

            return machingNumbers;
        }

        static bool CheckLines(int[] machingNrs, int[] lines)
        {
            int j = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                for (j = 0; j < machingNrs.Length; j++)
                {
                    if (lines[i] == machingNrs[j])
                    {
                        break;
                    }
                }

                if (j == machingNrs.Length)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
