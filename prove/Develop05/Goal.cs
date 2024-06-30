public abstract class Goal
{
    protected string Name { get; set; }
    protected int Value { get; set; }
    protected bool IsCompleted { get; set; }

    public Goal(string name)
    {
        Name = name;
        Value = 0;
        IsCompleted = false;
    }

    public abstract void RecordCompletion();

    public virtual string PrintStatus()
    {
        return IsCompleted ? $"[{Name}] [X]" : $"[{Name}] [ ]";
    }

    public int GetValue()
    {
        return Value;
    }
}
