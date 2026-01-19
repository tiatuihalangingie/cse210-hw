using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guessing number game - Exercise3 Project.");

        // This is a random generator that can pick a random number
        // and let the User guess this random number.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        // This is the default value for guess number.
        int guess = -1;
        int manyGuess = 0;

        // Using while loop to keep reiterate if the user 
        // guess doesn't match the magicNumber.
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
                manyGuess += 1;
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
                manyGuess += 1;
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You have {manyGuess} guessed");

                // This will ask the user if they want to play again
                // if not it well end the game.
                Console.WriteLine("Would you like to play again? Yes/No: ");
                string answer = Console.ReadLine();
            
                if (answer == "Yes")
                {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine()); 

                if (magicNumber > guess)
                    {
                        Console.WriteLine("Higher");
                        manyGuess += 1;
                    }
                else if (magicNumber < guess)
                    {
                    Console.WriteLine("Lower");
                    manyGuess += 1;
                    }
                else
                    {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You have {manyGuess} guessed");

                    }
            }

            else
                {
                Console.WriteLine("Thank you for playing. Have a good day!");
                }
                
            }

        }                    
    }
}   
        
    