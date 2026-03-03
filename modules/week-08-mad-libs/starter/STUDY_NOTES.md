# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Andrew Anderson

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer: The `ChooseTemplate` helper method prompts the user to select a template and adds the corresponding questions to an array. The `CollectWords` method iterates through each prompt from the selected template, gathering the user's input and storing it in a word array. The `ReadYesNo` method ensures that the user's answers are valid, accepting only "yes" (y) or "no" (n) responses. The `ReadIntInRange` method validates the user's template choice by checking it against specified minimum and maximum values (1 or 2). The `ReadNonEmptyString` method continues to prompt the user until a non-empty string is provided. The `GenerateStory` method validates that the length of the words array matches the length of the questions array. If the validation is successful, it then calls the `FormatStory` helper method to construct the final story string. The `FormatStory` method takes the input words from the prompts and generates a story based on the selected template.

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: The main method serves as a summary of the program's functionality. Instead of containing a single large block of code that performs many operations, it features a sequence of method calls with descriptive names, such as ChooseTemplate and ReadIntInRange. Helper methods break down complex problems into smaller, manageable parts, which significantly enhance the readability and maintainability of the codebase. This improvement can help reduce the number of bugs or make them easier to fix when they occur.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: StoryTemplate holds the name of the story template, prompts, and the template text, which includes placeholders such as {0} for user input.

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: Using a template made it easier to support two different stories as I'm able to resuse the same code since the input and outpt logic is the same. The only thing that would be different would be the template text.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer: I set a breakpoint at the start of `CollectWords` to observe how the word array was populated by the user's inputs.

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer: Stepping through the code line by line allowed me to see how each user's input was stored in the word array. I learn best by visualizing how each piece of code operates.

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer: I didn't encounter any bugs other than syntax errors for this asignment.

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1. The first thing I learned was how to use a Logger utility class for informational messages, which are stored as structured properties in the terminal rather than as plain string text.
2. Another thing I learned is the purpose of breakpoints and how they pause the execution of a running program at a specific line of code or condition to help identify and fix bugs faster.
3. The last thing I learned is the concept of implementing many helper methods, as they break down complex code into smaller, manageable parts, significantly enhancing readability and maintainability while catching bugs sooner.

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer:

## Time Spent

**Total time:** 9 hours

**Breakdown:**

- Planning structure (methods/classes): [2 hours]
- Input validation: [1 hours]
- Story templates + formatting: [2 hours]
- Testing and debugging: [1 hour]
- Writing documentation: [3 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Writing documentation took me the longest to complete because the automatic test for the study notes kept failing in the key takeaway section. After spending an hour troubleshooting, I've concluded that it is likely caused by a formatting error. However, since the error message isn't very descriptive, I'm unable to determine the correct format.

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: If I had more time, I would like to include additional templates to give the program more variety. I would also like to use the `Console.ForegroundColor` property to change the color of the user input in the final displayed template, highlighting the user's input.

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: Dividing my program into smaller parts helps me identify and fix bugs much faster than sifting through a large chunk of code.
