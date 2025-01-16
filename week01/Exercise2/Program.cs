using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        // Initialize the letter variable
        string letter = "";

        // Determine the letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge: Add "+" or "-" to the grade
        string sign = "";
        int lastDigit = gradePercentage % 10;

        if (letter == "A")
        {
            // "A+" doesn't exist; only "A" or "A-"
            if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter != "F") // F+ and F- do not exist
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Combine letter grade and sign
        string finalGrade = letter + sign;

        // Display the letter grade
        Console.WriteLine($"Your letter grade is: {finalGrade}");

        // Check if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up, better luck next time!");
        }
    }
}
