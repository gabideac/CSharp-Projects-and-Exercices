using System;

namespace FactorialRecursiv
{
    class Program
    {
        private static double Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }

        static void Main()
        {
            Console.WriteLine(Factorial(Convert.ToInt32(Console.ReadLine())));
        }
    }
}
