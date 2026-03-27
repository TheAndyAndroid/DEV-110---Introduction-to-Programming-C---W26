/**************************************************************
* Course: DEV 110
* Term: Winter 2026
*
* Programmer: <Andrew Anderson>
* Assignment: <Calculator Lite>
*
* Description:
* <This program acts like basic calculator that performs basic arithmetics such as addition, subtraction,
multiplication, division, modulus, and average. It prompts the user for their name, whether they want to use
decimal precision, and two numbers to operate on. It then displays the results of the calculations with proper formatting.>
*
**************************************************************/

namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        string userName;
        bool useDecimals;
        double number1;
        double number2;

        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"
        Console.Write("Enter your name: ");
        userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}!");

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)
        Console.Write("Use decimal precision? (yes/no): ");
        string decimalInput = Console.ReadLine().ToLower();
        useDecimals = decimalInput == "yes";

        // TODO: Prompt user for first number (double or int based on choice)
        // If decimals: use double.Parse()
        // If no decimals: use int.Parse() then cast to double
        Console.WriteLine("Enter the first number: ");
        if (useDecimals)
        {
            number1 = double.Parse(Console.ReadLine());
        }
        else
        {
            number1 = int.Parse(Console.ReadLine());
        }

        // TODO: Prompt user for second number (same type as first)
        Console.WriteLine("Enter the second number: ");
        if (useDecimals)
        {
            number2 = double.Parse(Console.ReadLine());
        }
        else
        {
            number2 = int.Parse(Console.ReadLine());
        }

        // TODO: Calculate ALL arithmetic operations:
        // - sum (addition: +)
        // - difference (subtraction: -)
        // - product (multiplication: *)
        // - quotient (division: /)
        // - remainder (modulus: %)
        // - average ((num1 + num2) / 2)
        double sum = number1 + number2;
        double difference = number1 - number2;
        double product = number1 * number2;
        double quotient = number1 / number2;
        double remainder = number1 % number2;
        double average = (number1 + number2) / 2;

        // TODO: Display results with proper formatting
        // Show 2 decimal places: {value:F2}
        // Include descriptive labels for each operation
        Console.WriteLine($"\nResults:");
        if (useDecimals)
        {
            Console.WriteLine($"Sum: {number1} + {number2} = {sum:F2}");
            Console.WriteLine($"Difference: {number1} - {number2} = {difference:F2}");
            Console.WriteLine($"Product: {number1} * {number2} = {product:F2}");
            if (number2 == 0)
            {
                Console.WriteLine("Quotient Error: Cannot divide by zero.");
                Console.WriteLine("Remainder Error: Cannot divide by zero.");
            }
            else
            {
                Console.WriteLine($"Quotient: {number1} / {number2} = {quotient:F2}");
                Console.WriteLine($"Remainder: {number1} % {number2} = {remainder:F2}");
            }

            Console.WriteLine($"Average: ({number1} + {number2}) / 2 = {average:F2}");
        }
        else
        {
            Console.WriteLine($"Sum: {number1} + {number2} = {sum:F0}");
            Console.WriteLine($"Difference: {number1} - {number2} = {difference:F0}");
            Console.WriteLine($"Product: {number1} * {number2} = {product:F0}");
            if (number2 == 0)
            {
                Console.WriteLine("Quotient Error: Cannot divide by zero.");
                Console.WriteLine("Remainder Error: Cannot divide by zero.");
            }
            else
            {
                Console.WriteLine($"Quotient: {number1} / {number2} = {quotient:F0}");
                Console.WriteLine($"Remainder: {number1} % {number2} = {remainder:F0}");
            }

            Console.WriteLine($"Average: ({number1} + {number2}) / 2 = {average:F0}");
        }

        // TODO: Check if second number is zero BEFORE dividing
        // Use if statement: if (num2 == 0) { show error } else { calculate }

        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"
        int calculationCount = 6;
        if (number2 == 0)
        {
            calculationCount -= 2; // No division or Remainder
        }

        Console.WriteLine($"\nPerformed {calculationCount} calculations for {userName}!");

        // TODO: Calculate percentage difference
        // Formula: ((num1 - num2) / num1) * 100
        // Display with % symbol
        double percentageDifference = ((number1 - number2) / number1) * 100;
        if (useDecimals)
        {
            if (number1 == 0)
            {
                Console.WriteLine("Percentage Difference Error: Cannot calculate percentage difference when the first number is zero.");
            }
            else
            {
                Console.WriteLine($"Percentage Difference: {percentageDifference:F2}%");
            }
        }
        else
        {
            if (number1 == 0)
            {
                Console.WriteLine("Percentage Difference Error: Cannot calculate percentage difference when the first number is zero.");
            }
            else
            {
                Console.WriteLine($"Percentage Difference: {percentageDifference:F0}%");
            }
        }

        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
