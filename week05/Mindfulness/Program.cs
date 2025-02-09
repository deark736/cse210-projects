using System;
using System.Threading;

namespace MindfulnessProgram
{
    /*
     * Enhancements and Creativity:
     * - Added a new activity: JournalActivity (to record personal journal entries).
     * - Implemented an ActivityLog that saves activity details to a file ("activity_log.txt")
     *   and allows the user to view a log summary.
     * - In ReflectingActivity, ensured that each reflective question is used once before repeating.
     * - Updated the BreathingActivity with a more creative animation (growing/shrinking bars).
     * - The menu now has extra options to run the new activity and display the log summary.
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start Breathing Activity");
                Console.WriteLine("  2. Start Reflecting Activity");
                Console.WriteLine("  3. Start Listing Activity");
                Console.WriteLine("  4. Start Journal Activity");
                Console.WriteLine("  5. Display Log Summary");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            BreathingActivity breathingActivity = new BreathingActivity();
                            breathingActivity.Run();
                            break;
                        }
                    case "2":
                        {
                            ReflectingActivity reflectingActivity = new ReflectingActivity();
                            reflectingActivity.Run();
                            break;
                        }
                    case "3":
                        {
                            ListingActivity listingActivity = new ListingActivity();
                            listingActivity.Run();
                            break;
                        }
                    case "4":
                        {
                            JournalActivity journalActivity = new JournalActivity();
                            journalActivity.Run();
                            break;
                        }
                    case "5":
                        {
                            ActivityLog.DisplayLogSummary();
                            break;
                        }
                    case "6":
                        {
                            keepRunning = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice. Please try again.");
                            Thread.Sleep(2000);
                            break;
                        }
                }
            }
        }
    }
}
