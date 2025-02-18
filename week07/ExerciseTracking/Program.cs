using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of Activity objects.
        List<Activity> activities = new List<Activity>();

        // Create a RunningActivity (date, duration, distance).
        activities.Add(new RunningActivity(new DateTime(2022, 11, 03), 30, 3.0));

        // Create a CyclingActivity (date, duration, speed in mph).
        activities.Add(new CyclingActivity(new DateTime(2022, 11, 03), 45, 15));

        // Create a SwimmingActivity (date, duration, number of laps).
        activities.Add(new SwimmingActivity(new DateTime(2022, 11, 03), 40, 20));

        // Iterate through the list and display the summary for each activity.
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
