using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    /// <summary>
    /// The ReflectingActivity guides the user to reflect on personal experiences.
    /// This version ensures that each reflective question is used once before repeating.
    /// </summary>
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectingActivity()
            : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. Recognize your inner power and how you can use it in other aspects of your life.")
        {
            _prompts = new List<string>()
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            _questions = new List<string>()
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }

        public void Run()
        {
            DisplayStartingMessage();

            // Choose and display a random prompt.
            Random random = new Random();
            int promptIndex = random.Next(_prompts.Count);
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"--- {_prompts[promptIndex]} ---");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience:");

            // Create a working copy of the questions to ensure no repetition until all are used.
            List<string> remainingQuestions = new List<string>(_questions);

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                // If all questions have been used, reset the list.
                if (remainingQuestions.Count == 0)
                {
                    remainingQuestions = new List<string>(_questions);
                }

                int index = random.Next(remainingQuestions.Count);
                string question = remainingQuestions[index];
                // Remove the chosen question from the pool.
                remainingQuestions.RemoveAt(index);

                Console.Write($"> {question} ");
                ShowSpinner(5); // Time for reflection with a spinner animation.
                Console.WriteLine();
            }

            ActivityLog.LogActivity("Reflecting", _duration);
            DisplayEndingMessage();
        }
    }
}
