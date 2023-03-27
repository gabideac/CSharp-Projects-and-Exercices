using System;

namespace DecimalToBinarConvertor
{
    class Program
    {
        static void Main()
        {
            const string forMethods = " 1 2 3 4 5 6 7 8 ";
            const string forComparasions = " 9 10  11 12 ";
            const string forCalculations = " 13 14 15 16";
            string input = Console.ReadLine();
            if (forMethods.Contains(" " + input + " "))
            {
                AssignMethodsForConversionsAndOperators(input);
            }
            else if (forComparasions.Contains(" " + input + " "))
            {
                CompareBinaryNr(input);
            }
            else if (forCalculations.Contains(" " + input + " "))
            {
                AssignMethodsForCalculations(input);
            }
            else
            {
                Console.WriteLine("Operatie invalida.");
            }

            Console.ReadLine();
        }

        static void AssignMethodsForConversionsAndOperators(string input)
        {
            switch (input)
            {
                case "1":
                    ConvertDecimalToBinary();
                    break;
                case "2":
                    ConvertBinaryToDecimal();
                    break;
                case "3":
                    ApplyNotOperator();
                    break;
                case "4":
                    ApplyOrOperator();
                    break;
                case "5":
                    ApplyAndOperator();
                    break;
                case "6":
                    ApplyXorOperator();
                    break;
                case "7":
                    ShiftLeft();
                    break;
                case "8":
                    ShiftRight();
                    break;
            }
        }

        static void AssignMethodsForCalculations(string input)
        {
            switch (input)
            {
                case "13":
                    SumOfTwoBinaryNrs();
                    break;
                case "14":
                    GetGreatestAndLesserNrs("14");
                    break;
                case "15":
                    GetGreatestAndLesserNrs("15");
                    break;
                case "16":
                    CompareBinaryNr("12");
                    break;
            }
        }

        static void ConvertDecimalToBinary()
        {
            string input = Console.ReadLine();
            bool isNumber = CheckCorrectDecimalInput(input);
            if (isNumber)
            {
                int decimalNr = Convert.ToInt32(input);
                if (decimalNr >= 0)
                {
                    const int two = 2;
                    string result = "";
                    int temp;
                    while (decimalNr > 0)
                    {
                        temp = decimalNr % two;
                        result = temp == 1 ? "1" + result : "0" + result;
                        decimalNr = decimalNr / two;
                    }

                    Console.WriteLine(EraseZerosInFront(result));
                }
                else
                {
                    Console.WriteLine("Programul converteste doar numere intregi pozitive.");
                }
            }
            else
            {
                Console.WriteLine("Programul converteste doar numere intregi pozitive.");
            }
        }

        static void ConvertBinaryToDecimal()
        {
           string input = Console.ReadLine();
           bool isBinary = CheckCorrectBinaryInput(input);
           if (isBinary)
           {
                Console.WriteLine(BinaryConvertorToDecimal(input));
           }
            else
            {
                InvalidInput();
            }
        }

        static void ApplyNotOperator()
        {
            char one = Convert.ToChar(49);
            string input = EraseZerosInFront(Console.ReadLine());
            bool isBinary = CheckCorrectBinaryInput(input);
            string inputNOT = "";
            if (isBinary)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    inputNOT += input[i] == one ? 0 : 1;
                }

                Console.WriteLine(EraseZerosInFront(inputNOT));
            }
            else
            {
                InvalidInput();
            }
        }

        static void ApplyOrOperator()
        {
            char one = Convert.ToChar(49);
            string[] inputs = InputTwoBinaryNrsOfSameLaength();
            string firstInput = inputs[0];
            string secondInput = inputs[1];
            string result = "";
            if (CheckCorrectBinaryInput(firstInput) && CheckCorrectBinaryInput(secondInput))
            {
                for (int i = 0; i < firstInput.Length; i++)
                {
                    result += firstInput[i] == one || secondInput[i] == one ? "1" : "0";
                }

                Console.WriteLine(EraseZerosInFront(result));
            }
            else
            {
                InvalidInput();
            }
        }

        static void ApplyAndOperator()
        {
            char zero = Convert.ToChar(48);
            string[] inputs = InputTwoBinaryNrsOfSameLaength();
            string firstInput = inputs[0];
            string secondInput = inputs[1];
            string result = "";
            if (CheckCorrectBinaryInput(firstInput) && CheckCorrectBinaryInput(secondInput))
            {
                for (int i = 0; i < firstInput.Length; i++)
                {
                    result += firstInput[i] == zero || secondInput[i] == zero ? "0" : "1";
                }

                Console.WriteLine(EraseZerosInFront(result));
            }
            else
            {
                InvalidInput();
            }
        }

        static void ApplyXorOperator()
        {
            string[] inputs = InputTwoBinaryNrsOfSameLaength();
            string firstInput = inputs[0];
            string secondInput = inputs[1];
            string result = "";
            if (CheckCorrectBinaryInput(firstInput) && CheckCorrectBinaryInput(secondInput))
            {
               for (int i = 0; i < firstInput.Length; i++)
                {
                    result += firstInput[i] == secondInput[i] ? "0" : "1";
                }

               Console.WriteLine(EraseZerosInFront(result));
            }
            else
            {
                InvalidInput();
            }
        }

        static void ShiftLeft()
        {
            string binaryNr = Console.ReadLine();
            string shifts = Console.ReadLine();
            if (!CheckCorrectDecimalInput(shifts) || Convert.ToInt32(shifts) < 0)
            {
                Console.WriteLine("Numarul de pozitii trebuie sa fie intreg si pozitiv.");
            }
            else if (!CheckCorrectBinaryInput(binaryNr))
            {
                InvalidInput();
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(shifts); i++)
                {
                    binaryNr += "0";
                }

                Console.WriteLine(binaryNr);
            }
        }

        static void ShiftRight()
        {
            string binaryNr = Console.ReadLine();
            string shifts = Console.ReadLine();
            string result = "";
            if (!CheckCorrectDecimalInput(shifts) || Convert.ToInt32(shifts) < 0)
            {
                Console.WriteLine("Numarul de pozitii trebuie sa fie intreg si pozitiv.");
            }
            else if (!CheckCorrectBinaryInput(binaryNr))
            {
                InvalidInput();
            }
            else
            {
                if (Convert.ToInt32(shifts) < binaryNr.Length)
                {
                    for (int i = 0; i < binaryNr.Length - Convert.ToInt32(shifts); i++)
                    {
                        result += binaryNr[i];
                    }

                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }

        static void CompareBinaryNr(string input)
        {
            string[] inpusts = InputTwoBinaryNrsOfSameLaength();
            string firstNr = inpusts[0];
            string secondNr = inpusts[1];
            if (CheckCorrectBinaryInput(firstNr) && CheckCorrectBinaryInput(secondNr))
            {
                switch (input)
                {
                    case "9":
                        Console.WriteLine(CompareTwoBinaryNrs(firstNr, secondNr));
                        break;
                    case "10":
                        Console.WriteLine(CompareTwoBinaryNrs(secondNr, firstNr));
                        break;
                    case "11":
                        Console.WriteLine(CheckIfBinaryNrsAreEqual(firstNr, secondNr));
                        break;
                    case "12":
                        Console.WriteLine(!CheckIfBinaryNrsAreEqual(firstNr, secondNr));
                        break;
                }
            }
            else
            {
                InvalidInput();
            }
        }

        static void SumOfTwoBinaryNrs()
        {
            string[] inputs = InputTwoBinaryNrsOfSameLaength();
            string firstNr = inputs[0];
            string secondNr = inputs[1];
            if (CheckCorrectBinaryInput(firstNr) && CheckCorrectBinaryInput(secondNr))
            {
               string result = AddTwoBinaryNrs(firstNr, secondNr);
               Console.WriteLine(result);
            }
            else
            {
                InvalidInput();
            }
        }

        static void GetGreatestAndLesserNrs(string call)
            {
            string[] inputs = InputTwoBinaryNrsOfSameLaength();
            string greaterNr = "";
            string lesserNr = "";
            if (CheckCorrectBinaryInput(inputs[0]) && CheckCorrectBinaryInput(inputs[1]))
            {
                if (!CheckIfBinaryNrsAreEqual(inputs[0], inputs[1]))
                {
                    if (CompareTwoBinaryNrs(inputs[0], inputs[1]))
                    {
                        lesserNr = inputs[0];
                        greaterNr = inputs[1];
                    }
                    else
                    {
                        lesserNr = inputs[1];
                        greaterNr = inputs[0];
                    }
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
            else
            {
                InvalidInput();
            }

            if (lesserNr == "" || greaterNr == "")
            {
                return;
            }

            switch (call)
            {
                case "14":
                    SubstractBinaryNrs(greaterNr, lesserNr);
                    break;
                case "15":
                    MultiplyBinaryNrs(greaterNr, lesserNr);
                    break;
                case "16":
                    DivideBinaryNrs(greaterNr, lesserNr);
                    break;
            }
        }

        static void SubstractBinaryNrs(string greaterNr, string lesserNr)
        {
            const sbyte minusTwo = -2;
            byte rest = 0;
            string digit = "";
            string result = "";
            for (int i = greaterNr.Length - 1; i >= 0; i--)
            {
                int res = (Convert.ToSByte(greaterNr[i]) - 48) - (Convert.ToSByte(lesserNr[i]) - 48) - rest;
                if (res == -1)
                {
                    digit = "1";
                    rest = 1;
                }
                else if (res == minusTwo)
                {
                    digit = "0";
                    rest = 1;
                }
                else
                {
                    digit = Convert.ToString(res);
                    rest = 0;
                }

                result = digit + result;
            }

            Console.WriteLine(EraseZerosInFront(result));
        }

        static void MultiplyBinaryNrs(string greaterNr, string lesserNr)
        {
            string result = "0";
            for (int i = 0; i < BinaryConvertorToDecimal(lesserNr); i++)
            {
                string[] components = SameLengthBinaryNrs(result, greaterNr);
                result = AddTwoBinaryNrs(components[0], components[1]);
            }

            Console.WriteLine(EraseZerosInFront(result));
        }

        static bool CheckCorrectDecimalInput(string input)
        {
            bool result = true;
            const string digits = "0123456789";
            for (int i = 0; i < input.Length; i++)
            {
               if (!digits.Contains(input[i]))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        static bool CheckCorrectBinaryInput(string input)
        {
            bool result = true;
            const string digits = "01";
            for (int i = 0; i < input.Length; i++)
            {
                if (!digits.Contains(input[i]))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        static string EraseZerosInFront(string binaryInput)
        {
            char zero = Convert.ToChar(48);
            char[] charInput = binaryInput.ToCharArray();
            string changedBinaryNr = binaryInput;
            for (int i = 0; i < binaryInput.Length; i++)
            {
                if (charInput[i] == zero && changedBinaryNr.Length > 1)
                {
                    changedBinaryNr = changedBinaryNr.Substring(1);
                }
                else
                {
                    break;
                }
            }

            return changedBinaryNr;
        }

        static string[] InputTwoBinaryNrsOfSameLaength()
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            return SameLengthBinaryNrs(firstInput, secondInput);
        }

        static void InvalidInput()
        {
            Console.WriteLine("Nu s-a introdus un numar binar valid (format doar din 0 si 1).");
        }

        static string[] SameLengthBinaryNrs(string firstInput, string secondInput)
        {
            int diff = 0;
            int i = 0;
            if (firstInput.Length < secondInput.Length)
            {
                diff = secondInput.Length - firstInput.Length;
                for (i = 0; i < diff; i++)
                {
                    firstInput = "0" + firstInput;
                }
            }
            else if (firstInput.Length > secondInput.Length)
            {
                diff = firstInput.Length - secondInput.Length;
                for (i = 0; i < diff; i++)
                {
                    secondInput = "0" + secondInput;
                }
            }

            return new[] { firstInput, secondInput };
        }

        static double BinaryConvertorToDecimal(string input)
        {
            double result = 0;
            int index = 0;
            const int two = 2;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int temp = input[index] == 49 ? 1 : 0;
                double powedTwo = Math.Pow(two, i);
                result += temp * powedTwo;
                index++;
            }

            return result;
        }

        static bool CompareTwoBinaryNrs(string num1, string num2)
        {
            int index = 0;
            bool result = false;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                if (num1[index] != num2[index])
                {
                    result = Convert.ToByte(num1[index]) < Convert.ToByte(num2[index]);
                    break;
                }

                index++;
                if (index == num1.Length)
                {
                    return result;
                }
            }

            return result;
        }

        static bool CheckIfBinaryNrsAreEqual(string num1, string num2)
        {
            int count = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] == num2[i])
                {
                    count++;
                }
            }

            return count == num1.Length;
        }

        static string AddTwoBinaryNrs(string firstNr, string secondNr)
        {
            const byte two = 2;
            int rest = 0;
            string digit;
            string result = "";
            for (int i = firstNr.Length - 1; i >= 0; i--)
            {
                int res = (Convert.ToByte(firstNr[i]) - 48) + (Convert.ToByte(secondNr[i]) - 48) + rest;
                if (res == two)
                {
                    digit = "0";
                    rest = 1;
                }
                else if (res == two + 1)
                {
                    digit = "1";
                    rest = 1;
                }
                else
                {
                    digit = Convert.ToString(res);
                    rest = 0;
                }

                result = digit + result;
            }

            result = rest == 1 ? "1" + result : "0" + result;

            return result;
        }
    }
}
