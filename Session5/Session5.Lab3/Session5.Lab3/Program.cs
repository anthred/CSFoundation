using System;

class Program
{
    static void Main()
    {

        // start with the given array
        int[] numbers = new int[] { 0, 2, 5, 100, -1, 4, 8, -5 };

        // define the max and min
        int min = numbers[0];
        int max = numbers[0];

        foreach (int x in numbers)
        {
            if (x < min)
            {
                min = x;
            }

            if (x > max)
            {
                max = x;
            }
        }

        Console.WriteLine("The Minimum value is {0}", min);
        Console.WriteLine("The Maximum value is {0}", max);

        Console.ReadLine();
    }
}