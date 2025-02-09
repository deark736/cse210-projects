using System;
using System.IO;

namespace MindfulnessProgram
{
    /// <summary>
    /// ActivityLog is a static class that keeps a log of all activities performed.
    /// It writes log entries to "activity_log.txt".
    /// </summary>
    public static class ActivityLog
    {
        private static readonly string logFilePath = "activity_log.txt";

        public static void LogActivity(string activityName, int duration)
        {
            string logEntry = $"{DateTime.Now}: Completed {activityName} Activity for {duration} seconds.";
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        }

        public static void LogJournalEntry(string activityName, int duration, string entry)
        {
            string logEntry = $"{DateTime.Now}: {activityName} Activity for {duration} seconds. Journal entry: {entry}";
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        }

        public static void DisplayLogSummary()
        {
            Console.Clear();
            if (File.Exists(logFilePath))
            {
                Console.WriteLine("Activity Log Summary:");
                Console.WriteLine("---------------------");
                Console.WriteLine(File.ReadAllText(logFilePath));
            }
            else
            {
                Console.WriteLine("No log file found.");
            }
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}
