using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();

    static void Main()
    {
        // Example usage:
        SetupGoals();
        RecordEvents();
        DisplayGoals();
        DisplayScore();
        SaveLoadGoals(); // Implement saving and loading functionality
    }

    static void SetupGoals()
    {
        goals.Add(new SimpleGoal("Run a Marathon", 1000));
        goals.Add(new EternalGoal("Read Scriptures", 100));
        goals.Add(new ChecklistGoal("Attend Temple", 50, 10, 500));
        // Add more goals as needed
    }

    static void RecordEvents()
    {
        // Example: Record completion of goals
        goals[0].RecordCompletion(); // Simulates completing "Run a Marathon"
        goals[1].RecordCompletion(); // Simulates reading scriptures
        goals[2].RecordCompletion(); // Simulates attending temple
        goals[2].RecordCompletion();
        // Record more events as needed
    }

    static void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.PrintStatus());
        }
    }

    static void DisplayScore()
    {
        int totalScore = 0;
        foreach (Goal goal in goals)
        {
            totalScore += goal.GetValue();
        }
        Console.WriteLine($"Total Score: {totalScore}");
    }

    static void SaveLoadGoals()
    {
        // Implement save and load functionality using file I/O or database
        // Example: Serialize goals to JSON or XML for saving/loading
    }
}
