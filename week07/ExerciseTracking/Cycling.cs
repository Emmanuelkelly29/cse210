using System;

public class Cycling : Activity
{
    private double _speed; // in kilometers per hour

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        return $"Cycling on {Date:yyyy-MM-dd}: Duration = {Length} mins, Distance = {distance:F2} km, Speed = {_speed:F2} km/h";
    }

    public override double GetDistance() => _speed * (Length / 60.0);

    public override double GetSpeed() => _speed;

    public override double GetPace() => Length / GetDistance();
}
