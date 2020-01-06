using System;

namespace HomeWork2.SecondsConverter
{
	class Program
	{
		static void Main(string[] args)
		{
			int numSecondsPerDay = 86400; // 24 * 60 * 60
			int numSecondsPerHour = 3600; // 60 * 60;
			int numSecondsPerMinute = 60;

			while (true)
			{
				Console.Write("Enter the number of seconds: ");
				int numInputSeconds = int.Parse(Console.ReadLine());

				Console.WriteLine("{0} seconds = {1} day(s), {2} hour(s), {3} minute(s) and {4} second(s)",
					numInputSeconds,
					numInputSeconds / numSecondsPerDay,
					(numInputSeconds % numSecondsPerDay) / numSecondsPerHour,
					((numInputSeconds % numSecondsPerDay) % numSecondsPerHour) / numSecondsPerMinute,
					((numInputSeconds % numSecondsPerDay) % numSecondsPerHour) % numSecondsPerMinute
					);

				Console.WriteLine();
			}
		}
	}
}
