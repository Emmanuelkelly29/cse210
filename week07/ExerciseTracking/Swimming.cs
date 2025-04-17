using System;

public class Swimming : Activity
{
    private int _laps; // number of laps

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        return $"Swimming on {Date:yyyy-MM-dd}: Duration = {Length} mins, Distance = {distance:F2} km, Speed = {GetSpeed():F2} km/h, Pace = {GetPace():F2} min/km";
    }

    public override double GetDistance() => _laps * 50 / 1000.0; // 50 meters per lap converted to kilometers

    public override double GetSpeed() => GetDistance() / (Length / 60.0);

    public override double GetPace() => Length / GetDistance();
}
