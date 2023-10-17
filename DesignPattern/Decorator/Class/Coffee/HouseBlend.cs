namespace DesignPattern.Decorator;

public class HouseBlend : Coffee
{
    private readonly List<string> _descriptions;
    private readonly double _cost;
    public HouseBlend()
    {
        _descriptions = new List<string>
        {
            nameof(HouseBlend)
        };
        _cost = 250;
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