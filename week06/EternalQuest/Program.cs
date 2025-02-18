// Program.cs
using System;

class Program
{
    /*
     * EXTRA FEATURES:
     * - Added a leveling system where the player's level increases every 1,000 points earned.
     *   When a new level is reached, the program congratulates the player.
     * - Introduced a NegativeGoal type that allows the user to track habits they want to avoid.
     *   Recording a NegativeGoal deducts points from the player's score.
     */

    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
