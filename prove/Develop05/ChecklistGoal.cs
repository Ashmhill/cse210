public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int totalRequired;
    private int bonusPoints;

    public ChecklistGoal(string name, int value, int required, int bonus) : base(name)
    {
        Value = value;
        timesCompleted = 0;
        totalRequired = required;
        bonusPoints = bonus;
    }

    public override void RecordCompletion()
    {
        timesCompleted++;
        Value += timesCompleted < totalRequired ? Value : bonusPoints;
    }

    public override string PrintStatus()
    {
        return $"[{Name}] Completed {timesCompleted}/{totalRequired} times";
    }
}

