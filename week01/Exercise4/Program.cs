using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        /*Creating a list and prompt the users
        add numbers to the list*/
        List<int> numbers = new List<int>();

        // Set a default value for number
        int inputnumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (inputnumber != 0)
        {
            Console.Write("Enter a number: ");

            string userInput = Console.ReadLine();
            inputnumber = int.Parse(userInput);


            if (inputnumber != 0)
            {
                numbers.Add(inputnumber);
            }
        }       
                
        // Step One: Calculate the total sum of the list.
        // We will first get a default value for sum.

        int sum = 0;

        // Now we can use foreach loop to loop through
        // the list of numbers and add all the numbers.
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        // Step two: Caluculate the average numbers
        // in the list.

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"Average: {average}");

        // Step three: Getting the largest number.
        // If we want the largest number we can set the 
        // default to the smallest number and then we can use
        // the foreach loop to loop through this list and get 
        // the largest number.

        int largestNum = -1;

        foreach (int number in numbers)
        {
            if (number > largestNum)
            {
                largestNum = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNum}");

        // Step 4: Getting the smallest positive
        // number. I will use the foreach loop
        // to loop through the list and get the 
        // the smallest positive number.

        int smallestPostiveNum = 9999;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPostiveNum)
            {
                smallestPostiveNum = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPostiveNum}");


        // Step 5: Sorting the list. 
        // Using foreach loop to loop through and sort the numbers
        // in the list.

        Console.WriteLine("The sorted list is:");

        numbers.Sort();
        foreach (int number in numbers)
        {

           Console.WriteLine(number);

        }

    }
}