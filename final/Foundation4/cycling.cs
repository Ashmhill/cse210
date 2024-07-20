using System;

public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * LengthInMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
}
