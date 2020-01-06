using System;

namespace Session4.HomeWork4.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int factorial = 1;

                Console.Write("Please enter a small integer: ");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                while (number > 1)
                {
                    factorial = factorial * number;
                    number = number - 1;
                }

                Console.WriteLine("{0}! = {1}", input, factorial);
                Console.WriteLine();
            }
        }
    }
}
