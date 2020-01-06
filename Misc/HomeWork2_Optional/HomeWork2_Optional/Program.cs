using System;

namespace HomeWork2.NumDaysInMonth
{
	class Program
	{
		public enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

		static void Main(string[] args)
		{
			while (true)
			{
				// Days in a month
				Console.Write("Enter the month number to determine the number of days in that month: ");
				int monthNum = int.Parse(Console.ReadLine());

				if (monthNum >= 1 && monthNum <= 12)
				{
					GetDaysInAMonth((Month)monthNum);
				}
				else
				{
					Console.WriteLine("Invalid input. Please try again.");
				}

				Console.WriteLine();
			}
		}

		static void GetDaysInAMonth(Month month)
		{
			int numDays = 0;

			switch ((int)month)
			{
				case 1: numDays = 31; break; // Jan
				case 2: numDays = 28; break; // Feb (No leap year check)
				case 3: numDays = 31; break; // Mar
				case 4: numDays = 30; break; // Apr
				case 5: numDays = 31; break; // May
				case 6: numDays = 30; break; // Jun
				case 7: numDays = 31; break; // Jul
				case 8: numDays = 31; break; // Aug
				case 9: numDays = 30; break; // Sep
				case 10: numDays = 31; break; // Oct
				case 11: numDays = 30; break; // Nov
				case 12: numDays = 31; break; // Dec
			}

			Console.WriteLine("Number of days in month {0} ({1}) = {2}", (int)month, month, numDays);
		}
	}
}
