using System;

namespace MindfulnessProgram
{
    abstract class Activity
    {
        public virtual void Start()
        {
            Console.WriteLine("Starting activity...");
        }

        public void End(string activityName, int duration)
        {
            Console.WriteLine($"You have completed the {activityName} activity for {duration} seconds.");
            Console.WriteLine("Good job!");
        }
    }
}
