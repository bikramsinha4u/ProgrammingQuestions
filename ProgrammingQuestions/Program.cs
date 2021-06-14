using System;

namespace ProgrammingQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleNumber2 singleNumber2 = new SingleNumber2();
            int singleNumberOutput = singleNumber2.SingleNumber(singleNumber2.InputArray);
            Console.WriteLine($"singleNumberOutput: {singleNumberOutput}");

            Console.ReadKey();
        }
    }
}
