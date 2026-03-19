# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:** Andrew Anderson

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: `File.ReadAllLines` returns a string array, where each element represents a single line from the file. It reads the entire contents of the `habits.csv` file into memory before returning the array. I used this method to read all lines from the `habits.csv` file, and then I processed each line using the provided name, completion status, and frequency strings to create a Habit object.

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: When you split an empty string using `','`, you end up with an array that contains a single empty string element. This results in a blank line that does not contain any relevant data from the CSV file. It's important to skip these blank lines when reading a CSV file to prevent errors, invalid data in your program, and unexpected behavior during parsing.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: `File.WriteAllLines` is a method that creates a new file, writes a collection of strings to it, and then closes the file. If the target file already exists, it is cleared and overwritten. This method takes two arguments: string (path): specifies the relative path to the file where the lines of text will be written, while the string array (lines) accepts a string array or a collection of strings, where each element represents a single line of text to be written to the file.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: The `Select()` method is used to create a single string for each habit. This string combines the Name, a status (either "done" or "pending" based on the condition for IsCompleted), and the Frequency, separated by commas. The reason to call `ToArray()` is to executes the query immediately, process all elements, and store the results in memory.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: `FileNotFoundException` is an exception that is thrown when an attempt to access a file fails because the file does not exist at the specified path. It can occur when an incorrect file path or a misspelling of the file name or type.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: Catching specific exceptions like `FileNotFoundException` is generally preferred over a broad catch (Exception) because a general catch block can hide other, potentially unrelated errors such as `NullPointerException` or `OutOfMemoryError`. By catching only the specific `FileNotFoundException`, you ensure that you are only handling the exact scenario you expect, like a missing file. Using `FileNotFoundException` provides valuable debugging information about unexpected issues, which results in more robust, maintainable, and predictable code.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. One thing I learned is the basic understanding of file input/output (I/O) operations. These operations allow the reading of text files using `File.ReadAllLines` and writing to files using `File.WriteAllLines`. This process ensures that user data is preserved in a separate CSV file, eliminating the need to re-input the data every time the program runs.
2. Another thing I learned is utilizing `FileNotFoundException` for handling errors when accessing a file fails, along with displaying an appropriate error message.
3. The last thing I learned is how to use LINQ's `Count()` method with a predicate to compute grouped statistics, allowing for a summary value to be obtained from a collection instead of creating a new data collection.

**What was the trickiest part of this assignment and how did you work through it?**

Answer: The most challenging aspect of this assignment was understanding the CSV formats, as I had no prior experience with them. However, I gained a clearer understanding thanks to the lecture video and several other websites that helped explain the concepts.

## Time Spent

**Total time:** 7 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 1.5 hours
- Implementing LoadHabits: 1 hours
- Implementing PrintHabits / PrintSummary: 1.5 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 1.5 hours
- Testing and debugging: .5 hours
- Writing study notes: 1 hours

**Most time-consuming part:**

Answer: The most time consuming aspects were understanding the starter code and the CSV format, as well as implementing the AddHabit, UpdateHabits, and SaveHabits functions. I spent extra time reviewing the lecture materials and conducting additional research to better understand the various CSV concepts. This effort helped me effectively implement the different habits and ensure they functioned properly. Additionally, the other sections of code were quite extensive, which contributed to the overall time required to complete the project.
