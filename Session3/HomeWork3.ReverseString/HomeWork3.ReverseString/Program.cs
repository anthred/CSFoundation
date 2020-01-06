using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.ReverseString
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("Enter a string: ");
				string inputStr = Console.ReadLine();

				char[] chRevStr = new char[inputStr.Length];

				char[] chInput = inputStr.ToCharArray();
				for (int i = 0; i < chInput.Length; i++)
				{
					chRevStr[i] = chInput[chInput.Length - 1 - i];
				}

				Console.WriteLine(new string(chRevStr));

				Console.WriteLine();
			}
		}
	}
}
