# Week 6: Text Menu App - Study Notes

**Name:** Andrew Anderson

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A `do-while` loop is best used when you want to execute a block of code at least once, regardless of the initial condition. The condition is checked after the loop's body has been executed, which means that the loop will always run at least once. In contrast, a `while` loop is used when the code block may not need to execute at all if the initial condition is false. In this type of loop, the condition is checked before the body of the loop is executed, so if the condition is false from the start, the loop will not run.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: I utilized a `do-while` loop for the validation helper methods. Essentially, it will keep prompting the user for valid input within the specified range of 1 to 6.

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: I created a `while` loop for the menu system. After the user makes a selection and follows the prompts, the menu will keep looping until the user enters option 6. This will terminate the loop and close the menu after the user inputs a goodbye phrase.

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: I didn't need to use a `for` loop because this program doesn't require looping a fixed number of times. It wouldn't be ideal to have a menu system that allows interaction only a few times before closing.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: I created a helper method for input validation to improve readability and reduce code duplication. Instead of repeating the same block of code for each prompt, I can simply call the helper method. This makes the overall code more straightforward and easier to read.

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: To ensure the menu choice remains within the range of 1 to 6, I utilized the helper method `ReadIntInRange`, setting the minimum value to 1 and the maximum value to 6. I then implemented a `do-while` loop to validate the user's input. If the input falls outside of this range, the program will continuously prompt the user until a valid input is provided.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: I used `int.TryParse` and `double.TryParse` to convert the user's input into a number, ensuring it falls within the specified minimum and maximum values. If the user inputs a non-numeric value or a number outside the allowed range, the helper method will return false. As a result, the system will prompt the user again until it receives valid input.

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: I used methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, Equals, Substring, EndsWith, IndexOf, and formatting techniques such as interpolation, String.Format, and :C2 for displaying currency.

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: The `Equals()` method, when used with `StringComparison`, is utilized to compare a given word with "goodbye" without considering case sensitivity. The `Substring` method starts at a specified character position and extracts a specified length of characters; in this case, I used it to display the first three letters of the closing word. The `EndsWith` method checks if the closing word contains an exclamation mark ("!"). Lastly, the `IndexOf` method determines the position of the space within the closing word

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: String concatenation manually joins strings using the "+" operator, whereas string interpolation offers a more readable, built-in syntax by utilizing "$" to embed variables and expressions directly within a string literal. While I find string concatenation easier to use, I want to develop the better habit of using interpolation, as it simplifies the overall code and makes it easier to understand.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. One thing I learned this week is how to utilize loops that I already had a basic understanding of to create a few new scenarios. For example, I implemented a `while` loop to develop a repeating menu and a `do-while` loop to ensure correct input validation for that menu.
2. Another thing I learned is how to format strings using various techniques, such as EndsWith, IndexOf, and a better understanding of string interpolation.
3. The last thing I learned is how to effectively use TryParse to handle invalid inputs for non-numbers within a given minimum and maximum value.
4.
5.

**Which loop felt most natural to use and why?**

Answer: `While` loops felt most natural to use since they are the simplest to use, as it repeatedly executes a block of code as long as a specified Boolean condition remains true.

## Time Spent

**Total time:** 9 hours

**Breakdown:**

- Planning the loops: [1 hours]
- Input validation: [1 hours]
- String formatting: [3 hours]
- Testing and debugging: [3 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: String formatting, as well as testing and debugging, took the longest time because the tests were not providing a detailed report on why the string formatting was failing. As a result, I had to rewrite my code from scratch and seek additional help from online sources to find the error and get it to work properly.

## Reflection

**What would you do differently next time?**

Answer: In the future, I will test more frequently instead of waiting until the end while coding to reduce the time I spend debugging.

**How did using three different loop types improve your understanding of repetition?**

Answer: Using three different loop types allows me to gain a better understanding of loops in general and how to effectively use them for different scenarios.
