using System;

class Program
{
    // The start button for this program.
    // Without this button this program won't start.
    static void Main(string[] args)
    {
        // Call the methods that print, 
        // asks for the name,favorite number, method that squares
        // the favorite number and display the message to the user.
        DisplayMessage();

       
        // Store the returned name in a variable called 'name'.
        string name = PromptUserName();

        
        // Store the returned number in a variable called 'favoriteNumber'.
        int favoriteNumber = PromptUserNumber();

        
        // Store the result in a variable called 'square'.
        int square = SquareNumber(favoriteNumber);

        // Call the method that displays the final message to the user.
        DisplayResult(name, square);
    }

    // Display the program message.
    static void DisplayMessage()
    {
        Console.WriteLine("Function - Exercise 5 of week 1");
        Console.WriteLine("Welcome to the program");
       
    }

    // Ask for the User names and return it to the main method.
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");

        
        string name = Console.ReadLine();

        
        return name;
    }

    // Ask for the favorite number and return it to the main method.
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");

        // Convert user response(string) to interger.
        int favoriteNumber = int.Parse(Console.ReadLine());

        
        return favoriteNumber;
    }

    // Take the user number(favorite number) and return it as square.
    static int SquareNumber(int favoriteNumber)
    {
        // Calculate to get the square number.
        int square = favoriteNumber * favoriteNumber;

        
        return square;
    }

    // This method displays the final result using the user's name and the squared number.
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {square}");
    }
}

