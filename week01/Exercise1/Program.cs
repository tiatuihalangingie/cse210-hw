using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");


        // Prompt User for first name
        Console.Write("What is your first name? ");

        // Variable carry the first name
        string firstName = Console.ReadLine();

        // Prompt the User for the last name.
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Get the first and last name.
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        
        
    
    
    }

}