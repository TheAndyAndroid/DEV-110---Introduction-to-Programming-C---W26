# Week 2: Calculator Lite - Study Notes

**Name:** Andrew Anderson

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer: `string`: Used to store text. I used it to store the user's name and preference of showing decimal precision.
        `bool`: Used for True or False statements. It's also used for the user's preference of showing decimal precision based on their selection.
        `int`: Used for whole number values. It's used with displaying whole numbers in final calculation and displaying the number of amount of calculations performed.
        `double`: Used for decimal number values as it's more precise than using integers. I also used it for displaying numbers to the second decimal in final calculation.

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: `int` is used for whole numbers while `double` is used for displaying numbers with deciamls. `double` is better for this calculator as it provides the necessary decimal precision for accurate mathematical calculations.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: I converted the string to a boolean by connecting the two. If the user inputs "yes," the boolean is true; otherwise, it is false.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: The hardest part of this assignment was understanding all the different data types and how to effectivly use them togther.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I review the lecture for this week as it was beneficial to help me understand how each data type functions in a program.

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: The most challenging concept was conditional formatting of a boolean using if-else statements, as I did not fully understand how a boolean operates when trying to display an inputted user value in the console.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: Modulus operator (%) calculates the remainder of a division. Ex: 14 % 4 = 2 (14 / 4 = 3 with remainder of 2.)
Division operator (/) performs mathematical division. Ex 14 / 4 = 3.50 (using `double` data type)

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: In order to calculate the average of two numbers, first add the two numbers together and then divide the sum by 2 since there are two numbers. (Ex: 7 + 15 = 22, 22 / 2 = 11)

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: The formula for percentage difference is to subtract the first number from the second number, then divide by the first number, lastly multiply by 100. (Ex: 12 - 5 = 7, 7 / 14 = 0.50, 0.50 * 100 = 50% )

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: `Console.ReadLine()` takes the user's inputted value and returns the input as a string.

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: The parse method I used were int.Parse() which convert the string input into a integer (Number with no decimals) and double.Parse() converts string input into a decimal (Number with decimals).

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: The $ symbol in `Console.WriteLine()` makes it into a interpolated string which allows to swap out the placeholder with the given user inputted value. The curly braces is the placeholder for the variables.

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: :F indicates how many digits should appear after the decimal point. `:F2` format displays results to two decimal places while :F0 only displays whole numbers (no decimals)

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: Dividing by zero typically crashes either your program or your computer. I created an if/else statement to check if the second number is zero. If so, it outputs an error message. Otherwise, it calculates the operation normally.

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: I created an if/else statement based on the user's preference for decimal precision, utilizing the useDecimal Boolean that I implemented. I divided the calculations into two sections: one formatted with :F0 and the other with :F2.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. One thing is that I gained a better understanding of how Booleans operate, as they coincide with if/else statements to determine whether the statement is true or false.
2. Another thing I learned is how to properly format numbers to a specified decimal amount, especially at the end of a calculation.
3. This assignment provided me with valuable insight into how various data types can interact effectively within a single program.
4.
5.

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: I found the Boolean data type most interesting because a lot of variables can be based from a single boolean.

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: It's helpful to let users choose decimal precision so that can get more accrate calculations.

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: I tested postive and negative numbers, decimals, and zero to verify my program works.

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: When attempting to divide by zero, I forgot to include an error message in my if/else statement, which resulted in the default error message appearing instead of a custom error message displayed using `Console.WriteLine` within the console.

## Time Spent

**Total time:** 10.5 hours

**Breakdown:**

-   Understanding data types: 1.5 hours
-   Reading and parsing user input: 1 hour
-   Implementing arithmetic operations: 1.5 hours
-   Adding conditional formatting: 1 hour
-   Handling division by zero: 1 hour
-   Testing and debugging: 2.5 hours
-   Writing documentation: 2 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: The part that took the longest was debugging, as I am still learning the foundational concepts of C#. I hope that in the future, I will be able to write better code and debug it more efficiently, as I will gain more knowledge as I progress in this course.

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: I want to enhance the organization of my code, as I believe it currently lacks clarity and readability. Improving this aspect will contribute to a more effective and efficient workflow.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: This assignment demonstrates how each of the core data types operates within C#. It focuses on debugging any errors we encounter while coding and provides a good understanding of how to format our code. This knowledge will help us build more complex programs for future assignments.
