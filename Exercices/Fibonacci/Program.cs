using System;

namespace Fibonacci
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int previous = 0;
            return Fibonacci(n, ref previous);
        }

        public static int Fibonacci(int n, ref int previous)
        {
            const byte two = 2;
            if (n < two)
            {
                return n;
            }

            int beforePrevious = 0;
            previous = Fibonacci(n - 1, ref beforePrevious);
            return previous + beforePrevious;
        }

        static void Main()
        {
            int input = Fibonacci(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(input);
        }
    }
}
