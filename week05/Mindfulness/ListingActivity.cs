using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    /// <summary>
    /// The ListingActivity lets the user list as many items as possible in response to a prompt.
    /// </summary>
    public class ListingActivity : Activity
    {
        private List<string> _prompts;

        public ListingActivity()
            : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _prompts = new List<string>()
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        }

        public void Run()
        {
            DisplayStartingMessage();

            // Choose and display a random prompt.
            Random random = new Random();
            int promptIndex = random.Next(_prompts.Count);
            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {_prompts[promptIndex]} ---");
            Console.WriteLine("You may begin in:");
            ShowCountDown(5); // 5-second countdown before starting
            Console.WriteLine();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            int count = 0;

            // Continue getting user responses until the time is up.
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(response))
                {
                    count++;
                }
            }
            Console.WriteLine($"You listed {count} items!");

            ActivityLog.LogActivity("Listing", _duration);
            DisplayEndingMessage();
        }
    }
}
