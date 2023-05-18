public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }

    public void SetTopNumber(int number)
    {
        _top = number;
    }

    public int GetTopNumber()
    {
        return _top;
    }

    public void SetBottomNumber(int number)
    {
        _bottom = number;
    }

    public int GetBottomNumber()
    {
        return _bottom;
    }

}