using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Word Repeater Program");

        // Get the word from the user
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        // Get the number of repetitions from the user
        Console.Write("Enter the number of times to repeat the word: ");
        int times = int.Parse(Console.ReadLine()); // Convert string to integer

        // Check for positive number of times
        if (times < 1)
        {
            Console.WriteLine("Please enter a positive integer for the number of repetitions.");
        }
        else
        {
            // Repeat the word the specified number of times
            string result = String.Concat(Enumerable.Repeat(word + " ", times));

            // Output the result
            Console.WriteLine($"Repeated word: {result.Trim()}");
        }
    }
}
