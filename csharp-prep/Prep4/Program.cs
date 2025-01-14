using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, then type 0 when finished.");

        int number = 0;

        // Initiliaze list to hold values 
        List<int> numbers = new List<int>();

        // Execute body once bfore checking if number = 0
        do {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        } while (number != 0);

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Cannot store as INT --> returns error because average function returns a double (decimal value)
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}