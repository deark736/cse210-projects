// GoalManager.cs
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _previousLevel;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _previousLevel = 1;
    }

    public void DisplayPlayerInfo()
    {
        int level = _score / 1000 + 1;
        Console.WriteLine($"\nYour current score is: {_score}");
        Console.WriteLine($"Your current level is: {level}");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nSelect goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal (for habits you want to avoid)");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;
        if (choice == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (choice == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (choice == "3")
        {
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }
        else if (choice == "4")
        {
            newGoal = new NegativeGoal(name, description, points);
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
            return;
        }
        _goals.Add(newGoal);
        Console.WriteLine("Goal created!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish? (Enter number)");
        ListGoalDetails();
        int index = int.Parse(Console.ReadLine());
        if (index > 0 && index <= _goals.Count)
        {
            int earned = _goals[index - 1].RecordEvent();
            _score += earned;
            Console.WriteLine($"Event recorded! You {(earned >= 0 ? "earned" : "lost")} {Math.Abs(earned)} points.");

            // Check for level up: every 1,000 points is a new level.
            int newLevel = _score / 1000 + 1;
            if (newLevel > _previousLevel)
            {
                Console.WriteLine($"Congratulations! You leveled up to Level {newLevel}!");
                _previousLevel = newLevel;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("\nEnter filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine(_score);
            foreach (var goal in _goals)
            {
                sw.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        Console.Write("\nEnter filename to load: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            if (lines.Length > 0)
            {
                _score = int.Parse(lines[0]);
                _previousLevel = _score / 1000 + 1;
                _goals.Clear();
                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    // Expected format: Type:restOfData
                    string[] parts = line.Split(':');
                    if (parts.Length < 2)
                        continue;

                    string goalType = parts[0];
                    string data = parts[1];
                    string[] details = data.Split(',');
                    Goal goal = null;
                    if (goalType == "SimpleGoal")
                    {
                        string name = details[0];
                        string description = details[1];
                        int points = int.Parse(details[2]);
                        bool isComplete = bool.Parse(details[3]);
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        if (isComplete && !simpleGoal.IsComplete())
                        {
                            simpleGoal.RecordEvent();
                        }
                        goal = simpleGoal;
                    }
                    else if (goalType == "EternalGoal")
                    {
                        string name = details[0];
                        string description = details[1];
                        int points = int.Parse(details[2]);
                        goal = new EternalGoal(name, description, points);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        string name = details[0];
                        string description = details[1];
                        int points = int.Parse(details[2]);
                        int amountCompleted = int.Parse(details[3]);
                        int target = int.Parse(details[4]);
                        int bonus = int.Parse(details[5]);
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                        // Record events to reflect saved progress.
                        for (int j = 0; j < amountCompleted; j++)
                        {
                            checklistGoal.RecordEvent();
                        }
                        goal = checklistGoal;
                    }
                    else if (goalType == "NegativeGoal")
                    {
                        string name = details[0];
                        string description = details[1];
                        int points = int.Parse(details[2]);
                        bool isTriggered = bool.Parse(details[3]);
                        NegativeGoal negativeGoal = new NegativeGoal(name, description, points);
                        if (isTriggered && !negativeGoal.IsComplete())
                        {
                            negativeGoal.RecordEvent();
                        }
                        goal = negativeGoal;
                    }
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
                Console.WriteLine("Goals loaded!");
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }

    // The main loop that drives the menu.
    public void Start()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score & Level");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    DisplayPlayerInfo();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}
