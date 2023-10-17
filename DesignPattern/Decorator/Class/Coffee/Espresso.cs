namespace DesignPattern.Decorator;

public class Espresso : Coffee
{
    private readonly List<string> _descriptions;
    private readonly double _cost;
    public Espresso()
    {
        _descriptions = new List<string>
        {
            nameof(Espresso)
        };
        _cost = 300;
    }

    public override double Cost()
    {
        return _cost;
    }

    public override List<string> GetDescriptions()
    {
        return _descriptions;
    }
}