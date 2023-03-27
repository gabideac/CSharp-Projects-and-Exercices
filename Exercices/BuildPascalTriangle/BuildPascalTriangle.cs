using System;

namespace BuildPascalTriangle
{
    public class Program
    {
        public static string BuildPascalTriangle(int triangleHeight)
        {
            if (triangleHeight < 1)
            {
                return "Numar invalid!";
            }

            string pascalTriangle = "";
            int countLevel = 1;
            int[] line = new int[countLevel];
            return BuildPascalTriangle(triangleHeight, ref countLevel, ref line, ref pascalTriangle);
        }

        static void Main()
        {
            int triangleHeight = Convert.ToInt32(Console.ReadLine());
            string pascalTriangle = BuildPascalTriangle(triangleHeight);
            Console.WriteLine(pascalTriangle);
            Console.ReadLine();
        }

        static string BuildPascalTriangle(int triangleHeight, ref int countLevel, ref int[] line, ref string pascalTriangle)
        {
            int[] previousLine = line;
            line = new int[countLevel];
            const int SecondLevel = 2;
            if (countLevel == triangleHeight)
            {
                if (countLevel == 1)
                {
                    return "1";
                }

                pascalTriangle += TurnIntArrayIntoString(BuildNextLine(previousLine));
                return pascalTriangle;
            }

            if (countLevel == 1)
            {
                line[0] = 1;
            }
            else if (countLevel == SecondLevel)
            {
                line[0] = 1;
                line[1] = 1;
            }
            else
            {
                line = BuildNextLine(previousLine);
            }

            pascalTriangle += TurnIntArrayIntoString(line) + "\n";
            countLevel++;
            return BuildPascalTriangle(triangleHeight, ref countLevel, ref line, ref pascalTriangle);
        }

        static int[] BuildNextLine(int[] previousLine)
        {
            int[] result = new int[previousLine.Length + 1];
            int countElements = 1;
            result = BuildNextLine(previousLine, ref countElements, ref result);
            return result;
        }

        static int[] BuildNextLine(int[] previousLine, ref int countElements, ref int[] result)
        {
            if (countElements == previousLine.Length)
            {
                result[0] = 1;
                result[previousLine.Length] = 1;
                return result;
           }

            result[countElements] = previousLine[countElements - 1] + previousLine[countElements];
            countElements++;
            return BuildNextLine(previousLine, ref countElements, ref result);
        }

        static string TurnIntArrayIntoString(int[] array)
        {
            int countElements = 0;
            string result = "";
            return TurnIntArrayIntoString(array, ref countElements, ref result);
        }

        static string TurnIntArrayIntoString(int[] array, ref int countElements, ref string result)
        {
            if (countElements == array.Length - 1)
            {
                return result += Convert.ToString(array[countElements]);
            }

            result += Convert.ToString(array[countElements]) + " ";
            countElements++;
            return TurnIntArrayIntoString(array, ref countElements, ref result);
        }
    }
}
