using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumDigits = 0;

            while (true)
            {
                Console.Write("Enter a number: ");
                int inputNum = int.Parse(Console.ReadLine());

                while (inputNum > 0)
                {
                    sumDigits = sumDigits + (inputNum % 10);
                    inputNum = inputNum / 10;
                }

                Console.WriteLine("Sum of digits = {0}", inputNum, sumDigits);

                Console.WriteLine();
            }
        }
    }
}
