using System;

namespace JSONValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = System.IO.File.ReadAllText(args[0]);
            var jsonValue = new Value();
            var match = jsonValue.Match(file);
            Console.WriteLine(match.Succes() && match.RemainingText() == string.Empty ? "File is valid JSON" : "File is invalid JSON");
            Console.ReadLine();
        }
    }
}
