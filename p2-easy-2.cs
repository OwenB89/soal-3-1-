using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        
        // Getting first number
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        
        // Getting second number
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        // Getting the operation
        Console.Write("Enter the operation (+, -, *, /): ");
        char operation = Console.ReadLine()[0];
        
        double result;
        bool isValidOperation = true;

        // Performing the operation based on user input
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                // Check for division by zero
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                    isValidOperation = false;
                    result = 0;
                }
                break;
            default:
                Console.WriteLine("Invalid operation!");
                isValidOperation = false;
                result = 0;
                break;
        }

        // Outputting the result
        if (isValidOperation)
        {
            Console.WriteLine($"Result: {result}");
        }
    }
}
