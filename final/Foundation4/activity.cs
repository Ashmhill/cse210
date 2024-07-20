using System;

public abstract class Activity
{
    private DateTime date;
    private int lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    protected DateTime Date => date;
    protected int LengthInMinutes => lengthInMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({LengthInMinutes} min) - Distance {GetDistance()} {GetDistanceUnit()}, Speed {GetSpeed()} {GetSpeedUnit()}, Pace: {GetPace()} min per {GetDistanceUnit()}";
    }

    protected virtual string GetDistanceUnit() => "miles";
    protected virtual string GetSpeedUnit() => "mph";
}
