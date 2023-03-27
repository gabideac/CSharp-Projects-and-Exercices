using System;

namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            string result = HexadecimalConvertor(input);
            Console.WriteLine(result);
        }

        private static string HexadecimalConvertor(int input)
        {
            int remainder = input % 16;
            int number = input / 16;
            string result = ReturnHexadecimal(remainder);
            return HexadecimalConvertor(ref number, ref remainder, ref result);
        }

        private static string HexadecimalConvertor(ref int number, ref int remainder, ref string result)
        {
            const int sixteen = 16;
            if (number == 0)
            {
                return result;
            }

            remainder = number % sixteen;
            number /= sixteen;
            result = ReturnHexadecimal(remainder) + result;
            return HexadecimalConvertor(ref number, ref remainder, ref result);
        }

        static string ReturnHexadecimal(int remainder)
        {
            const string hexadecimals = "0123456789ABCDEF";
            return Convert.ToString(hexadecimals[remainder]);
        }
    }
}
