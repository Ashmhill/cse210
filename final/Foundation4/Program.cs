using System;

class Program
{
    static void Main()
    {
        // Create activities
        Activity running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Activity cycling = new Cycling(new DateTime(2022, 11, 4), 45, 12.0);
        Activity swimming = new Swimming(new DateTime(2022, 11, 5), 60, 20);

        // Store activities in a list
        Activity[] activities = { running, cycling, swimming };

        // Display summaries for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(new string('=', 40));
        }
    }
}
