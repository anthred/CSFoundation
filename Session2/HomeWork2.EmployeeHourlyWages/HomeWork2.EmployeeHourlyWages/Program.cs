using System;

namespace HomeWork2.EmployeeHourlyWages
{
    class Program
    {
        static void Main(string[] args)
        {
            const int constHoursPerWeek = 40;
            int regularHours;
            int overtimeHours = 0;

            decimal weeklyPayRegular;
            decimal weeklyPayOvertime = 0.00M;

            while (true)
            {
                Console.Write("Enter the number of hours worked for this week: ");
                int inputWeekHoursWorked = int.Parse(Console.ReadLine());

                Console.Write("Enter the hourly wage: ");
                decimal inputHourlyWage = decimal.Parse(Console.ReadLine());

                if (inputWeekHoursWorked > constHoursPerWeek)
                {
                    weeklyPayOvertime = (inputWeekHoursWorked - constHoursPerWeek) * (inputHourlyWage * 1.5M);
                    overtimeHours = inputWeekHoursWorked - constHoursPerWeek;

                    inputWeekHoursWorked = constHoursPerWeek;
                }

                weeklyPayRegular = inputWeekHoursWorked * inputHourlyWage;
                regularHours = inputWeekHoursWorked;

                Console.WriteLine("Weekly pay = {0:C}", (weeklyPayRegular + weeklyPayOvertime));
                Console.WriteLine("[{0} regular hour(s) = {1:C}, {2} overtime hour(s) = {3:C}]",
                    regularHours,
                    weeklyPayRegular,
                    overtimeHours,
                    weeklyPayOvertime
                );

                Console.WriteLine();
            }
        }
    }
}
