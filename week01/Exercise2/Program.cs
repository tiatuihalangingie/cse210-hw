using System;

class Program
{
    static void Main(string[] args)
    {

        /* This program is an IF STATEMENT which will
        determines the letter grade for the user input*/


        // This will prompt the user to enter a
        // their grade percentage. Notice how I 
        // use Console.Write instead .WriteLine,
        // this will not enter new line but continue
        // on the same line.
        Console.Write("Enter your grade percentage: ");
        string ValueInText = Console.ReadLine();

        // This convert string to float number.
        float gradepercent = float.Parse(ValueInText);


        // This arithmetic here will get the last digit
        float LastDigit = gradepercent % 10;

        if (gradepercent >= 90)
        {
            string grade = "A";

            Console.Write($"{grade}");

            if (LastDigit >= 4)
            {
                var sign = "";
                Console.Write($"{sign}");

            }

            else
            {
                Console.Write("-");
            }

        }

        else if (gradepercent >= 80)
        {
            string grade = "B";
            Console.Write($"{grade}");

            if (LastDigit >= 7)
            {
                var sign = "+";
                Console.WriteLine($"{sign}");
            }

            else if (LastDigit <= 3)
            {
                var sign = "-";
                Console.WriteLine($"{sign}");
            }

            else
            {
                var sign = "";
                Console.WriteLine($"{sign}");
            }

        }

        else if (gradepercent >= 70)
        {
            string grade = "C";
            Console.Write($"{grade}");

            if (LastDigit >= 7)
            {
                var sign = "+";
                Console.WriteLine($"{sign}");
            }

            else if (LastDigit <= 3)
            {
                var sign = "-";
                Console.WriteLine($"{sign}");
            }

            else
            {
                var sign = "";
                Console.WriteLine($"{sign}");
            }

        }

        else if (gradepercent >= 60)
        {
            string grade = "D";
            Console.Write($"{grade}");

            if (LastDigit >= 7)
            {
                var sign = "+";
                Console.WriteLine($"{sign}");
            }

            else if (LastDigit <= 3)
            {
                var sign = "-";
                Console.WriteLine($"{sign}");
            }

            else
            {
                var sign = "";
                Console.WriteLine($"{sign}");
            }
        }

        else
        {
            string grade = "F";
            Console.Write($"{grade}");

        }

        // Prompt the user if they pass or not.
        if (gradepercent >= 70)
        {
            Console.WriteLine("");
            Console.WriteLine("Congratulations! You have passed this semester!");
        }

        else
        {
            Console.WriteLine("");
            Console.WriteLine("Sorry, please try again next semester.");

        }

    }

}    
