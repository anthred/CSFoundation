using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.ChangeCase
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("Enter a string: ");
				string inputStr = Console.ReadLine();

				char[] chInput = inputStr.ToCharArray();
				for (int i = 0; i < chInput.Length; i++)
				{
					// only text		
					if (Char.IsLetter(chInput[i]))
					{
						// lower to upper
						if (Char.IsLower(chInput[i]))
						{
							chInput[i] = Char.ToUpper(chInput[i]);
							continue;
						}

						// upper to lower
						if (Char.IsUpper(chInput[i]))
						{
							chInput[i] = Char.ToLower(chInput[i]);
							continue;
						}
					}
				}

				Console.WriteLine(new string(chInput));

				Console.WriteLine();
			}
		}
	}
}
