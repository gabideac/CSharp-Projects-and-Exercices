using System;

namespace Sudoku
{
    class Program
    {
        static void Main()
        {
            int[][] inputSudoku = InputSudoku();
            bool lines = CheckLines(inputSudoku);
            bool collums = CheckColllums(inputSudoku);
            bool squares = CheckSquares(inputSudoku);
            Console.WriteLine(lines && collums && squares);
            Console.ReadLine();
        }

        private static int[][] InputSudoku()
        {
            int[][] input = new int[9][];
            int[] line = new int[9];
            const int nine = 9;

            for (int i = 0; i < nine; i++)
            {
                string inputString = Console.ReadLine();
                if (inputString == "")
                {
                    inputString = Console.ReadLine();
                }

                string[] stringLine = FillLines(inputString);
                for (int j = 0; j < nine; j++)
                {
                    line[j] = Convert.ToInt32(stringLine[j]);
                }

                input[i] = line;
                line = new int[nine];
            }

            return input;
        }

        static bool CheckIfValid(int[] array)
        {
            const int nine = 9;
            int zero = 0;
            int[] sortedArray = new int[9];
            for (int j = 0; j < nine; j++)
            {
                sortedArray[j] = array[j];
            }

            Array.Sort(sortedArray);
            for (int i = 1; i <= nine; i++)
            {
                if (sortedArray[i - 1]
                    != i)
                {
                    zero++;
                }
            }

            return zero == 0;
        }

        static bool CheckLines(int[][] sudoku)
        {
            const int nine = 9;
            bool result = false;
            for (int i = 0; i < nine; i++)
            {
                result = CheckIfValid(sudoku[i]);
                if (!result)
                {
                    break;
                }
            }

            return result;
        }

        static bool CheckColllums(int[][] sudoku)
        {
            int[] collum = new int[9];
            const int nine = 9;
            bool result = false;
            for (int i = 0; i < nine; i++)
            {
               for (int j = 0; j < nine; j++)
                {
                    collum[j] = sudoku[j][i];
                }

               result = CheckIfValid(collum);
               if (!result)
                {
                    break;
                }
            }

            return result;
        }

        static bool CheckSquares(int[][] sudoku)
        {
            bool result = false;
            const int three = 3;
            int incJ = 0;
            int incForJ = 3;
            for (int p = 0; p < three; p++)
            {
                int zero = CheckValidSquare(incJ, incForJ, sudoku);
                if (zero == 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }

                incJ += three;
                incForJ += three;
            }

            return result;
        }

        static string[] FillLines(string input)
        {
            const string digits = "0123456789";
            string[] inputString = { "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            string[] stringArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (stringArr.Length == inputString.Length)
            {
                for (int i = 0; i < stringArr.Length; i++)
                {
                    if (digits.Contains(stringArr[i]))
                    {
                        inputString[i] = stringArr[i];
                    }
                }
            }

            return inputString;
        }

        static int CheckValidSquare(int incJ, int incForJ, int[][] sudoku)
        {
            int zero = 0;
            bool result = false;
            int[] square = new int[9];
            int incI = 0;
            const int three = 3;
            int incForI = three;
            int count = 0;
            for (int y = 0; y < three; y++)
            {
                for (int j = incJ; j < incForJ; j++)
                {
                    for (int i = incI; i < incForI; i++)
                    {
                        square[count] = sudoku[j][i];
                        count++;
                    }
                }

                count = 0;
                incI += three;
                incForI += three;
                result = CheckIfValid(square);
                if (!result)
                {
                    zero++;
                }
            }

            return zero;
        }
    }
}
