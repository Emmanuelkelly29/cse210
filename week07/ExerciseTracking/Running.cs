using System;

public class Running : Activity
{
    private double _distance; // in kilometers

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override string GetSummary()
    {
        return $"Running on {Date:yyyy-MM-dd}: Duration = {Length} mins, Distance = {_distance} km, Speed = {GetSpeed():F2} km/h, Pace = {GetPace():F2} min/km";
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => _distance / (Length / 60.0);

    public override double GetPace() => Length / _distance;
}
