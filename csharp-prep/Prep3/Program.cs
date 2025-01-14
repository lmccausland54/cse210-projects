using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // Create a loop that continues until guess is correct
        
        while (guess != magicNumber)
        {
            // Get guess from the user 
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber) {
                Console.WriteLine("Lower");
            }

            else if (guess < magicNumber) {
                Console.WriteLine("Higher");
            }

            else if (guess == magicNumber) {
                Console.WriteLine("You guessed it! ");
            }
        }
        
    }
}