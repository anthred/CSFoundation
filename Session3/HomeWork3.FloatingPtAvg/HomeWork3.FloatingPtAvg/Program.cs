using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.FloatingPtAvg
{
	class Program
	{
		static void Main(string[] args)
		{
			float flResult = 0.0f;

			Console.Write("Enter floating point numbers (separated by space): ");
			string strInput = Console.ReadLine();

			string[] strSplit = strInput.Split();
			for (int i = 0; i < strSplit.Length; i++)
			{
				flResult = flResult + float.Parse(strSplit[i]);
			}

			Console.WriteLine(flResult / (strSplit.Length));

			Console.WriteLine();
		}
	}
}
