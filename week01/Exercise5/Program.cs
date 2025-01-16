using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Call DisplayWelcome
        DisplayWelcome();

        // Step 2: Get the user's name
        string userName = PromptUserName();

        // Step 3: Get the user's favorite number
        int userNumber = PromptUserNumber();

        // Step 4: Compute the square of the number
        int squaredNumber = SquareNumber(userNumber);

        // Step 5: Display the result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt for and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt for and return the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to compute the square of a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
