using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Determines the letter grade - Exercise2 Project.");

        // Prompt the User to enter their grade percent
        Console.Write("Please enter your grade percent? ");
        string userInput = Console.ReadLine();

        // Convert string to number
        int grade = int.Parse(userInput);

        // Default value for string letter and sign
        string letter = "";
        string sign = "";

        // This math calculation get the last digit of the grade percentage.
        int lastDigit = Math.Abs(grade% 10);

        // Create a if statement to specify if 7, sign
        // will be positive or 3 sign will be negative.
        if (lastDigit == 7)
        {
            sign = "+";
        }
        else if (lastDigit == 3)
        {
            sign = "-";
        }


        // Create a if statement to get the right grade letter.
        if (grade >= 90)
        {
            letter = "A";
            
        }
        else if (grade >= 80)
        {
            letter ="B";
        }
        else if (grade >= 70)
        {
            letter ="C";
        }
        else if (grade >= 60)
        {
            letter ="D";
        }
        else
        {
            letter = "F";
            sign = " ";
        }
        
        // Display the letter and sign if it is positive or negative.
        Console.WriteLine($"Your grade is: {letter}{sign}");
        
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");

        }
        else
        {
            Console.WriteLine("Please try harder next time!");
        }
    }
}