using System;

class Program
{
    static void Main()
    {
        Console.Write("Check Number: ");
        string checkNumber = Console.ReadLine();
        int number;

        if (int.TryParse(checkNumber, out number))
            Console.WriteLine("You entered check #{0}", int.TryParse(checkNumber, out number));
        else
            Console.WriteLine("Invalid input. Please try again.");

        Console.WriteLine();
    }


    //static void Main()
    //{
    //    try
    //    {
    //        Console.Write("Check Number: ");
    //        string checkNumber = Console.ReadLine();

    //        Console.WriteLine("You entered check #{0}", int.Parse(checkNumber));
    //    }
    //    catch (FormatException e)
    //    {
    //        Console.WriteLine("Invalid input {0}. Please try again.", e.Message);
    //    }

    //    Console.ReadLine();
    //}
}