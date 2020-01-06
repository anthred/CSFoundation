using System;

class Average
{
    static void Main()
    {
        // define a float for sum
        float sum = 0.0f;

        // define a float for average
        float average = 0.0f;

        // sequentially add the numbers up from 0 to 10

        for (int i = 0; i < 10; i++)
        {
            //ask the user to enter a number
            Console.WriteLine("Enter a number ({0} of {1}): ", i + 1, 10);
            float input = float.Parse(Console.ReadLine());

            //add the given number to the previous
            sum += input;

        }

        // finding the average
        average = sum / 10;
        Console.WriteLine("The average of the given numbers is {0}", average);
        Console.ReadLine();
    }

}