using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("List and Generic - Exercise4 Project.");


        // Created new list of numbers.
         List<int> numbers = new List<int>();
        
        // Default value for guestNumber
        int guestNumber = -1;
        while (guestNumber!= 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userInput = Console.ReadLine();
            guestNumber= int.Parse(userInput);

            
            // If guestNumber is not equal to 0 then append it to the list.
            if (guestNumber!= 0)
            {
                // Process of adding guestNumber to the numbers list.
                numbers.Add(guestNumber);
            }
        }

        //1. GET THE SUM.
        // Use foreach to add each number in the list.
        // Get a default value for sum.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");



        //2. GET THE AVERAGE.
        // To get the average it is a must to use float since
        // the number will use decimal point.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");



        //3. GET THE Maximum NUMBER.
        // Use foreach loop to loop through to get the largeNumimum number.
        int largeNum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largeNum)
            {
                // if this number is greater than the largeNum, we have found the new largeNum!
                largeNum = number;
            }
        }

        Console.WriteLine($"The largest number is: {largeNum}");



        //4. GET THE SMALLEST POSITIVE NUMBER.
        // Use foreach loop to loop through to get the smallest 
        // positive number.
        int smallestNum = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number < smallestNum && number > 0)
            {
                // if this number is smaller than the
                //  smallestNum, we have found the new 
                // smallestNum!
                smallestNum = number;

            }
        }

        Console.WriteLine($"The smallest positive number is: {smallestNum}");


        //5. Sorting the numbers in the list.
        Console.WriteLine("The sorted list is:");

        // This code reverse and sorting the list of numbers.
        
        numbers.Reverse();
        numbers.Sort();
        
        foreach (int sortNumber in numbers)
        Console.WriteLine(sortNumber);
        




    }
}
    