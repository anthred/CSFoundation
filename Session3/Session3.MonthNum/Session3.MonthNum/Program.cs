// Ask user to input a month number 1, or 2, or 3 for (Jan, Feb, and Mar).
// Then check how many days each month has (say 31, 29, 30 days for each).
// Print the month and the number of days to screen.
// Finish the rest of exercise on your own and include all the months of the year.

using System;

enum eMonthNames
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December,
    unknown
}

enum eMonthDays
{
    January = 31,
    February = 29,
    March = 31,
    April = 30,
    May = 31,
    June = 30,
    July = 31,
    August = 31,
    September = 30,
    October = 31,
    November = 30,
    December = 31,
    unknown = -1
}

class Program
{
    static void Main()
    {
        string monthNumber;

        Console.Write("Please enter a month number (1 to 12): ");
        monthNumber = Console.ReadLine();

        eMonthNames month;
        int daysOfTheMonth = 0;

        switch (monthNumber)

        {
            case "1":
                month = eMonthNames.January;
                daysOfTheMonth = (int) eMonthDays.January;
                break;

            case "2":
                month = eMonthNames.February;
                daysOfTheMonth = (int)eMonthDays.February;
                break;

            case "3":
                month = eMonthNames.March;
                daysOfTheMonth = (int)eMonthDays.March;
                break;

            case "4":
                month = eMonthNames.April;
                daysOfTheMonth = (int)eMonthDays.April; ;
                break;

            case "5":
                month = eMonthNames.May;
                daysOfTheMonth = (int)eMonthDays.May;
                break;

            case "6":
                month = eMonthNames.June;
                daysOfTheMonth = (int)eMonthDays.June;
                break;

            case "7":
                month = eMonthNames.July;
                daysOfTheMonth = (int)eMonthDays.July;
                break;

            case "8":
                month = eMonthNames.August;
                daysOfTheMonth = (int)eMonthDays.August;
                break;

            case "9":
                month = eMonthNames.September;
                daysOfTheMonth = (int)eMonthDays.September;
                break;

            case "10":
                month = eMonthNames.October;
                daysOfTheMonth = (int)eMonthDays.October;
                break;

            case "11":
                month = eMonthNames.November;
                daysOfTheMonth = (int)eMonthDays.November;
                break;

            case "12":
                month = eMonthNames.December;
                daysOfTheMonth = (int)eMonthDays.December;
                break;

            default:
                month = eMonthNames.unknown;
                daysOfTheMonth = -1;
                break;
        }

        Console.WriteLine("The month {0} has {1} days", month, daysOfTheMonth);
        Console.ReadLine();
    }
}