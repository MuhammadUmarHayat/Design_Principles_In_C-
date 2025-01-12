/*
Scenario:
We need to check if a given number is even or odd. Instead of creating a complex or convoluted solution, we will implement a straightforward one.

*
//without KISS
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        try
        {
            int number = int.Parse(input);

            // Overcomplicated logic
            if (number % 2 == 0)
            {
                if (number != 0 || number == 0)
                {
                    Console.WriteLine("The number is Even.");
                }
            }
            else
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine("The number is Odd.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
//////////////////////////////////////////////////////////////end//////////////////////////////////////////////
////////////////////////////////////////////////With KISS///////////////////////////////////
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            // Simple and clear logic
            Console.WriteLine(number % 2 == 0 ? "The number is Even." : "The number is Odd.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}

