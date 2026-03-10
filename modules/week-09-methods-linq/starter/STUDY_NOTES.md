# Week 9: Score Stats (Methods + LINQ) - Study Notes

**Name:** Andrew Anderson

## Methods and Decomposition

**Why is it helpful to break a program into small methods?**
[Think about readability, testing, and debugging]

Answer: Breaking a program into smaller methods offers several benefits that significantly enhance code management. First, it improves readability, making the code easier to understand. Second, it simplifies testing, as each small method can be tested individually to ensure it performs its specific function correctly. Lastly, this approach streamlines debugging. When an error occurs, it's much easier to identify the source of the problem using a focused approach than to sift through hundreds of lines of code in a single function. Overall, smaller methods help developers process and understand their code more effectively.

## LINQ (Stats + Method Chaining)

**Which LINQ methods did you use for basic statistics?**
[Examples: Min, Max, Average, Count with predicates]

Answer: The LINQ methods I used for the basic statistics in this assignment were `Count` (Counts elements in a sequence), `Min` (Finds the minimum element), `Max` (Finds the maximum element), and `Average` (Computes the average of elements in a sequence).

**Which LINQ methods did you chain together for reports?**
[Examples: Where + OrderByDescending, OrderByDescending + Take]

Answer: The LINQ methods I chained together for the report were `Where` (Filters a sequence based on a predicate) + `OrderByDescending` (Sorts elements in descending order) and `OrderByDescending` + `Take` (Takes a specified number of elements).

**Why is it helpful to put score logic in a class (ScoreReport) instead of keeping everything in Program?**
[Think about organization, reuse, and readability]

Answer: Placing the scoring logic in the `ScoreReport` class rather than in the `Program` class keeps the `Program` cleaner and more readable, as it only calls `ScoreReport` methods instead of handling complex calculations or printing. This allows for easy reuse of the `ScoreReport` class in multiple locations without duplicating logic, making the code more manageable. It also simplifies debugging; if there's an error in the score calculation, I know exactly where to look.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. One thing I learned this week was the fundamentals of LINQ. I explored aggregation LINQ methods, which compute a single value from a collection of values, as well as sorting LINQ methods, which arrange sequences based on one or more properties in either ascending or descending order.
2. Another thing I learned was the importance of using methods to organize code into smaller, reusable pieces. This approach not only helps manage code more effectively by reducing repetition, but it also isolates logic, which can lead to more efficient and faster debugging.
3. The last thing I learned this week is how to use `CultureInfo.InvariantCulture` for operations that require culture independent results. This is particularly useful for formatting and parsing data that will be saved to a file or database, as it ensures consistent data representation across different systems and locales.
4.
5.

**Which concept felt easiest (methods or LINQ) and why?**

Answer: I have found that using methods is easier for me since I have been working with them longer than with LINQ. However, I want to start using LINQ more frequently because it reduces the amount of boilerplate code required for common data operations like filtering, sorting, and grouping. This reduction makes the code easier to read, understand, and maintain.

## Time Spent

**Total time:** 4 hours

**Breakdown:**

- Understanding the starter code: .5 hours
- Implementing the print methods: .5 hours
- LINQ method chaining: .5 hours
- Testing and debugging: 1.25 hour
- Writing documentation: 1.25 hour

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: The sections that took the longest to complete were debugging and writing documentation. In the debugging phase, I encountered difficulties because the tests were very sensitive and not very descriptive when they failed. I had to ensure that my output matched the README prompts exactly. I accidentally typed a semicolon instead of a colon in the line of code that checks if the Threshold is greater than or equal to the Passing Count variable. I mistakenly believed that another piece of code was incorrect, which delayed me in finding my mistake. As for the documentation, I find it to be the least interesting part of the assignment, and I often get distracted while trying to complete it.

## Reflection

**What would you improve next time?**

Answer: For next time, I will compare the expected output to the assignment requirements much closer, so I don't waste time trying to fix such a small issue.

**How did methods make this program easier to work on?**

Answer: Methods made this program easier to work on as they reduced the overall amount of code that I had to write, and it made it easier to debug as I could find the error in a small chunk of code rather than a large one.
