public class Swim : Activity
{
    private double _laps;

    public double GetLaps()
    {
        return _laps;
    }

    public Swim(string date, double length, double laps)
        : base(date, length)
    {
        _laps = laps; 
    }
    public override double CalcDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double CalcSpeed()
    {
        return (CalcDistance() / GetLength()) * 60;
    }

    public override double CalcPace()
    {
        return 60 / CalcSpeed();
    }
   
}