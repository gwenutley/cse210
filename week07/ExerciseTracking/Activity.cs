using System.ComponentModel.DataAnnotations;

public abstract class Activity
{
    private double _length;
    private string _date;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetLength()
    {
        return _length;
    }
    public abstract double CalcDistance();
    public abstract double CalcSpeed();
    public abstract double CalcPace();

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} - Distance: {CalcDistance():0.00} miles, Speed: {CalcSpeed():0.00} mph, Pace: {CalcPace():0.00} min per mile";
    }
}