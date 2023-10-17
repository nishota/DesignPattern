
namespace DesignPattern.Decorator;

public class Milk : CondimentDecorator
{
    private readonly Coffee _coffee;
    private readonly List<string> _descriptions;
    private readonly double _cost;
    public Milk(Coffee coffee)
    {
        _coffee = coffee;
        _descriptions = new List<string>();
        _descriptions.AddRange(_coffee.GetDescriptions());
        _descriptions.Add(nameof(Milk));
        _cost = _coffee.Cost();
    }

    public override double Cost()
    {
        return _cost + 70;
    }

    public override List<string> GetDescriptions()
    {
        _descriptions.Sort();
        return _descriptions;
    }
}