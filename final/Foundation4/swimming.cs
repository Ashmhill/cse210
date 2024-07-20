using System;

public class Swimming : Activity
{
    private int laps; // number of laps

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return (laps * 50) / 1000.0; // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    protected override string GetDistanceUnit() => "km";
    protected override string GetSpeedUnit() => "kph";
}
