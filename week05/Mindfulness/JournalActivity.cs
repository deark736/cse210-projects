using System;

namespace MindfulnessProgram
{
    /// <summary>
    /// The JournalActivity is a new activity that allows the user to record a personal journal entry.
    /// This activity exceeds the core requirements by adding a new kind of mindfulness exercise.
    /// </summary>
    public class JournalActivity : Activity
    {
        public JournalActivity()
            : base("Journal", "This activity will allow you to record your thoughts in a mindfulness journal. Write about your day, your feelings, or anything you’d like to reflect on.")
        {
        }

        public void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine("Please write your journal entry below. When you are finished, press Enter:");
            string entry = Console.ReadLine();

            // Log the journal entry.
            ActivityLog.LogJournalEntry("Journal", _duration, entry);

            Console.WriteLine("Your journal entry has been saved.");
            DisplayEndingMessage();
        }
    }
}
