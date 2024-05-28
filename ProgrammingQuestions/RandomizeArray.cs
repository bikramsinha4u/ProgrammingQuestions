using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingQuestions
{
    internal class RandomizeArray
    {
        static void ShuffleArray(int[] array)
        {
            Random rand = new Random();
            int n = array.Length;

            for (int i = n - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1); // Generate a random index between 0 and i (inclusive)

                // Swap array[i] with the element at random index
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        public static void Caller()
        {
            int[] array = Enumerable.Range(1, 10).ToArray();
            ShuffleArray(array);

            // Print the shuffled array
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
        }
    }
}
