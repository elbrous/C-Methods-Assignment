using System;

public class TextManipulation
{
    // Method 1: Ask the user for a name and return the entered text.
    public static string GetUserText()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Hello, {name}! Please enter some text: ");
        string text = Console.ReadLine();

        return text;
    }

    // Method 2: Ask the user for a word and return it prefixed with a hashtag (#).
    public static string GetHashtagText()
    {
        Console.Write("Please enter a word: ");
        string word = Console.ReadLine();

        string hashtagText = "#" + word;
        return hashtagText;
    }

    // Method 3: Display a message, ask the user for text, and return the entered text.
    public static string GetUserTextWithMessage(string message)
    {
        Console.WriteLine(message);
        string text = Console.ReadLine();
        return text;


    }

    // Method 4: Display a message with string interpolation, ask the user for text, and return it.
    public static string GetUserTextWithInterpolatedMessage(string word)
    {
        string message = $"Please enter a {word}: ";
        Console.Write(message);
        string text = Console.ReadLine();
        return text;
    }

    // Method 5: Combine first name and last name with a comma and space.
    public static string CombineNames(string firstName, string lastName)
    {
        string fullName = $"{lastName}, {firstName}";
        return fullName;
    }

    public static void Main(string[] args)
    {
        // Example usages of the methods:
        string enteredText = GetUserText();
        Console.WriteLine($"You entered: {enteredText}");

        string hashtagText = GetHashtagText();
        Console.WriteLine($"Result: {hashtagText}");

        string textWithMessage = GetUserTextWithMessage("Please enter a number");
        Console.WriteLine($"You entered: {textWithMessage}");

        string textWithInterpolatedMessage = GetUserTextWithInterpolatedMessage("number");
        Console.WriteLine($"You entered: {textWithInterpolatedMessage}");

        string combinedNames = CombineNames("Thomas", "Payne");
        Console.WriteLine($"FullName: {combinedNames}");
    }
}
