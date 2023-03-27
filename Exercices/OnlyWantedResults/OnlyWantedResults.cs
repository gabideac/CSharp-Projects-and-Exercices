using System;

namespace OnlyWantedResults
{
    public class Program
    {
        public static string BuildOperations(int number, int expectedResult)
        {
            string operation = "= " + Convert.ToString(expectedResult);
            string veruifiedResults = "";
            string result = BuildOperations(number, expectedResult, operation, ref veruifiedResults);
            return result == "" ? "N/A" : result.Trim();
        }

        static void Main()
        {
            int countUntil = Convert.ToInt32(Console.ReadLine());
            int expectedResult = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(BuildOperations(countUntil, expectedResult));
        }

        private static string BuildOperations(int number, int expectedResult, string writeOperation, ref string verifiedResults)
        {
            if (number == 1)
            {
                if (number == expectedResult)
                {
                    verifiedResults += "1 " + writeOperation + "\n";
                    return verifiedResults;
                }

                return "";
            }

            string addWriteOperation = "- " + Convert.ToString(number) + " " + writeOperation;
            string substractWriteOperation = "+ " + Convert.ToString(number) + " " + writeOperation;
            int[] splitExpectedResults = { expectedResult + number, expectedResult - number };
            int addNumber = number - 1;
            BuildOperations(addNumber, splitExpectedResults[0], addWriteOperation, ref verifiedResults);
            BuildOperations(addNumber, splitExpectedResults[1], substractWriteOperation, ref verifiedResults);
            return verifiedResults;
        }
    }
}
