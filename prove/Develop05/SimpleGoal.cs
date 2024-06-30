public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name)
    {
        Value = value;
    }

    public override void RecordCompletion()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            // Add value when completed once
            // Example: Add 1000 points for running a marathon
        }
    }
}
