# Week 5: Guess the Number - Study Notes

**Name:** Andrew Anderson

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A `do-while` loop is best used when you want to execute a block of code at least once, regardless of the initial condition. The condition is checked after the loop's body has been executed, which means that the loop will always run at least once. In contrast, a `while` loop is used when the code block may not need to execute at all if the initial condition is false. In this type of loop, the condition is checked before the body of the loop is executed, so if the condition is false from the start, the loop will not run.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: I utilized a `do-while` loop in the helper method named ReadIntInRange because it prevents the need to duplicate input validation code for maximum values and rounding.

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: I used a `while` loop to ensure the program repeatedly asks for input until the user's guess is correct.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: I used a `for` loop to repeat the game for the number of rounds requested by the user, after which the program would end the game.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: The helper method for input validation is created to centralize validation logic, ensuring consistency and improving readability by reducing code duplication. It avoids repeating code by handling max value checks and rounding in one place, reducing error-prone, repetitive if statements throughout the application.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: I used an `if` statement to check if the value was greater than the max value (10) or less than the min value (100).

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: I used the same `if` statement as above, but with different inputs to account for the number of rounds.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: I used `int.TryParse` along with a boolean to convert the user's input into an integer. This boolean indicates whether the conversion was successful. If the conversion failed and the boolean is set to false, the program informs the user that the input is invalid and prompts them to enter the input again.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: In the if/else logic, if the guess is less than the secret number, the program will display the message "too low." If the guess is greater than the secret number, it will display "too high." The only remaining possibility is that the guess is equal to the secret number, in which case it will display "correct" along with the number of guesses it took.

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: The guess counter increments in the while loop. With each guess made, it adds to the counter and displays the total in a Console.WriteLine() message.

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: Random employs a random number generator algorithm to create a sequence of numbers that seem random. The Next(min, max) method utilizes this internal sequence to return an integer within a specified range, defined by the minimum (min) and maximum (max) values, to generate the secret number.

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: Adding +1 is necessary because it adjusts the upper bound of the range to the next integer after your desired maximum. This ensures that your desired maximum value is included in the generated random numbers. In summary, including +1 allows the maximum value to be part of the final results.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: Negative numbers, decimals, and letters.

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer: I didn't encounter many errors during testing other than the typical syntax errors.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. One thing I learned was how to effectively use different types of loops, such as `while`, `do-while`, and `for`, to make a guessing number game.
2. Another thing I learned is how to create a random integer and track the number of attempts it takes to find it.
3. Last thing I learn is that int.TryParse indicates the success or failure of the conversion with its boolean return value.
4.
5.

**Which loop felt most natural to use and why?**

Answer: The `while` loop felt most natural to me since I understood it the easiest, as it keeps running a block of code as long as a certain condition is true.

## Time Spent

**Total time:** 6 hours

**Breakdown:**

- Planning the loops: [.5 hours]
- Input validation: [1 hours]
- Guessing logic: [1 hours]
- Testing and debugging: [2 hours]
- Writing documentation: [1.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Debugging took me the longest, as I'm still learning how to properly use the different types of loops besides `while`.

## Reflection

**What would you do differently next time?**

Answer: Understand how `do-while` and `for` loops function before trying to implement them without any knowledge.

**How did using three different loop types improve your understanding of repetition?**

Answer: These three different types of loops can simplify repetitive tasks, allowing me to avoid writing the same code multiple times. This reduces complexity and enhances the readability and maintainability of my code.
