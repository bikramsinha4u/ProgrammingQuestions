using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingQuestions
{
    internal class NumberOfCurrencyRequired
    {
        public static void Caller()
        {

            var input = new int[] { 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            var n = 3888;
            Console.WriteLine("Number of each currency required:");
            Find(input, n);
        }
        public static void Find(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (n > 0)
                {
                    var quo = n / arr[i];
                    Console.WriteLine("{0}:{1}", arr[i], quo);
                    n = n % arr[i];
                }
            }
        }
    }
}
