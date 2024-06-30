public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name)
    {
        Value = value;
    }

    public override void RecordCompletion()
    {
        // Always add value when recorded
        // Example: Add 100 points for reading scriptures daily
        Value += 100;
    }
}
