using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;

public class Run : Activity
{
    private double _distance;

    public double GetDistance()
    {
        return _distance;
    }

    public Run(string _date, double _length, double distance)
        : base(_date, _length)
    {
        _distance = distance;  
    }
    public override double CalcDistance()
    {
        return _distance;
    }

    public override double CalcSpeed()
    {
        return (_distance / GetLength()) * 60;
    }

    public override double CalcPace()
    {
        return GetLength() / _distance;
    }

}