# Week 3: Personal Profile Card - Study Notes

**Name:** Andrew Anderson

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer: `string`: Stores text. I used strings for user's full name, favorite color, Major, and several other attributes.
`int`: Stores whole numbers. I used integers for Graduation year, favorite number, height in feet, and age.
`double`: Stores numbers with decimal values. I used double for height in inches and GPA.
`bool`: Stores true or false values. I used a boolean for deciding if the user is full-time or part-time
and if user's in honor role, based on GPA is equal to or higher than 3.5.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: I used `double` for GPA instead of `int` since `double` displays numbers with decimals, and GPA often uses
decimals for more precise academic measurement.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: I made it that so if the user input yes, then it would make the boolean true, which will display Full-Time Student.
Otherwise, it would make it false, displaying Part-Time Student.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: I grouped certain pieces of information together into separate groups, such as personal, academic, and
calculated statistics, so that the information is clear to read and understand.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: I calculated birth years, years to graduation, height conversion, honor status, and age in months in the program
rather than asking the user to manually calculate it themselves.

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: It's more efficient to calculate the birth year from age instead of asking for both, as this saves time and
simplifies the program's code.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: The biggest challenge that I encountered during this assignment was getting the full-time or part-time
boolean to work properly.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: I used this week's lecture videos and last week's assignment as a refresher on how to create a simple if/else
boolean statement based on a yes or no input.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: I want to gain more hands-on experience using booleans, especially with more complex if/else statements,
as I am not yet confident in my ability to use them effectively in a timely manner.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: The way to convert a string input to a number is by using Parse. `int.Parse()` is used for displaying whole numbers
and `double.Parse()` is used for numbers with decimals.

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: When the user inputs their total height in inches, the program takes that input and divides it by 12 to
produce the number of feet (feet = inches / 12). Then the remaining number of inches gets displayed from completing a modulo
operation from number of total inches modulo by 12 ( remaining = inches % 12).

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: If the user's input value for GPA is greater than or equal to 3.5, then their honor student status will display
TRUE, otherwise it will display FALSE.

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: :F indicates how many digits should appear after the decimal point. `:F2` format at the end of GPA will display
the results to two decimal places.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: I used a conditional boolean with a simple if/else statement, so if the boolean made true, it would display as
full-time student, otherwise it would display part-time student.

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I used Section headers, included some spacing between each section, alligned each output as much as I could
so the final results could look organized and easy to read.

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: The number of days until the next birthday and the homework completion rate to determine percent of homework assignments
turned in could be interesting calculated fields to include in the profile.

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: It's important to choose the right data type to ensure memory efficiency, performance optimization,
data integrity, and the prevention of common programming errors like overflow and precision loss.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: Since this profile card displays personal information based on their inputs, it can be used for real-world
applications such as social media profiles, job applications, and a student record system.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. The first thing I learned is that before you are able to do any type of calculations, you must convert the user input to the correct type using Parse.
2. Another thing I learned is that it's important to utilize spacing and section headers so that the final output can be easy to read and understand.
3. The last thing I learned is the ability to take a real-world scenario and implement it into a C# program.
4.
5.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: Bool is the most challenging to work with since many variables coincide with it. I understand
how a Boolean operates with a basic true or false system, but I would like to get more practice using if/else statements
in the future.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: Having a solid grasp of data types allows you to write code that is more efficient, robust, readable, and
less prone to runtime errors.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: When the program asked for a numerical value, I tested decimal and whole numbers.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: When I was trying to display the Height as Feet with remaining inches when the user only inputs the height in
inches, I made the feet variable `double` rather than `int`, which displayed a decimal for feet rather than a whole number.

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: To test GPA, I used values both above and below 3.5 to ensure that the boolean results displayed correctly. For height, I used decimal values to verify that feet were displayed as an integer while inches appeared as a decimal.

## Time Spent

**Total time:** 7 hours

**Breakdown:**

-   Understanding data types and planning variables: [.5 hours]
-   Collecting user input with correct types: [.5 hours]
-   Implementing calculations: [.5 hours]
-   Formatting output: [1 hours]
-   Testing and debugging: [1.5 hours]
-   Writing documentation: [3 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Writing documentation took me the longest since I find it to be the least enjoyable part when attempting these
assignments, and it just takes me some time answering each question.

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: If I had to start over, I would like to add additional information, such as the number of days until next
birthday and homework completion rate.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: Proper data modeling establishes a clear, standardized structure for data, which reduces errors, streamlines
updates, and improves system scalability.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: I would like to model a game character using different sections, such as the profile card, such as characteristic's
of the character (character name and build), and different stats (health, damage, stamina).
