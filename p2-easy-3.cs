using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        int upperLimit = 30;

        // Loop from 1 to upperLimit
        for (int i = 1; i <= upperLimit; i++)
        {
            // Check if 'i' is a multiple of any number from 1 to 5
            for (int j = 1; j <= 5; j++)
            {
                if (i % j == 0)
                {
                    sum += i;
                    break; // Prevent adding the same number multiple times
                }
            }
        }

        // Output the result
        Console.WriteLine("The sum of all multiples of 1 to 5 between 1 and 30 is: " + sum);
    }
}
