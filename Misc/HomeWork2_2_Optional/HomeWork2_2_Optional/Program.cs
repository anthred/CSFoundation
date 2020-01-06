using System;

namespace HomeWork2.FirstCharAlphabetic
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("Enter some text: ");
				string strInput = Console.ReadLine();

				int firstCharAsciiVal = (int)strInput[0];

				// ASCII for Upper case alphabets = 65 to 90
				// ASCII for Lower case alphabets = 97 to 122
				if ((firstCharAsciiVal >= 65 && firstCharAsciiVal <= 90) || (firstCharAsciiVal >= 97 && firstCharAsciiVal <= 122))
				{
					Console.WriteLine("First character of the text is alphabetic");
				}
				else
				{
					Console.WriteLine("First character of the text is not alphabetic");
				}

				Console.WriteLine();
			}
		}
	}
}
