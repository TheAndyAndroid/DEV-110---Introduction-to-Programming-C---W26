# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:** Andrew Anderson

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer: Parallel arrays are two or more arrays that store related data, where elements at the same index (i) across all arrays constitute a single, logical record. They stay aligned because the same index is used to access or update corresponding data in each array simultaneously. For this case, rosterNames[0] and rosterCredits[0] represent the same student. If the user inputs "Grace" at rosterNames[1], her credits must be at rosterCredits[1].

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: The purpose of the variable named `count` is to store and track a numeric value. We can track the amount of roster slots that are "in use" by using `count` each time I add a new student to the array, until it reaches the set limit of students.

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer: I used `count` in order to count the amount of students that have been added to the array. You loop from 0 to Count-1 because arrays use zero-based indexing, meaning the first element is at index 0. The Count property returns the total number of elements, so the last valid index is one less than the total count.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer: I created the `BuildRosterLines` method, which creates an array of strings that matches the number of students. It fills this array using a for loop, combining each student's name with their credits. In the menu, I used a foreach loop to print each line from the array without needing to use indexes.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer: To sort the roster while keeping the names and credits aligned, I copied the relevant data into a new array called CopyUsedRoster. Then, I used `Array.Sort` to sort the names array, ensuring that the same swap operations were applied to the credits array. This maintained the alignment of the indices between the two arrays.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. One thing I learned this week is that arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value. To declare an array, define the variable type with square brackets such as string[] and int[].
2. Another thing I learned this week is how to print a array using a `for each` loop.
3. The Last thing I learned this week is how to sort array in a specific way for the final result using `Array.Sort()`
4.
5.

**Which loop felt most natural to use and why?**

Answer: Although the `while` loop is feels most natural to me, I'm getting a better understanding on how to use `for` loops since they are used when you want to run a loop a specific amount of times.

## Time Spent

**Total time:** 5 hours

**Breakdown:**

- Planning the arrays/menu: [.5 hours]
- Input validation: [.5 hours]
- Add + print roster features: [1 hours]
- Sorting feature: [1.5 hours]
- Testing and debugging: [.5 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: The sorting feature took me the longest to figure out because I didn't realize at first that I had to use the `Array.Sort` class in order to display the array in a particular way.

## Reflection

**What would you do differently next time?**

Answer: For next time, I would like to get an better understanding of how arrays function from different example before attemping the assignment

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer: I understand that the `for` loop is a general-purpose counting loop that is highly flexible and provides explicit control over the iteration process. It's ideal when you need to perform actions a specific number of times, while the `foreach` loop is designed specifically for iterating through every single element in a collection without needing to manage indices manually.
