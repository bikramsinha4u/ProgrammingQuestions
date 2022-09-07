using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    class ReverseStringWordByWord
    {
		public static char[] SampleInput()
        {
			var input = "My name is John ".ToCharArray();

			return input;
		}

		public static void GetOutput()
        {
			var output = ReverseWords(SampleInput());
			Console.WriteLine(output);
		}

		public static char[] ReverseWords(char[] input)
		{
			string result = "";

			int endIndex = input.Length - 1;
			for (int i = input.Length - 1; i >= 0; i--)
			{
				int startIndex = i;
				if (input[i] == ' ' || i == 0)
				{
					if(i == 0)
					 startIndex = i;
					else
					 startIndex = i + 1;

					for (int j = startIndex; j <= endIndex; j++)
					{
						result += input[j];
					}

					result += " ";
					endIndex = i-1;
				}		
				
			}

			return result.ToCharArray();
		}

	}
}
