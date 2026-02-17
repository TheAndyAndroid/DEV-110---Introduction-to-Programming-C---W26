/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Andrew Anderson
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO 1: Build a title banner using strings
        // Create variables for:
        // - title: "Text Menu Studio"
        // - subtitle: "Strings + Console Output Patterns"
        // - divider: 48 equals signs (hint: use new string() constructor)
        // Display: divider, title in uppercase, subtitle, divider
        string title = "Text Menu Studio";
        string subtitle = "Strings + Console Output Patterns";
        string divider = new string('=', 48);

        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(subtitle);
        Console.WriteLine(divider);

        int choice = 0;

        // TODO 2: Create a menu loop that repeats until user chooses 6 (Exit)
        // Hint: Use a while loop

        // TODO 3: Print the menu box
        // Required menu option texts (tests check for these):
        // - 1) Greeting Card
        // - 2) Name Tag Formatter
        // - 3) Phrase Analyzer
        // - 4) Fancy Receipt Line
        // - 5) Menu Banner Builder
        // - 6) Exit
        while (choice != 6)
        {
            Console.WriteLine();
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("1) Greeting Card");
            Console.WriteLine("2) Name Tag Formatter");
            Console.WriteLine("3) Phrase Analyzer");
            Console.WriteLine("4) Fancy Receipt Line");
            Console.WriteLine("5) Menu Banner Builder");
            Console.WriteLine("6) Exit");
            Console.WriteLine("+--------------------------------------+");

            // TODO 4: Get menu choice from user
            // Use ReadIntInRange helper with prompt: "Choose an option (1-6): "
            // Range: 1 to 6
            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);
            Console.WriteLine();

            // TODO 5: Use a switch statement to handle each menu option

            // ===== OPTION 1: Greeting Card =====
            // Prompts: "Enter your name: " and "Enter a short message: "
            // Required string operations:
            // - Use Trim() to clean up the name
            // - Use ToUpper() for an uppercase version
            // - Use concatenation OR interpolation for greeting text
            // - Use string.Format() for at least one output line
            // - Display a boxed card with the name, uppercase name, and message
            // Include the word "Message:" in your output
            switch (choice)
            {
                case 1:
                    Console.Write("Enter your name: ");
                    string userName = Console.ReadLine() ?? string.Empty;

                    Console.Write("Enter a short message: ");
                    string userMessage = Console.ReadLine() ?? string.Empty;

                    string trimmedName = userName.Trim();
                    string upperName = trimmedName.ToUpper();

                    string borderStyle = new string('*', 38);

                    Console.WriteLine(borderStyle);
                    Console.WriteLine("Hello, " + trimmedName + "!");
                    Console.WriteLine(string.Format("Uppercase Name: {0}", upperName));
                    Console.WriteLine($"Message: {userMessage}");
                    Console.WriteLine(borderStyle);
                    break;

                // ===== OPTION 2: Name Tag Formatter =====
                // Prompts: "Enter first name: " and "Enter last name: "
                // Required string operations:
                // - Use Trim() on both inputs
                // - Use concatenation to build full name
                // - Use string indexing to get first characters for initials
                // - Use ToUpper() for initials
                // - Use ToLower() for lowercase version
                // Display three things:
                // - Name tag with the full name (include a bracket [)
                // - Initials (use word "Initials:" in label)
                // - Lowercase version (use word "Lowercase:" in label)
                case 2:
                    Console.Write("Enter first name: ");
                    string firstName = (Console.ReadLine() ?? string.Empty).Trim();
                    Console.Write("Enter last name: ");
                    string lastName = (Console.ReadLine() ?? string.Empty).Trim();
                    string fullName = (firstName + " " + lastName).Trim();
                    char firstInitial = firstName.Length > 0 ? char.ToUpper(firstName[0]) : '?';
                    char lastInitial = lastName.Length > 0 ? char.ToUpper(lastName[0]) : '?';
                    string bothInitials = (string.Empty + firstInitial + lastInitial).Trim();
                    string lowercaseName = fullName.ToLower();

                    Console.WriteLine($"Name Tag: {fullName}");
                    Console.WriteLine($"Initials: {bothInitials}");
                    Console.WriteLine($"Lowercase:  {lowercaseName}");
                    break;

                // ===== OPTION 3: Phrase Analyzer =====
                // Prompt: "Enter a phrase: "
                // Required string operations:
                // - Use Trim() on input
                // - Use Length property
                // - Use Contains() to check for letter 'a' (convert to lowercase first)
                // - Use Replace() to change spaces to dashes
                // - Use Split() to break into words
                // - Use string.Join() to create comma-separated list
                // Display: length, contains check, dashed version, and words list
                case 3:
                    Console.Write("Enter a phrase: ");
                    string phrase = (Console.ReadLine() ?? string.Empty).Trim();
                    int lengthPhrase = phrase.Length;
                    bool containsA = phrase.ToLower().Contains('a');
                    string dashedPhrase = phrase.Replace(' ', '-');
                    string[] words = phrase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string wordList = string.Join(", ", words);

                    Console.WriteLine($"Length: {lengthPhrase}");
                    Console.WriteLine($"Contains 'a': {containsA}");
                    Console.WriteLine($"Dashed version: {dashedPhrase}");
                    Console.WriteLine($"Words: {wordList}");
                    break;

                // ===== OPTION 4: Fancy Receipt Line =====
                // Prompts: "Enter item name: ", "Enter price: ", "Enter quantity (1-9): "
                // Use ReadDouble for price and ReadIntInRange for quantity
                // Required:
                // - Calculate total (price * quantity)
                // - Create a receipt table with header row (ITEM, QTY, TOTAL)
                // - Use string.Format() with composite formatting for the data row
                // - Use alignment specifiers (left/right alignment)
                // - Use currency format specifier (:C2) for the total
                case 4:
                    Console.Write("Enter item name: ");
                    string itemName = (Console.ReadLine() ?? string.Empty).Trim();
                    double itemPrice = ReadDouble("Enter price: ");
                    int itemQuantity = ReadIntInRange("Enter quantity (1-9): ", 1, 9);
                    double itemTotal = itemPrice * itemQuantity;

                    Console.WriteLine("=" + new string('=', 38) + "=");
                    Console.WriteLine(string.Format("{0,-20} {1,5} {2,10}", "ITEM:", "QTY:", "TOTAL:"));
                    Console.WriteLine("-" + new string('-', 38) + "-");
                    Console.WriteLine(string.Format("{0,-20} {1,5} {2,10:C2}", itemName, itemQuantity, itemTotal));
                    Console.WriteLine("=" + new string('=', 38) + "=");
                    break;

                // ===== OPTION 5: Menu Banner Builder =====
                // Prompts: "Enter a title: ", "Enter a subtitle: ", "Enter width (30-60): "
                // Use ReadIntInRange for width (min=30, max=60)
                // Required string operations:
                // - Create border line with equals signs (use new string constructor)
                // - Use PadLeft() to center text (formula: (width + text.Length) / 2)
                // - Use ToUpper() on title
                // - Display banner with borders and centered text
                // - Show three alignment examples (centered, left, right)
                case 5:
                    Console.Write("Enter a title: ");
                    string bannerTitle = (Console.ReadLine() ?? string.Empty).Trim().ToUpper();
                    Console.Write("Enter a subtitle: ");
                    string bannerSubtitle = (Console.ReadLine() ?? string.Empty).Trim();
                    int bannerWidth = ReadIntInRange("Enter width (30-60): ", 30, 60);
                    string border = new string('=', bannerWidth);
                    string centeredTitle = bannerTitle.PadLeft((bannerWidth + bannerTitle.Length) / 2);
                    string centeredSubtitle = bannerSubtitle.PadLeft((bannerWidth + bannerSubtitle.Length) / 2);

                    Console.WriteLine(border);
                    Console.WriteLine(centeredTitle);
                    Console.WriteLine(centeredSubtitle);
                    Console.WriteLine(border);

                    // Alignment examples
                    Console.WriteLine("Alignment examples:");
                    Console.WriteLine("Centered: " + bannerTitle.PadLeft((bannerWidth + bannerTitle.Length) / 2));
                    Console.WriteLine("Left-aligned: " + bannerTitle.PadRight(bannerWidth));
                    Console.WriteLine("Right-aligned: " + bannerTitle.PadLeft(bannerWidth));
                    break;

                // ===== OPTION 6: Exit with String Analysis =====
                // Prompt: "Enter a closing word: "
                // Required string operations (demonstrate these 4 methods):
                // - Use Equals() with StringComparison.OrdinalIgnoreCase to compare with "goodbye"
                // - Use Substring() to extract first 3 characters (check length first!)
                // - Use EndsWith() to check if ends with "!"
                // - Use IndexOf() to find position of space character
                // Display the results of all four operations
                // Then print: "Goodbye!"
                case 6:
                    Console.Write("Enter a closing word: ");
                    string closingWord = Console.ReadLine() ?? string.Empty;

                    bool isGoodbye = closingWord.Trim().Equals("goodbye", StringComparison.OrdinalIgnoreCase);
                    string firstThree = closingWord.Length >= 3 ? closingWord.Substring(0, 3) : closingWord;
                    bool endsWithExclamation = closingWord.EndsWith("!");
                    int spaceIndex = closingWord.IndexOf(' ');

                    // IMPORTANT: tests expect 'goodbye' and the first3 in SINGLE QUOTES
                    Console.WriteLine($"Equals 'goodbye': {isGoodbye}");
                    Console.WriteLine($"First 3 characters: '{firstThree}'");
                    Console.WriteLine($"Ends with '!': {endsWithExclamation}");
                    Console.WriteLine($"Index of space: {spaceIndex}");

                    Console.WriteLine("Goodbye!");
                    break;
            }

            // TODO 6: Add a blank line between menu actions (but not after Exit)
            if (choice != 6)
            {
                Console.WriteLine();
            }
        }
    }

    // TODO 7: Implement input validation
    // Use a do-while loop with int.TryParse()
    // Keep prompting until input is valid AND within range
    // Return the valid number
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = int.TryParse(input, out value);
        }
        while (!isValid || value < min || value > max);

        return value;
    }

    // TODO 8: Implement input validation
    // Use a do-while loop with double.TryParse()
    // Keep prompting until input is a valid number
    // Return the valid number
    private static double ReadDouble(string prompt)
    {
        double value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = double.TryParse(input, out value);
        }
        while (!isValid);

        return value;
    }
}
