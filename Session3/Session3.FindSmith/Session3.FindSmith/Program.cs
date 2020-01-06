// File: Find a typed last name Smith
using System;

class Lastname
{
	static void Main()
	{
		Console.Write("Enter a person's full name: ");
		string str = Console.ReadLine();

		if (str.Trim().ToUpper().EndsWith(" SMITH"))
		{
			Console.WriteLine("Found a Smith");
		}
		else
		{
			Console.WriteLine("Did not find a Smith");
		}

		Console.ReadLine();
	}
}