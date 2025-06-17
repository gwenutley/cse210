using System.Diagnostics;

public class Bike : Activity
{
    private double _speed;

    public double GetSpeed()
    {
        return _speed;
    }

    public Bike(string date, double length, double speed)
        : base(date, length)
    {
        _speed = speed;   
    }

    public override double CalcDistance()
    {
        return GetLength() / CalcPace();
    }

    public override double CalcSpeed()
    {
        return _speed;
    }

    public override double CalcPace()
    {
        return 60 / _speed;
    }
}