using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        // prompt the user for their first name
        Console.Write("What is your first name? ");

        // read the input string from the console
        string firstName = Console.ReadLine();

        // prompt the user for their last name
        Console.Write("What is your last name? ");

        // read the input string from the console
        string lastName = Console.ReadLine();

        // this will create a blank line
        Console.WriteLine();

        // display the user entered string
        Console.WriteLine($"Your name is {lastName}, {firstName}.");

    }


}