using System;

class Ascii
{
	static void Main()
	{
		Console.Write("Enter a character:");

		// Let the user enter a string and press enter.
		// code here = Console.ReadLine();
		string input = Console.ReadLine();

		// Grab the first character of the string (str[0])
		// code here = str[0];
		char mychar = input[0];

		// Convert the character to an integer to get the ascii value
		// code here = (int)ch;
		int myint = (int)mychar;

		Console.WriteLine("ASCII value of {0} is {1}", mychar, myint);// code here);  // show the ascii value
		Console.ReadLine();
	}
}