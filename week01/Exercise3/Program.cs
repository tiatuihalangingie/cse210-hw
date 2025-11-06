using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        This program will generate and pick random number. The user will then prompt
        to enter a guess number. The user will kept
        quessing until they guess the magic number. In the meantime,
        there will be a hint if they go higher or lower.
        */

        //Generating a random number

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 100);
        bool playAgain = true;

        //This loop will allow the game to play again.

        while (playAgain)
        {
            int manyGuess = 0;

            //As long as random number keep playing.

            while (true)
            {
                //Prompt user for their guess number and prompt them
                //to keep guessing until they guess the magic number.
            
                Console.Write("What is the magic number? ");
                string ValueInText = Console.ReadLine();

                int guessedNumber = int.Parse(ValueInText);

                if (guessedNumber == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    manyGuess++;

                    Console.WriteLine($"You have {manyGuess} guesses");
                    Console.WriteLine("");

                    Console.WriteLine("Would you like to play again? (yes/no)");
                    string response = Console.ReadLine();


                    if (response == "yes")
                    {
                        playAgain = true;
                    }

                    else
                    {
                        playAgain = false;
                        Console.WriteLine("Thank you for playing. Goodbye!");

                        break;
                    }
                }
                else if (guessedNumber < magicNumber)

                {
                    Console.WriteLine("Higher");
                    manyGuess++;
                }

                else if (guessedNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                    manyGuess++;
                }

            }

        }
    }
}