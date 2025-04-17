using System;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public int Length { get; set; } // in minutes

    public Activity(DateTime date, int length)
    {
        Date = date;
        Length = length;
    }

    public abstract string GetSummary();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}
