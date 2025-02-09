using System;
using System.Threading;

namespace MindfulnessProgram
{
    /// <summary>
    /// Base class for all mindfulness activities.
    /// Provides shared functionality such as displaying starting/ending messages,
    /// a spinner animation, and a countdown timer.
    /// </summary>
    public class Activity
    {
        // Protected members available to derived classes.
        protected string _name;
        protected string _description;
        protected int _duration; // in seconds

        public Activity(string name, string description, int duration = 0)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }

        // Displays a common starting message and asks for the duration.
        public virtual void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name} Activity.");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.Write("Enter duration in seconds: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int duration))
            {
                _duration = duration;
            }
            else
            {
                _duration = 30; // default duration if invalid input
            }
            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);  // pause for 3 seconds with a spinner animation
        }

        // Displays a common ending message.
        public virtual void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            ShowSpinner(3);
            Console.WriteLine();
            Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
            ShowSpinner(3);
        }

        // Displays a spinner animation for a specified number of seconds.
        public void ShowSpinner(int seconds)
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);
            while (DateTime.Now < endTime)
            {
                Console.Write("|");
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }

        // Shows a simple countdown timer.
        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}
