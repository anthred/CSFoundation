using System;
using System.Collections.Generic;

namespace HomeWork2.AmountToText
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<long, string> dictTenPowers = new Dictionary<long, string>
            {
                {1000000000, "Billion"},
                {1000000, "Million"},
                //{100000, "HundredThousand"},
                //{10000, "TenThousand"},
                {1000, "Thousand"},
                {100, "Hundred"},
            };

            while (true)
            {
                Console.Write("Enter the amount: ");
                decimal inputAmount = decimal.Parse(Console.ReadLine());

                while (inputAmount > 100)
                {
                    // start with the closest 10th power
                    List<long> listKeys = new List<long>(dictTenPowers.Keys);
                    List<long> listShort = listKeys.FindAll(x => x <= inputAmount);
                    //listShort.Sort();

                    // quotient + currency value
                    Console.Write("{0} {1} ", (int)(inputAmount / listShort[0]), dictTenPowers[listShort[0]]);

                    // save the reminder back
                    inputAmount = inputAmount % listShort[0];
                }

                Console.Write("{0} dollars ", (int)inputAmount);
                Console.WriteLine("and {0} cents ", (int)((inputAmount - Math.Floor(inputAmount)) * 100));

                Console.WriteLine();
            }
        }
    }
}
