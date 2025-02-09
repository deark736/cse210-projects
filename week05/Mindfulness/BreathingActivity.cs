using System;
using System.Threading;

namespace MindfulnessProgram
{
    /// <summary>
    /// The BreathingActivity guides the user through a breathing exercise.
    /// This version uses Console.SetCursorPosition to update the bar animation in place,
    /// preventing unwanted movement caused by rewriting the entire line.
    /// </summary>
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
            : base("Breathing", "This activity will help you relax by guiding you through slow, deep breathing. Clear your mind and focus on your breathing.")
        {
        }

        public void Run()
        {
            DisplayStartingMessage();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            // Continue alternating until the specified duration has passed.
            while (DateTime.Now < endTime)
            {
                // Breathe in with a growing bar animation (4 seconds)
                Console.Write("Breathe in: ");
                int leftPosition = Console.CursorLeft;  // Save where the bar starts
                for (int i = 0; i < 4; i++)
                {
                    string bar = new string('#', i + 1);
                    // Set the cursor position back to where the bar begins
                    Console.SetCursorPosition(leftPosition, Console.CursorTop);
                    // Write the bar and pad to ensure any previous longer bar is overwritten
                    Console.Write(bar.PadRight(4));
                    Thread.Sleep(1000);
                }
                Console.WriteLine();

                // Breathe out with a shrinking bar animation (6 seconds)
                Console.Write("Breathe out: ");
                leftPosition = Console.CursorLeft;  // Save where the bar begins
                for (int i = 0; i < 6; i++)
                {
                    string bar = new string('#', 6 - i);
                    Console.SetCursorPosition(leftPosition, Console.CursorTop);
                    Console.Write(bar.PadRight(6));
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }

            DisplayEndingMessage();
        }
    }
}
