using System;
using System.Collections.Generic;

namespace ProgrammingQuestions
{
    public class FrequencyOfArrayElements
    {
        public static void Caller()
        {
            Console.WriteLine("Frequency of array elementts:");
            CountingFrequenciesOfArrayElements(new int[] { 1, 2, 3, 4, 1, 2, 3, 1, 2, 1 });
        }
        public static void CountingFrequenciesOfArrayElements(int[] num)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in num)
            {
                if (dict.ContainsKey(item))
                    dict[item] = ++(dict[item]);
                else
                    dict.Add(item, 1);
            }
            foreach (var item in dict)
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
        }
    }
}
