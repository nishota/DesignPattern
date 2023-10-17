
namespace DesignPattern.Decorator;

public class Mocha : CondimentDecorator
{
    private readonly Coffee _coffee;
    private readonly List<string> _descriptions;
    private readonly double _cost;
    public Mocha(Coffee coffee)
    {
        _coffee = coffee;
        _descriptions = new List<string>();
        _descriptions.AddRange(_coffee.GetDescriptions());
        _descriptions.Add(nameof(Mocha));
        _cost = _coffee.Cost();
    }

    public override double Cost()
    {
        return _cost + 50;
    }

    public override List<string> GetDescriptions()
    {
        _descriptions.Sort();
        return _descriptions;
    }
}