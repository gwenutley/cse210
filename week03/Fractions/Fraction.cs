using System.Globalization;

public class Fraction
{
    //example of private attributes
    private int _topNumber;
    private int _bottomNumber;
    public Fraction()
    {
        //construct example taking no argument
        _topNumber = 1;
        _bottomNumber = 1;
    }
    public Fraction(int top)
    {
        //construct example taking one argument
        _topNumber = top;
        _bottomNumber = 1;
    }
    public Fraction(int top, int bottom)
    {
        //construct example taking 2 arguments
        _topNumber = top;
        _bottomNumber = bottom;
    }
    public string GetFractionString()
    {
        //methods or function example
        string text = ($"{_topNumber}/{_bottomNumber}");
        return text;
    }

    public double GetFractionDecimal()
    {
        //methods or function example
        return (double)_topNumber / (double)_bottomNumber;
    }
}